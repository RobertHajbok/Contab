namespace Contab
{
    partial class CreateUserForm
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_OptionalPassword = new System.Windows.Forms.Label();
            this.txt_StartingMoney = new System.Windows.Forms.TextBox();
            this.lbl_StartingMoney = new System.Windows.Forms.Label();
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.txt_Currency = new System.Windows.Forms.TextBox();
            this.lbl_Currency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(155, 88);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(199, 22);
            this.txt_Password.TabIndex = 7;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(57, 88);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(83, 20);
            this.lbl_Password.TabIndex = 6;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(155, 33);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(199, 22);
            this.txt_Username.TabIndex = 5;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(49, 33);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(86, 20);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_OptionalPassword
            // 
            this.lbl_OptionalPassword.AutoSize = true;
            this.lbl_OptionalPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OptionalPassword.ForeColor = System.Drawing.Color.Red;
            this.lbl_OptionalPassword.Location = new System.Drawing.Point(41, 113);
            this.lbl_OptionalPassword.Name = "lbl_OptionalPassword";
            this.lbl_OptionalPassword.Size = new System.Drawing.Size(142, 17);
            this.lbl_OptionalPassword.TabIndex = 8;
            this.lbl_OptionalPassword.Text = "*Password is optional";
            // 
            // txt_StartingMoney
            // 
            this.txt_StartingMoney.Location = new System.Drawing.Point(155, 147);
            this.txt_StartingMoney.Name = "txt_StartingMoney";
            this.txt_StartingMoney.Size = new System.Drawing.Size(199, 22);
            this.txt_StartingMoney.TabIndex = 10;
            // 
            // lbl_StartingMoney
            // 
            this.lbl_StartingMoney.AutoSize = true;
            this.lbl_StartingMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartingMoney.Location = new System.Drawing.Point(14, 147);
            this.lbl_StartingMoney.Name = "lbl_StartingMoney";
            this.lbl_StartingMoney.Size = new System.Drawing.Size(121, 20);
            this.lbl_StartingMoney.TabIndex = 9;
            this.lbl_StartingMoney.Text = "Starting Money";
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreateUser.Location = new System.Drawing.Point(121, 245);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(121, 38);
            this.btn_CreateUser.TabIndex = 12;
            this.btn_CreateUser.Text = "Create User";
            this.btn_CreateUser.UseVisualStyleBackColor = true;
            this.btn_CreateUser.Click += new System.EventHandler(this.btn_CreateUser_Click);
            // 
            // txt_Currency
            // 
            this.txt_Currency.Location = new System.Drawing.Point(155, 192);
            this.txt_Currency.Name = "txt_Currency";
            this.txt_Currency.Size = new System.Drawing.Size(199, 22);
            this.txt_Currency.TabIndex = 14;
            // 
            // lbl_Currency
            // 
            this.lbl_Currency.AutoSize = true;
            this.lbl_Currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Currency.Location = new System.Drawing.Point(58, 192);
            this.lbl_Currency.Name = "lbl_Currency";
            this.lbl_Currency.Size = new System.Drawing.Size(77, 20);
            this.lbl_Currency.TabIndex = 13;
            this.lbl_Currency.Text = "Currency";
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 313);
            this.Controls.Add(this.txt_Currency);
            this.Controls.Add(this.lbl_Currency);
            this.Controls.Add(this.btn_CreateUser);
            this.Controls.Add(this.txt_StartingMoney);
            this.Controls.Add(this.lbl_StartingMoney);
            this.Controls.Add(this.lbl_OptionalPassword);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(384, 360);
            this.MinimumSize = new System.Drawing.Size(384, 360);
            this.Name = "CreateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_OptionalPassword;
        private System.Windows.Forms.TextBox txt_StartingMoney;
        private System.Windows.Forms.Label lbl_StartingMoney;
        private System.Windows.Forms.Button btn_CreateUser;
        private System.Windows.Forms.TextBox txt_Currency;
        private System.Windows.Forms.Label lbl_Currency;
    }
}