using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Contab
{
    public partial class UpdateOperationForm : Form
    {
        private readonly string _username;
        private readonly string _currentdate;

        public UpdateOperationForm(Operation operation)
        {
            InitializeComponent();
            txt_AddSubtract.Text = operation.AddSubtract;
            txt_CurrentMoney.Text = operation.CurrentMoney;
            txt_MoneyAfterOperation.Text = operation.MoneyAfterOperation;
            txt_Reason.Text = operation.Reason;
            dp_OperationDate.Value = DateTime.ParseExact(operation.OperationDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            _username = operation.Username;
            _currentdate = operation.CurrentDate;
        }

        private void btn_UpdateOperation_Click(object sender, EventArgs e)
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
            var operation = new Operation(_username, txt_CurrentMoney.Text, txt_AddSubtract.Text, txt_Reason.Text, 
                txt_MoneyAfterOperation.Text, dp_OperationDate.Value.ToString("dd-MM-yyyy"), _currentdate);

            var updatedOperation = new XElement("Operation", new XElement("Username", operation.Username),
                new XElement("CurrentMoney", operation.CurrentMoney),
                new XElement("AddSubtract", operation.AddSubtract),
                new XElement("Reason", operation.Reason),
                new XElement("MoneyAfterOperation", operation.MoneyAfterOperation),
                new XElement("OperationDate", operation.OperationDate),
                new XElement("CurrentDate", operation.CurrentDate));

            var doc = XDocument.Load("operations.xml");
            var xElement = doc.Element("Operations")?.Elements("Operation").First(x =>
                            x.Element("Username")?.Value == _username &&
                            x.Element("CurrentDate")?.Value == _currentdate);
            xElement?.ReplaceWith(updatedOperation);
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

            if (!decimal.TryParse(txt_CurrentMoney.Text, out x))
            {
                MessageBox.Show(@"Current Money value must be a decimal value!");
                return false;
            }

            if (!decimal.TryParse(txt_MoneyAfterOperation.Text, out x))
            {
                MessageBox.Show(@"Money After Operation value must be a decimal value!");
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

