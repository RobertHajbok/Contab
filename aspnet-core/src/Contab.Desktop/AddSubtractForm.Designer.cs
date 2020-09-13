using System;

namespace Contab
{
    partial class AddSubtractForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Reason = new System.Windows.Forms.TextBox();
            this.lbl_Reason = new System.Windows.Forms.Label();
            this.txt_AddSubtract = new System.Windows.Forms.TextBox();
            this.lbl_AddSubtract = new System.Windows.Forms.Label();
            this.lbl_OperationDate = new System.Windows.Forms.Label();
            this.btn_AddOperation = new System.Windows.Forms.Button();
            this.dp_OperationDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txt_Reason
            // 
            this.txt_Reason.Location = new System.Drawing.Point(154, 81);
            this.txt_Reason.Name = "txt_Reason";
            this.txt_Reason.Size = new System.Drawing.Size(199, 22);
            this.txt_Reason.TabIndex = 7;
            // 
            // lbl_Reason
            // 
            this.lbl_Reason.AutoSize = true;
            this.lbl_Reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reason.Location = new System.Drawing.Point(45, 81);
            this.lbl_Reason.Name = "lbl_Reason";
            this.lbl_Reason.Size = new System.Drawing.Size(66, 20);
            this.lbl_Reason.TabIndex = 6;
            this.lbl_Reason.Text = "Reason";
            // 
            // txt_AddSubtract
            // 
            this.txt_AddSubtract.Location = new System.Drawing.Point(154, 26);
            this.txt_AddSubtract.Name = "txt_AddSubtract";
            this.txt_AddSubtract.Size = new System.Drawing.Size(199, 22);
            this.txt_AddSubtract.TabIndex = 5;
            // 
            // lbl_AddSubtract
            // 
            this.lbl_AddSubtract.AutoSize = true;
            this.lbl_AddSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddSubtract.Location = new System.Drawing.Point(28, 26);
            this.lbl_AddSubtract.Name = "lbl_AddSubtract";
            this.lbl_AddSubtract.Size = new System.Drawing.Size(106, 20);
            this.lbl_AddSubtract.TabIndex = 4;
            this.lbl_AddSubtract.Text = "Add/Subtract";
            // 
            // lbl_OperationDate
            // 
            this.lbl_OperationDate.AutoSize = true;
            this.lbl_OperationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OperationDate.Location = new System.Drawing.Point(12, 134);
            this.lbl_OperationDate.Name = "lbl_OperationDate";
            this.lbl_OperationDate.Size = new System.Drawing.Size(123, 20);
            this.lbl_OperationDate.TabIndex = 8;
            this.lbl_OperationDate.Text = "Operation Date";
            // 
            // btn_AddOperation
            // 
            this.btn_AddOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddOperation.Location = new System.Drawing.Point(126, 187);
            this.btn_AddOperation.Name = "btn_AddOperation";
            this.btn_AddOperation.Size = new System.Drawing.Size(148, 37);
            this.btn_AddOperation.TabIndex = 10;
            this.btn_AddOperation.Text = "Add Operation";
            this.btn_AddOperation.UseVisualStyleBackColor = true;
            this.btn_AddOperation.Click += new System.EventHandler(this.btn_AddOperation_Click);
            // 
            // dp_OperationDate
            // 
            this.dp_OperationDate.Location = new System.Drawing.Point(153, 134);
            this.dp_OperationDate.Name = "dp_OperationDate";
            this.dp_OperationDate.Size = new System.Drawing.Size(200, 22);
            this.dp_OperationDate.TabIndex = 11;
            // 
            // AddSubtractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 247);
            this.Controls.Add(this.dp_OperationDate);
            this.Controls.Add(this.btn_AddOperation);
            this.Controls.Add(this.lbl_OperationDate);
            this.Controls.Add(this.txt_Reason);
            this.Controls.Add(this.lbl_Reason);
            this.Controls.Add(this.txt_AddSubtract);
            this.Controls.Add(this.lbl_AddSubtract);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 294);
            this.MinimumSize = new System.Drawing.Size(393, 294);
            this.Name = "AddSubtractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Subtract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Reason;
        private System.Windows.Forms.Label lbl_Reason;
        private System.Windows.Forms.TextBox txt_AddSubtract;
        private System.Windows.Forms.Label lbl_AddSubtract;
        private System.Windows.Forms.Label lbl_OperationDate;
        private System.Windows.Forms.Button btn_AddOperation;
        private System.Windows.Forms.DateTimePicker dp_OperationDate;
    }
}