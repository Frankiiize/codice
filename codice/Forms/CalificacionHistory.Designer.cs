namespace codice.Forms
{
    partial class CalificacionHistory
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
            label1 = new Label();
            dataGridCalificaciones = new DataGridView();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCalificaciones).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.4413147F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.68075F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.87793422F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 5;
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
            labelTitle.Text = "Historial Calificaciones";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.84313726F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.27451F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.04575157F));
            tableLayoutPanel2.Controls.Add(inputRut, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridCalificaciones, 1, 3);
            tableLayoutPanel2.Controls.Add(button1, 1, 1);
            tableLayoutPanel2.Location = new Point(62, 54);
            tableLayoutPanel2.Margin = new Padding(1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20);
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7647057F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 64.70588F));
            tableLayoutPanel2.Size = new Size(652, 363);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // inputRut
            // 
            inputRut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputRut.Font = new Font("Segoe UI", 14F);
            inputRut.Location = new Point(87, 23);
            inputRut.Margin = new Padding(20, 3, 3, 3);
            inputRut.Name = "inputRut";
            inputRut.Size = new Size(504, 32);
            inputRut.TabIndex = 29;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(24, 24);
            label1.Margin = new Padding(4);
            label1.Name = "label1";
            label1.Size = new Size(39, 30);
            label1.TabIndex = 25;
            label1.Text = "Rut";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dataGridCalificaciones
            // 
            dataGridCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCalificaciones.Location = new Point(70, 137);
            dataGridCalificaciones.Name = "dataGridCalificaciones";
            dataGridCalificaciones.Size = new Size(521, 203);
            dataGridCalificaciones.TabIndex = 24;
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
            button1.Location = new Point(440, 62);
            button1.Name = "button1";
            button1.Size = new Size(151, 30);
            button1.TabIndex = 30;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // CalificacionHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "CalificacionHistory";
            Text = "CalificacionHistory";
            Load += CalificacionHistory_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCalificaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTitle;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private DataGridView dataGridCalificaciones;
        private TextBox inputRut;
        private Button button1;
    }
}