namespace codice.Forms
{
    partial class StudentForm
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
            labelTitle = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            inputRut = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            inputNombre = new TextBox();
            inputApellido = new TextBox();
            inputTelefono = new TextBox();
            inputCorreo = new TextBox();
            inputFechaNacimiento = new DateTimePicker();
            label1 = new Label();
            inputCursos = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            ActBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4413147F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 73.70892F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.6150236F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(17, 24, 39);
            labelTitle.Location = new Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(770, 53);
            labelTitle.TabIndex = 3;
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0282478F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.34865F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.6231127F));
            tableLayoutPanel2.Controls.Add(inputRut, 1, 0);
            tableLayoutPanel2.Controls.Add(label12, 0, 5);
            tableLayoutPanel2.Controls.Add(label10, 0, 4);
            tableLayoutPanel2.Controls.Add(label8, 0, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(inputNombre, 1, 1);
            tableLayoutPanel2.Controls.Add(inputApellido, 1, 2);
            tableLayoutPanel2.Controls.Add(inputTelefono, 1, 3);
            tableLayoutPanel2.Controls.Add(inputCorreo, 1, 4);
            tableLayoutPanel2.Controls.Add(inputFechaNacimiento, 1, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 6);
            tableLayoutPanel2.Controls.Add(inputCursos, 1, 6);
            tableLayoutPanel2.Location = new Point(62, 54);
            tableLayoutPanel2.Margin = new Padding(1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20);
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel2.Size = new Size(652, 298);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // inputRut
            // 
            inputRut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputRut.Font = new Font("Segoe UI", 14F);
            inputRut.Location = new Point(156, 23);
            inputRut.Margin = new Padding(20, 3, 3, 3);
            inputRut.Name = "inputRut";
            inputRut.Size = new Size(401, 32);
            inputRut.TabIndex = 23;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(24, 204);
            label12.Margin = new Padding(4);
            label12.Name = "label12";
            label12.Size = new Size(108, 28);
            label12.TabIndex = 10;
            label12.Text = "Fecha Nacimiento";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(24, 168);
            label10.Margin = new Padding(4);
            label10.Name = "label10";
            label10.Size = new Size(108, 28);
            label10.TabIndex = 8;
            label10.Text = "Correo";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(24, 132);
            label8.Margin = new Padding(4);
            label8.Name = "label8";
            label8.Size = new Size(108, 28);
            label8.TabIndex = 6;
            label8.Text = "Teléfono";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(24, 96);
            label6.Margin = new Padding(4);
            label6.Name = "label6";
            label6.Size = new Size(108, 28);
            label6.TabIndex = 4;
            label6.Text = "Apellido";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(24, 60);
            label4.Margin = new Padding(4);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 2;
            label4.Text = "Nombre";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(24, 24);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 0;
            label2.Text = "RUT";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputNombre
            // 
            inputNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputNombre.Font = new Font("Segoe UI", 14F);
            inputNombre.Location = new Point(156, 59);
            inputNombre.Margin = new Padding(20, 3, 3, 3);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(401, 32);
            inputNombre.TabIndex = 14;
            // 
            // inputApellido
            // 
            inputApellido.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputApellido.Font = new Font("Segoe UI", 14F);
            inputApellido.Location = new Point(156, 95);
            inputApellido.Margin = new Padding(20, 3, 3, 3);
            inputApellido.Name = "inputApellido";
            inputApellido.Size = new Size(401, 32);
            inputApellido.TabIndex = 15;
            // 
            // inputTelefono
            // 
            inputTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputTelefono.Font = new Font("Segoe UI", 14F);
            inputTelefono.Location = new Point(156, 131);
            inputTelefono.Margin = new Padding(20, 3, 3, 3);
            inputTelefono.Name = "inputTelefono";
            inputTelefono.Size = new Size(401, 32);
            inputTelefono.TabIndex = 16;
            // 
            // inputCorreo
            // 
            inputCorreo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputCorreo.Font = new Font("Segoe UI", 14F);
            inputCorreo.Location = new Point(156, 167);
            inputCorreo.Margin = new Padding(20, 3, 3, 3);
            inputCorreo.Name = "inputCorreo";
            inputCorreo.Size = new Size(401, 32);
            inputCorreo.TabIndex = 17;
            // 
            // inputFechaNacimiento
            // 
            inputFechaNacimiento.Font = new Font("Segoe UI", 14F);
            inputFechaNacimiento.Location = new Point(156, 203);
            inputFechaNacimiento.Margin = new Padding(20, 3, 3, 3);
            inputFechaNacimiento.Name = "inputFechaNacimiento";
            inputFechaNacimiento.Size = new Size(401, 32);
            inputFechaNacimiento.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(24, 240);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(108, 34);
            label1.TabIndex = 21;
            label1.Text = "Inscribir Curso";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputCursos
            // 
            inputCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputCursos.Font = new Font("Segoe UI", 14F);
            inputCursos.FormattingEnabled = true;
            inputCursos.Location = new Point(156, 239);
            inputCursos.Margin = new Padding(20, 3, 3, 3);
            inputCursos.Name = "inputCursos";
            inputCursos.Size = new Size(401, 33);
            inputCursos.TabIndex = 22;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0000019F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(ActBtn, 4, 0);
            tableLayoutPanel3.Location = new Point(3, 370);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(770, 48);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // ActBtn
            // 
            ActBtn.Anchor = AnchorStyles.Left;
            ActBtn.BackColor = Color.FromArgb(37, 99, 235);
            ActBtn.FlatAppearance.BorderColor = Color.White;
            ActBtn.FlatAppearance.BorderSize = 0;
            ActBtn.FlatAppearance.MouseDownBackColor = Color.White;
            ActBtn.FlatAppearance.MouseOverBackColor = Color.White;
            ActBtn.Font = new Font("Segoe UI", 12F);
            ActBtn.ForeColor = Color.White;
            ActBtn.Location = new Point(616, 3);
            ActBtn.Name = "ActBtn";
            ActBtn.Size = new Size(151, 42);
            ActBtn.TabIndex = 4;
            ActBtn.Text = "Ir";
            ActBtn.UseVisualStyleBackColor = false;
            ActBtn.Click += button1_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label12;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label2;
        private TextBox inputNombre;
        private TextBox inputApellido;
        private TextBox inputTelefono;
        private TextBox inputCorreo;
        private DateTimePicker inputFechaNacimiento;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ActBtn;
        private Label label1;
        private ComboBox inputCursos;
        private Label labelTitle;
        private TextBox inputRut;
    }
}