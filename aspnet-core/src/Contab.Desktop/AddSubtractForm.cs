using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Contab
{
    public partial class AddSubtractForm : Form
    {
        private readonly decimal _currentMoney;
        private readonly string _username;

        public AddSubtractForm(decimal currentMoney, string username)
        {
            InitializeComponent();

            _currentMoney = currentMoney;
            _username = username;

            if (File.Exists("operations.xml")) return;
            using (var sw = File.CreateText("operations.xml"))
            {
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw.WriteLine("<Operations>");
                sw.WriteLine("</Operations>");
            }
        }

        private void btn_AddOperation_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;
            WriteToXml();
            Hide();

            try
            {
                var principalForm = Application.OpenForms.OfType<OperationsForm>().Single();

                principalForm.PopulateGridView();
            }
            catch (Exception)
            {
                var dr = MessageBox.Show(@"Too many Operation Forms opened! Application will be relaunched!");
                if (dr == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }

        private void WriteToXml()
        {
            var moneyAfterOperation = decimal.Parse(txt_AddSubtract.Text);
            moneyAfterOperation += _currentMoney;

            var operation = new Operation(_username,_currentMoney.ToString(CultureInfo.InvariantCulture), txt_AddSubtract.Text,
                txt_Reason.Text, moneyAfterOperation.ToString(CultureInfo.InvariantCulture), dp_OperationDate.Value.ToString("dd-MM-yyyy"),
                DateTime.Now.ToString(CultureInfo.InvariantCulture));

            var newOperation = new XElement("Operation", new XElement("Username", _username), new XElement("CurrentMoney", operation.CurrentMoney),
                new XElement("AddSubtract", operation.AddSubtract),
                new XElement("Reason", operation.Reason),
                new XElement("MoneyAfterOperation", operation.MoneyAfterOperation),
                new XElement("OperationDate", operation.OperationDate),
                new XElement("CurrentDate", operation.CurrentDate));
            XDocument doc;

            if (File.Exists("operations.xml"))
            {
                doc = XDocument.Load("operations.xml");
                var xElement = doc.Element("Operations");
                xElement?.Add(newOperation);
            }
            else
            {
                doc = new XDocument(new XElement("Operations", newOperation));
            }
            doc.Save("operations.xml");
        }

        private bool ValidateForm()
        {
            //Value to Add/Subtract decimal validation
            decimal x;

            if (!decimal.TryParse(txt_AddSubtract.Text, out x))
            {
                MessageBox.Show(@"Add/subtract value must be a decimal value!");
                return false;
            }

            //Check if value to Add/Subtract is not 0
            if (decimal.Parse(txt_AddSubtract.Text) == 0)
            {
                 MessageBox.Show(@"Add/subtract value can not be 0!");
                return false;
            }
            

            //Reason length validation
            if (txt_Reason.Text.Length < 10)
            {
                MessageBox.Show(@"You must have 10 or more characters to describe reason!");
                return false;
            }

            //Reason alphanumeric validation
            var reasonRegex = new Regex("^[ a-zA-Z0-9\\/\\-\\,\\.\\!\\?\\(\\)\\%\\+]*$");
            if (reasonRegex.IsMatch(txt_Reason.Text)) return true;
            MessageBox.Show(@"Reason must have only alphanumeric characters!");
            return false;
        }
    }
}

