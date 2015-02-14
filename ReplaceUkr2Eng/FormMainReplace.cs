using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Collections;
using System.Threading;

namespace ReplaceUkr2Eng
{
    public partial class FormMainReplace : Form
    {
        // private ManualResetEvent _stopEvent = null;

        public FormMainReplace()
        {
            InitializeComponent();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (AppSettings.Translations.Count == 0)
            {
                MessageBox.Show("The list of translation pairs is empty. Read the list first", "Error");

                return;
            }

            menuStrip.Enabled = false;
            textBoxSource.Enabled = false;
            textBoxResult.Enabled = false;

            Thread threadReplace = new Thread(replaceAll);
            threadReplace.Start();
            
//            replaceAll();
        }

        private void FormMainReplace_Resized(object sender, EventArgs e)
        {
            textBoxSource.Width = Width - textBoxSource.Left - 20;
            textBoxResult.Width = textBoxSource.Width;

            int between = textBoxSource.Top - menuStrip.Bottom;

            textBoxSource.Height = (int)((Height - menuStrip.Bottom - statusStrip.Height) / 2) - 3 * between;
            textBoxResult.Height = textBoxSource.Height;

            textBoxResult.Top = textBoxSource.Bottom + between;
            labelResult.Top = textBoxResult.Top;
        }

        private void buttonReadTranslationPairs_Click(object sender, EventArgs e)
        {
            string line, left, right;
            string[] parts;

            openFileDialogTranslations.InitialDirectory = Environment.CurrentDirectory;
            openFileDialogTranslations.ShowDialog();

            string fileName = openFileDialogTranslations.FileName;

            if (fileName == "" || fileName == null)
               return;

            IDictionary translationsTemp = new Hashtable();

            menuStrip.Enabled = false;
            textBoxSource.Enabled = false;
            textBoxResult.Enabled = false;

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (sr.Peek() >= 0)
                    {
                        line = sr.ReadLine();

                        if (line.Trim() != "") // We ignore empty lines
                            try
                            {
                                parts = line.Split('|');

                                if (parts.Length != 2)
                                    MessageBox.Show(
                                        string.Format("Wrong line [{0}]: not a [ukr|eng] pair with exactly one | separator", line),
                                        "Error");
                                else
                                {
                                    left = parts[0].Trim();
                                    right = parts[1].Trim();

                                    if (left == "")
                                        MessageBox.Show(
                                            string.Format("Wrong line [{0}]: Ukrainian word/phrase is empty", line), "Error");
                                    else if (right == "")
                                        MessageBox.Show(
                                            string.Format("Wrong line [{0}]: English word/phrase is empty", line), "Error");
                                    else
                                    {
                                        translationsTemp.Add(left, right);
                                    }
                                }
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(
                                    string.Format("Could not read or process the line [{0}]: {1}", line, exc.Message), "Error");
                            }
                    }
                }

                AppSettings.Translations = translationsTemp;
                MessageBox.Show(string.Format("{0} translation pairs have been read", translationsTemp.Count));
            }
            catch
            {
                MessageBox.Show("Could not read the file", "Error");
            }
            finally
            {
                menuStrip.Enabled = true;
                textBoxSource.Enabled = true;
                textBoxResult.Enabled = true;
            }
        }

        private void replaceAll()
        {
            string input, pattern, replacement, result;
            Regex rgx;
            string currentText = textBoxSource.Text;

            foreach (string phraseUkr in AppSettings.Translations.Keys)
            {
                string phraseEng = (string)AppSettings.Translations[phraseUkr];

                input = currentText;

                pattern = "(\\W+|^)(" + phraseUkr + ")(\\W+|$)";

                replacement = "$1" + phraseEng + "$3";

                try
                {
                    rgx = new Regex(pattern, RegexOptions.CultureInvariant & RegexOptions.Compiled);

                    result = rgx.Replace(input, replacement);

                    toolStripStatusLabel.Text = string.Format("LAST MESSAGE: Successfully replaced: [{0}] -> [{1}]", phraseUkr, phraseEng);

                    currentText = result;
                }
                catch (Exception exc)
                {
                    try
                    {
                        toolStripStatusLabel.Text =
                            string.Format("LAST MESSAGE: Unable to replace[{0}] with [{1}]: {2}. Ignored",
                            phraseUkr, phraseEng, exc.Message);
                        
                        MessageBox.Show(string.Format("Unable to replace[{0}] with [{1}]: {2}. Ignored", 
                            phraseUkr, phraseEng, exc.Message), "Error");
                    }
                    catch { }
                }
            }

            if (textBoxResult.InvokeRequired)
            {
                textBoxResult.Invoke(new MethodInvoker(delegate { textBoxResult.Text = currentText; }));
            }
            else
                textBoxResult.Text = currentText;

            MessageBox.Show("Replaced");

            textBoxSource.Enabled = true;
            textBoxResult.Enabled = true;

            if (menuStrip.InvokeRequired)
            {
                menuStrip.Invoke(new MethodInvoker(delegate { menuStrip.Enabled = true; }));
            }
            else
                menuStrip.Enabled = true;
        }
    }
}
