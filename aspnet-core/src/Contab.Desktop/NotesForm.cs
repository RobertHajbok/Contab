using System;
using System.IO;
using System.Windows.Forms;

namespace Contab
{
    public partial class NotesForm : Form
    {
        private readonly string _username;

        readonly EncryptDecrypt _encryptDecrypt = new EncryptDecrypt();

        public NotesForm(string username)
        {
            InitializeComponent();

            _username = username;

            ReadFromFile();
        }

        private void ReadFromFile()
        {
            var path = _username + "Notes.txt";

            try
            {
                //_encryptDecrypt.DecryptFile(path, "decrypted.txt");

                //Pass the file path and file name to the StreamReader constructor
                var sr = new StreamReader(path);

                //Read the first line of text
                var line = sr.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    txt_Notes.Text += line + Environment.NewLine;
                    //Read the next line
                    line = sr.ReadLine();
                }

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var path = _username + "Notes.txt";

            try
            {
                using (var sw = new StreamWriter(path))
                {
                    foreach (var line in txt_Notes.Lines)
                        sw.Write(line + Environment.NewLine);
                }

                //_encryptDecrypt.EncryptFile(path, "encrypted.txt");

                Close();
			}
			catch(Exception ex)
			{
			    MessageBox.Show(ex.ToString());
			}
        }
    }
}
