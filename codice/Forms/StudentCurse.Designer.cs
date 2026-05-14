namespace codice.Forms
{
    partial class StudentCurse
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
            button3 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            inputRut = new TextBox();
            button2 = new Button();
            tableStudentInfo = new TableLayoutPanel();
            labelNombre = new Label();
            listAsignatura = new CheckedListBox();
            labelAsignatura = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnAgregar = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableStudentInfo.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.0787392F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.41315F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6150236F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(80, 0);
            label1.Name = "label1";
            label1.Size = new Size(693, 51);
            label1.TabIndex = 0;
            label1.Text = "Asignar Cursos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(37, 99, 235);
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Size = new Size(70, 33);
            button3.TabIndex = 8;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.386076F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.74683F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0253162F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(inputRut, 1, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 1);
            tableLayoutPanel2.Controls.Add(tableStudentInfo, 1, 2);
            tableLayoutPanel2.Location = new Point(90, 66);
            tableLayoutPanel2.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1944447F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 74.30556F));
            tableLayoutPanel2.Size = new Size(672, 298);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(9, 9);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(47, 28);
            label2.TabIndex = 0;
            label2.Text = "RUT";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputRut
            // 
            inputRut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputRut.Font = new Font("Segoe UI", 14F);
            inputRut.Location = new Point(80, 8);
            inputRut.Margin = new Padding(20, 3, 3, 3);
            inputRut.Name = "inputRut";
            inputRut.Size = new Size(504, 32);
            inputRut.TabIndex = 13;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(37, 99, 235);
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(495, 45);
            button2.Name = "button2";
            button2.Size = new Size(89, 29);
            button2.TabIndex = 15;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonBuscarEstudiante_1;
            // 
            // tableStudentInfo
            // 
            tableStudentInfo.ColumnCount = 1;
            tableStudentInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableStudentInfo.Controls.Add(labelNombre, 0, 1);
            tableStudentInfo.Controls.Add(listAsignatura, 0, 2);
            tableStudentInfo.Controls.Add(labelAsignatura, 0, 0);
            tableStudentInfo.Location = new Point(60, 79);
            tableStudentInfo.Margin = new Padding(0);
            tableStudentInfo.Name = "tableStudentInfo";
            tableStudentInfo.RowCount = 3;
            tableStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2922869F));
            tableStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0434771F));
            tableStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 74.66424F));
            tableStudentInfo.Size = new Size(507, 205);
            tableStudentInfo.TabIndex = 16;
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 14F);
            labelNombre.ForeColor = Color.FromArgb(17, 24, 39);
            labelNombre.Location = new Point(3, 25);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(501, 26);
            labelNombre.TabIndex = 3;
            // 
            // listAsignatura
            // 
            listAsignatura.FormattingEnabled = true;
            listAsignatura.Location = new Point(3, 54);
            listAsignatura.Name = "listAsignatura";
            listAsignatura.Size = new Size(501, 148);
            listAsignatura.TabIndex = 0;
            // 
            // labelAsignatura
            // 
            labelAsignatura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelAsignatura.AutoSize = true;
            labelAsignatura.Font = new Font("Segoe UI", 14F);
            labelAsignatura.ForeColor = Color.FromArgb(17, 24, 39);
            labelAsignatura.Location = new Point(3, 0);
            labelAsignatura.Name = "labelAsignatura";
            labelAsignatura.Size = new Size(501, 25);
            labelAsignatura.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999962F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999962F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnAgregar, 3, 0);
            tableLayoutPanel3.Location = new Point(80, 370);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(693, 53);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAgregar.BackColor = Color.FromArgb(37, 99, 235);
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(522, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(168, 42);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Confirmar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // StudentCurse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "StudentCurse";
            Text = "StudentCurse";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableStudentInfo.ResumeLayout(false);
            tableStudentInfo.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox inputRut;
        private Button button2;
        private TableLayoutPanel tableStudentInfo;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnAgregar;
        private CheckedListBox listAsignatura;
        private Label labelAsignatura;
        private Label labelNombre;
    }
}