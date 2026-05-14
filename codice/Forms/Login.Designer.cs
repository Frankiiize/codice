namespace codice
{
    partial class Login
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            loginBtn = new Button();
            inputPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            inputEmail = new TextBox();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8930845F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.10691F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(770, 54);
            label1.TabIndex = 0;
            label1.Text = "Sistema Codice";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(loginBtn, 0, 5);
            tableLayoutPanel2.Controls.Add(inputPassword, 0, 4);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(inputEmail, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Location = new Point(186, 78);
            tableLayoutPanel2.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20);
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9659042F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9353971F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0197468F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0197411F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0197411F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.0394745F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(404, 345);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginBtn.BackColor = Color.FromArgb(37, 99, 235);
            loginBtn.FlatAppearance.BorderColor = Color.White;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.White;
            loginBtn.FlatAppearance.MouseOverBackColor = Color.White;
            loginBtn.Font = new Font("Segoe UI", 12F);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(261, 266);
            loginBtn.Margin = new Padding(3, 30, 3, 3);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(120, 36);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "LogIn";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button1_Click;
            // 
            // inputPassword
            // 
            inputPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputPassword.Font = new Font("Segoe UI", 14F);
            inputPassword.Location = new Point(23, 197);
            inputPassword.Name = "inputPassword";
            inputPassword.PasswordChar = '*';
            inputPassword.Size = new Size(358, 32);
            inputPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(17, 24, 39);
            label3.Location = new Point(23, 160);
            label3.Name = "label3";
            label3.Size = new Size(358, 25);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(23, 85);
            label2.Name = "label2";
            label2.Size = new Size(358, 25);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // inputEmail
            // 
            inputEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputEmail.Font = new Font("Segoe UI", 14F);
            inputEmail.Location = new Point(23, 113);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(358, 32);
            inputEmail.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F);
            label5.ForeColor = Color.FromArgb(17, 24, 39);
            label5.Location = new Point(23, 36);
            label5.Name = "label5";
            label5.Size = new Size(358, 41);
            label5.TabIndex = 6;
            label5.Text = "Login";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox inputPassword;
        private Label label3;
        private TextBox inputEmail;
        private Button loginBtn;
        private Label label5;
    }
}