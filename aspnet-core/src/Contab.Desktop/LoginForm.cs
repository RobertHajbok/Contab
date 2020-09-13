using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Contab
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txt_Password.PasswordChar = '*';
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            var createUserForm = new CreateUserForm();
            Hide();
            createUserForm.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!File.Exists("users.xml"))
            {
                using (var sw = File.CreateText("users.xml"))
                {
                    sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    sw.WriteLine("<Users>");
                    sw.WriteLine("</Users>");
                }
            }

            var doc = XDocument.Load("users.xml");
            foreach (var operationsForm in from us in doc.Descendants("User")
                let element = us.Element("Password")
                let element1 = us.Element("Username")
                where element1 != null
                let xElement = element1
                where xElement != null && xElement.Value == txt_Username.Text where element != null && element.Value == txt_Password.Text
                let xElement1 = us.Element("StartingDate")
                where xElement1 != null
                let xElement2 = us.Element("StartingMoney")
                where xElement2 != null
                let xElement3 = us.Element("Currency")
                where xElement3 != null
                select new OperationsForm(element1.Value,
                decimal.Parse(xElement2.Value), xElement3.Value, DateTime.Parse(xElement1.Value)))
            {
                Hide();
                operationsForm.Show();
                return;
            }

            MessageBox.Show(@"Incorrect username/password!");
        }
    }
}
