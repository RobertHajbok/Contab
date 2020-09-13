using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Contab
{
    public partial class OperationsForm : Form
    {
        private readonly string _username;

        public OperationsForm(string username, decimal startingMoney, string currency, DateTime startingDate)
        {
            _username = username;

            InitializeComponent();

            lbl_UserValue.Text = username;
            lbl_CurrencyValue.Text = currency;
            lbl_StartingMoneyValue.Text = startingMoney.ToString(CultureInfo.InvariantCulture);
            lbl_StartingDateValue.Text = startingDate.ToString("dd-MM-yyyy");

            PopulateGridView();
        }

        public void PopulateGridView()
        {
            if (!File.Exists("operations.xml"))
            {
                using (var sw = File.CreateText("operations.xml"))
                {
                    sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    sw.WriteLine("<Operations>");
                    sw.WriteLine("</Operations>");
                }
            }

            dgv_Operations.Rows.Clear();

            var doc = XDocument.Load("operations.xml");
            foreach (object[] toAdd in from us in doc.Descendants("Operation") let xElement = us.Element("Username")
                                       where xElement != null && xElement.Value == _username let element = us.Element("CurrentMoney")
                                       where element != null let xElement1 = us.Element("AddSubtract")
                                       where xElement1 != null let element1 = us.Element("Reason")
                                       where element1 != null let xElement2 = us.Element("MoneyAfterOperation")
                                       where xElement2 != null let element2 = us.Element("OperationDate")
                                       where element2 != null let xElement3 = us.Element("CurrentDate")
                                       where xElement3 != null select new[] { (dgv_Operations.RowCount + 1).ToString(CultureInfo.InvariantCulture), element.Value, xElement1.Value, element1.Value, xElement2.Value, element2.Value, xElement3.Value })
            {
                var list = toAdd.ToList();
                var expectedMoney = decimal.Parse(lbl_StartingMoneyValue.Text);
                if (dgv_Operations.RowCount > 0)
                {
                    for (var i = 0; i < dgv_Operations.RowCount; i++)
                        expectedMoney += decimal.Parse(dgv_Operations.Rows[i].Cells[2].Value.ToString());
                }
                expectedMoney += decimal.Parse(toAdd[2].ToString());
                list.Insert(5, expectedMoney);
                dgv_Operations.Rows.Add(list.ToArray());
            }

            var rowCount = dgv_Operations.RowCount;
            var currentMoney = decimal.Parse(rowCount == 0 ? lbl_StartingMoneyValue.Text : dgv_Operations.Rows[rowCount - 1].Cells[4].Value.ToString());
            lbl_CurrentMoneyValue.Text = currentMoney.ToString(CultureInfo.InvariantCulture);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            Close();
        }

        private void btn_AddOperation_Click(object sender, EventArgs e)
        {
            chk_ColorsExpectedMoney.Checked = false;
            chk_ColorsAddSubtract.Checked = false;
            var rowCount = dgv_Operations.RowCount;

            var currentMoney = decimal.Parse(rowCount == 0 ? lbl_StartingMoneyValue.Text : dgv_Operations.Rows[rowCount - 1].Cells[4].Value.ToString());

            var addSubtractForm = new AddSubtractForm(currentMoney, _username);
            addSubtractForm.Show();
        }

        private void chk_ColorsAddSubtract_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ColorsExpectedMoney.Checked)
                chk_ColorsExpectedMoney.Checked = false;

            if (chk_ColorsAddSubtract.Checked)
            {
                for (var i =0; i< dgv_Operations.Rows.Count;i++)
                {
                    dgv_Operations.Rows[i].DefaultCellStyle.BackColor = decimal.Parse(dgv_Operations.Rows[i].Cells[2].Value.ToString()) < 0 ? Color.Red : Color.ForestGreen;
                }
            }
            else
            {
                for (var i = 0; i < dgv_Operations.RowCount; i++)
                {
                    dgv_Operations.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void btnOpenNotes_Click(object sender, EventArgs e)
        {
            var notesForm = new NotesForm(_username);
            notesForm.Show();
        }

        private void OperationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chk_ColorsExpectedMoney_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ColorsAddSubtract.Checked)
                chk_ColorsAddSubtract.Checked = false;

            if (chk_ColorsExpectedMoney.Checked)
            {
                for (var i = 0; i < dgv_Operations.Rows.Count; i++)
                {
                    dgv_Operations.Rows[i].DefaultCellStyle.BackColor = dgv_Operations.Rows[i].Cells[4].Value.ToString() == dgv_Operations.Rows[i].Cells[5].Value.ToString() ? Color.DeepSkyBlue : Color.DarkOrange;
                }
            }
            else
            {
                for (var i = 0; i < dgv_Operations.RowCount; i++)
                {
                    dgv_Operations.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dgv_Operations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 8) return;
            var operation = new Operation
            {
                CurrentMoney = dgv_Operations.Rows[e.RowIndex].Cells[1].Value.ToString(),
                AddSubtract = dgv_Operations.Rows[e.RowIndex].Cells[2].Value.ToString(),
                Reason = dgv_Operations.Rows[e.RowIndex].Cells[3].Value.ToString(),
                MoneyAfterOperation = dgv_Operations.Rows[e.RowIndex].Cells[4].Value.ToString(),
                OperationDate = dgv_Operations.Rows[e.RowIndex].Cells[6].Value.ToString(),
                CurrentDate = dgv_Operations.Rows[e.RowIndex].Cells[7].Value.ToString(),
                Username = _username
            };
            var addSubtractForm = new UpdateOperationForm(operation);
            addSubtractForm.Show();
        }

        private void btn_ViewChart_Click(object sender, EventArgs e)
        {
            var operations = new List<Operation>();
            for (var i = 0; i < dgv_Operations.Rows.Count; i++)
            {
                operations.Add(new Operation
                {
                    OperationDate = dgv_Operations.Rows[i].Cells["OperationDate"].Value.ToString(),
                    CurrentMoney = dgv_Operations.Rows[i].Cells["CurrentMoney"].Value.ToString(),
                    MoneyAfterOperation = dgv_Operations.Rows[i].Cells["MoneyAfterOperation"].Value.ToString()
                });
            }
            var chartForm = new ChartForm(operations);
            chartForm.Show();
        }
    }
}
