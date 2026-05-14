namespace codice.Forms
{
    partial class AsistenciaAddForm
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
            comboBoxCursos = new ComboBox();
            comboboxAsignaturas = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dataGridEstudiantes = new DataGridView();
            label3 = new Label();
            inputFechaAsistencia = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            ActBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEstudiantes).BeginInit();
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
            labelTitle.Text = "Asistencia";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.02825F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.34864F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.6231108F));
            tableLayoutPanel2.Controls.Add(comboBoxCursos, 1, 0);
            tableLayoutPanel2.Controls.Add(comboboxAsignaturas, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridEstudiantes, 1, 3);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(inputFechaAsistencia, 1, 2);
            tableLayoutPanel2.Location = new Point(62, 54);
            tableLayoutPanel2.Margin = new Padding(1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20);
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.2352943F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3382349F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.3382349F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 57.35294F));
            tableLayoutPanel2.Size = new Size(652, 312);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // comboBoxCursos
            // 
            comboBoxCursos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxCursos.Font = new Font("Segoe UI", 14F);
            comboBoxCursos.FormattingEnabled = true;
            comboBoxCursos.Location = new Point(156, 23);
            comboBoxCursos.Margin = new Padding(20, 3, 3, 3);
            comboBoxCursos.Name = "comboBoxCursos";
            comboBoxCursos.Size = new Size(401, 33);
            comboBoxCursos.TabIndex = 26;
            comboBoxCursos.SelectedIndexChanged += comboBoxCursos_SelectedIndexChanged;
            // 
            // comboboxAsignaturas
            // 
            comboboxAsignaturas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboboxAsignaturas.Font = new Font("Segoe UI", 14F);
            comboboxAsignaturas.FormattingEnabled = true;
            comboboxAsignaturas.Location = new Point(156, 59);
            comboboxAsignaturas.Margin = new Padding(20, 3, 3, 3);
            comboboxAsignaturas.Name = "comboboxAsignaturas";
            comboboxAsignaturas.Size = new Size(401, 33);
            comboboxAsignaturas.TabIndex = 23;
            comboboxAsignaturas.SelectedIndexChanged += comboboxAsignaturas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(24, 60);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(108, 31);
            label2.TabIndex = 0;
            label2.Text = "Asignatura";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 25;
            label1.Text = "Curso";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridEstudiantes
            // 
            dataGridEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEstudiantes.Location = new Point(139, 137);
            dataGridEstudiantes.Name = "dataGridEstudiantes";
            dataGridEstudiantes.Size = new Size(418, 152);
            dataGridEstudiantes.TabIndex = 24;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(24, 99);
            label3.Margin = new Padding(4);
            label3.Name = "label3";
            label3.Size = new Size(108, 31);
            label3.TabIndex = 27;
            label3.Text = "Fecha";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputFechaAsistencia
            // 
            inputFechaAsistencia.Font = new Font("Segoe UI", 14F);
            inputFechaAsistencia.Location = new Point(156, 98);
            inputFechaAsistencia.Margin = new Padding(20, 3, 3, 3);
            inputFechaAsistencia.Name = "inputFechaAsistencia";
            inputFechaAsistencia.Size = new Size(401, 32);
            inputFechaAsistencia.TabIndex = 28;
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
            ActBtn.Text = "Confirmar";
            ActBtn.UseVisualStyleBackColor = false;
            ActBtn.Click += ActBtn_Click;
            // 
            // AsistenciaAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "AsistenciaAddForm";
            Text = "AsistenciaAddForm";
            Load += AsistenciaAddForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEstudiantes).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTitle;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox comboboxAsignaturas;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ActBtn;
        private DataGridView dataGridEstudiantes;
        private Label label1;
        private ComboBox comboBoxCursos;
        private Label label3;
        private DateTimePicker inputFechaAsistencia;
    }
}