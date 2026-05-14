namespace codice.Forms
{
    partial class AsistenciaManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsistenciaManagement));
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            label5 = new Label();
            GoRegistrar = new Button();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Controls.Add(button3, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.0787392F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.02427F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8969917F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 3;
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
            button3.TabIndex = 7;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            label1.Text = "Gestion Asistencia";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1045294F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.84321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1045294F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.84321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.1045294F));
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 3, 0);
            tableLayoutPanel2.Location = new Point(80, 54);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(693, 288);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(GoRegistrar);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(73, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 282);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.ForeColor = Color.FromArgb(107, 114, 128);
            label5.Location = new Point(7, 161);
            label5.Name = "label5";
            label5.Size = new Size(202, 51);
            label5.TabIndex = 4;
            label5.Text = "Registra la asistencia de los estudiantes según el curso, asignatura y fecha seleccionada.";
            // 
            // GoRegistrar
            // 
            GoRegistrar.BackColor = Color.FromArgb(37, 99, 235);
            GoRegistrar.FlatAppearance.BorderColor = Color.White;
            GoRegistrar.FlatAppearance.BorderSize = 0;
            GoRegistrar.FlatAppearance.MouseDownBackColor = Color.White;
            GoRegistrar.FlatAppearance.MouseOverBackColor = Color.White;
            GoRegistrar.Font = new Font("Segoe UI", 12F);
            GoRegistrar.ForeColor = Color.White;
            GoRegistrar.Location = new Point(131, 236);
            GoRegistrar.Name = "GoRegistrar";
            GoRegistrar.Size = new Size(89, 33);
            GoRegistrar.TabIndex = 3;
            GoRegistrar.Text = "Ir";
            GoRegistrar.UseVisualStyleBackColor = false;
            GoRegistrar.Click += GoRegistrar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(232, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(17, 24, 39);
            label4.Location = new Point(3, 126);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 1;
            label4.Text = "Agregar";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(384, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 282);
            panel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.ForeColor = Color.FromArgb(107, 114, 128);
            label7.Location = new Point(7, 161);
            label7.Name = "label7";
            label7.Size = new Size(202, 51);
            label7.TabIndex = 6;
            label7.Text = "Consulta el historial de asistencia de los estudiantes por curso, asignatura y fecha.";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 99, 235);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(135, 236);
            button1.Name = "button1";
            button1.Size = new Size(89, 33);
            button1.TabIndex = 3;
            button1.Text = "Ir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(4, 126);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Historial";
            // 
            // AsistenciaManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "AsistenciaManagement";
            Text = "AsistenciaManagement";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Label label5;
        private Button GoRegistrar;
        private PictureBox pictureBox3;
        private Label label4;
        private Panel panel1;
        private Label label7;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}