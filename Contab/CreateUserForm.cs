using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Contab
{
    public partial class CreateUserForm : Form
    {
        readonly EncryptDecrypt _encryptDecrypt = new EncryptDecrypt();

        public CreateUserForm()
        {
            InitializeComponent();

            txt_Password.PasswordChar = '*';

            if (File.Exists("users.xml")) return;
            using (var sw = File.CreateText("users.xml"))
            {
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw.WriteLine("<Users>");
                sw.WriteLine("</Users>");
            }
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            WriteToXml();
            CreateNotesFile();
            var loginForm = new LoginForm();
            Hide();
            loginForm.Show();
        }

        private void CreateNotesFile()
        {
            var filename = txt_Username.Text + "Notes.txt";
            using (File.Create(filename))
            {
            }

            _encryptDecrypt.EncryptFile(filename, "encrypted.txt");
        }

        private void WriteToXml()
        {
            var user = new User(txt_Username.Text, txt_Password.Text, txt_StartingMoney.Text, txt_Currency.Text, DateTime.Now);

            var newUser = new XElement("User", new XElement("Username", user.Username),
                new XElement("Password", user.Password), new XElement("StartingMoney", user.StartingMoney),
                new XElement("Currency", user.Currency), new XElement("StartingDate", user.StartingDate));
            XDocument doc;

            if (File.Exists("users.xml"))
            {
                doc = XDocument.Load("users.xml");
                var xElement = doc.Element("Users");
                xElement?.Add(newUser);
            }
            else
            {
                doc = new XDocument(new XElement("Users", newUser));
            }
            doc.Save("users.xml");
        }

        private bool ValidateForm()
        {
            //Check if username already exists
            var doc = XDocument.Load("users.xml");
            if (doc.Descendants("User").Any(us =>
            {
                var xElement = us.Element("Username");
                return xElement != null && xElement.Value == txt_Username.Text;
            }))
            {
                MessageBox.Show(@"Username already exists!");
                return false;
            }

            //Username length validation
            if (txt_Username.Text.Length < 6)
            {
                MessageBox.Show(@"Username must have at least 6 characters!");
                return false;
            }

            //Username alphanumeric validation
            var usernameRegex = new Regex("^[a-zA-Z0-9]*$");
            if (!usernameRegex.IsMatch(txt_Username.Text))
            {
                MessageBox.Show(@"Username must have only alphanumeric characters!");
                return false;
            }

            //Password length validation
            if (txt_Password.Text.Length < 6 && txt_Password.Text.Length != 0)
            {
                MessageBox.Show(@"If you have a password, it must have at least 6 characters!");
                return false;
            }

            //Password alphanumeric validation
            var passwordRegex = new Regex("^[a-zA-Z0-9]*$");
            if (!passwordRegex.IsMatch(txt_Password.Text))
            {
                MessageBox.Show(@"Password must have only alphanumeric characters!");
                return false;
            }

            //Currency length validation
            if (txt_Currency.Text.Length != 3)
            {
                MessageBox.Show(@"Currency must have exactly 3 characters!");
                return false;
            }

            //Username alphanumeric validation
            var currencyRegex = new Regex("^[A-Z]*$");
            if (!currencyRegex.IsMatch(txt_Currency.Text))
            {
                MessageBox.Show(@"Currency must have only capital letters!");
                return false;
            }

            //Starting money decimal validation
            decimal x;

            if (decimal.TryParse(txt_StartingMoney.Text, out x))
                return true;
            MessageBox.Show(@"Starting money must have a decimal value!");
            return false;
        }
    }
}
