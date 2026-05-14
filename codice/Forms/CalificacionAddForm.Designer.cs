namespace codice.Forms
{
    partial class CalificacionAddForm
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
            label2 = new Label();
            button1 = new Button();
            inputFechaCalificacion = new DateTimePicker();
            label12 = new Label();
            label4 = new Label();
            inputAsignatura = new ComboBox();
            inputNota = new TextBox();
            labelEval = new Label();
            inputEvaluacion = new TextBox();
            label6 = new Label();
            labelNombre = new Label();
            labelCurso = new Label();
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
            tableLayoutPanel1.TabIndex = 3;
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
            labelTitle.Text = "Registrar Calificacion";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.1090345F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.37383F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.517134F));
            tableLayoutPanel2.Controls.Add(inputRut, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 1, 1);
            tableLayoutPanel2.Controls.Add(inputFechaCalificacion, 1, 6);
            tableLayoutPanel2.Controls.Add(label12, 0, 6);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Controls.Add(inputAsignatura, 1, 4);
            tableLayoutPanel2.Controls.Add(inputNota, 1, 7);
            tableLayoutPanel2.Controls.Add(labelEval, 0, 5);
            tableLayoutPanel2.Controls.Add(inputEvaluacion, 1, 5);
            tableLayoutPanel2.Controls.Add(label6, 0, 7);
            tableLayoutPanel2.Controls.Add(labelNombre, 1, 2);
            tableLayoutPanel2.Controls.Add(labelCurso, 1, 3);
            tableLayoutPanel2.Location = new Point(62, 54);
            tableLayoutPanel2.Margin = new Padding(1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2516556F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.602649F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2649F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9072847F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2384109F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9072847F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Size = new Size(652, 312);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // inputRut
            // 
            inputRut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputRut.Font = new Font("Segoe UI", 14F);
            inputRut.Location = new Point(122, 8);
            inputRut.Margin = new Padding(20, 3, 3, 3);
            inputRut.Name = "inputRut";
            inputRut.Size = new Size(493, 32);
            inputRut.TabIndex = 23;
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
            label2.Size = new Size(89, 30);
            label2.TabIndex = 0;
            label2.Text = "RUT";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(37, 99, 235);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(464, 46);
            button1.Name = "button1";
            button1.Size = new Size(151, 30);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // inputFechaCalificacion
            // 
            inputFechaCalificacion.Font = new Font("Segoe UI", 14F);
            inputFechaCalificacion.Location = new Point(122, 228);
            inputFechaCalificacion.Margin = new Padding(20, 3, 3, 3);
            inputFechaCalificacion.Name = "inputFechaCalificacion";
            inputFechaCalificacion.Size = new Size(422, 32);
            inputFechaCalificacion.TabIndex = 20;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.ForeColor = Color.FromArgb(17, 24, 39);
            label12.Location = new Point(9, 229);
            label12.Margin = new Padding(4);
            label12.Name = "label12";
            label12.Size = new Size(89, 34);
            label12.TabIndex = 10;
            label12.Text = "Fecha";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(17, 24, 39);
            label4.Location = new Point(9, 144);
            label4.Margin = new Padding(4);
            label4.Name = "label4";
            label4.Size = new Size(89, 34);
            label4.TabIndex = 2;
            label4.Text = "Asignatura";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputAsignatura
            // 
            inputAsignatura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inputAsignatura.Font = new Font("Segoe UI", 14F);
            inputAsignatura.FormattingEnabled = true;
            inputAsignatura.Location = new Point(122, 143);
            inputAsignatura.Margin = new Padding(20, 3, 3, 3);
            inputAsignatura.Name = "inputAsignatura";
            inputAsignatura.Size = new Size(493, 33);
            inputAsignatura.TabIndex = 27;
            // 
            // inputNota
            // 
            inputNota.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputNota.Font = new Font("Segoe UI", 14F);
            inputNota.Location = new Point(122, 271);
            inputNota.Margin = new Padding(20, 3, 3, 3);
            inputNota.Name = "inputNota";
            inputNota.Size = new Size(493, 32);
            inputNota.TabIndex = 28;
            // 
            // labelEval
            // 
            labelEval.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEval.AutoSize = true;
            labelEval.Font = new Font("Segoe UI", 12F);
            labelEval.ForeColor = Color.FromArgb(17, 24, 39);
            labelEval.Location = new Point(9, 186);
            labelEval.Margin = new Padding(4);
            labelEval.Name = "labelEval";
            labelEval.Size = new Size(89, 35);
            labelEval.TabIndex = 26;
            labelEval.Text = "Evaluacion";
            labelEval.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputEvaluacion
            // 
            inputEvaluacion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputEvaluacion.Font = new Font("Segoe UI", 14F);
            inputEvaluacion.Location = new Point(122, 187);
            inputEvaluacion.Margin = new Padding(20, 3, 3, 3);
            inputEvaluacion.Name = "inputEvaluacion";
            inputEvaluacion.Size = new Size(493, 32);
            inputEvaluacion.TabIndex = 25;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(17, 24, 39);
            label6.Location = new Point(9, 271);
            label6.Margin = new Padding(4);
            label6.Name = "label6";
            label6.Size = new Size(89, 32);
            label6.TabIndex = 4;
            label6.Text = "Nota";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F);
            labelNombre.ForeColor = Color.FromArgb(17, 24, 39);
            labelNombre.Location = new Point(122, 80);
            labelNombre.Margin = new Padding(20, 0, 3, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(493, 29);
            labelNombre.TabIndex = 29;
            // 
            // labelCurso
            // 
            labelCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCurso.AutoSize = true;
            labelCurso.Font = new Font("Segoe UI", 12F);
            labelCurso.ForeColor = Color.FromArgb(17, 24, 39);
            labelCurso.Location = new Point(122, 109);
            labelCurso.Margin = new Padding(20, 0, 3, 0);
            labelCurso.Name = "labelCurso";
            labelCurso.Size = new Size(493, 31);
            labelCurso.TabIndex = 30;
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
            ActBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            ActBtn.Text = "Registrar";
            ActBtn.UseVisualStyleBackColor = false;
            ActBtn.Click += ActBtn_Click;
            // 
            // CalificacionAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "CalificacionAddForm";
            Text = "CalificacionAddForm";
            Load += CalificacionAddForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTitle;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox inputRut;
        private Label label12;
        private Label label6;
        private Label label4;
        private Label label2;
        private DateTimePicker inputFechaCalificacion;
        private Label labelCurso;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ActBtn;
        private TextBox inputEvaluacion;
        private Label labelEval;
        private Button button1;
        private ComboBox inputAsignatura;
        private TextBox inputNota;
        private Label labelNombre;
    }
}