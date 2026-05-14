namespace codice.Forms
{
    partial class StudentView
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
            labelEdad = new Label();
            label13 = new Label();
            labelCurso = new Label();
            label11 = new Label();
            labelCorreo = new Label();
            label9 = new Label();
            labelTelefono = new Label();
            label7 = new Label();
            labelApellido = new Label();
            label5 = new Label();
            labelNombre = new Label();
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnEditar = new Button();
            buttonAsignaturas = new Button();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 69.02427F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8969917F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 2;
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
            label1.Text = "Ver Estudiantes";
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
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.17088F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.2915611F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(inputRut, 1, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 1);
            tableLayoutPanel2.Controls.Add(tableStudentInfo, 1, 2);
            tableLayoutPanel2.Location = new Point(90, 66);
            tableLayoutPanel2.Margin = new Padding(3, 15, 3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20);
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Size = new Size(672, 276);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(24, 24);
            label2.Margin = new Padding(4);
            label2.Name = "label2";
            label2.Size = new Size(45, 27);
            label2.TabIndex = 0;
            label2.Text = "RUT";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputRut
            // 
            inputRut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputRut.Font = new Font("Segoe UI", 14F);
            inputRut.Location = new Point(93, 23);
            inputRut.Margin = new Padding(20, 3, 3, 3);
            inputRut.Name = "inputRut";
            inputRut.Size = new Size(490, 32);
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
            button2.Location = new Point(494, 58);
            button2.Name = "button2";
            button2.Size = new Size(89, 29);
            button2.TabIndex = 15;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tableStudentInfo
            // 
            tableStudentInfo.ColumnCount = 2;
            tableStudentInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3553715F));
            tableStudentInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.64463F));
            tableStudentInfo.Controls.Add(labelEdad, 1, 5);
            tableStudentInfo.Controls.Add(label13, 0, 5);
            tableStudentInfo.Controls.Add(labelCurso, 1, 4);
            tableStudentInfo.Controls.Add(label11, 0, 4);
            tableStudentInfo.Controls.Add(labelCorreo, 1, 3);
            tableStudentInfo.Controls.Add(label9, 0, 3);
            tableStudentInfo.Controls.Add(labelTelefono, 1, 2);
            tableStudentInfo.Controls.Add(label7, 0, 2);
            tableStudentInfo.Controls.Add(labelApellido, 1, 1);
            tableStudentInfo.Controls.Add(label5, 0, 1);
            tableStudentInfo.Controls.Add(labelNombre, 1, 0);
            tableStudentInfo.Controls.Add(label3, 0, 0);
            tableStudentInfo.Location = new Point(76, 93);
            tableStudentInfo.Name = "tableStudentInfo";
            tableStudentInfo.RowCount = 6;
            tableStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableStudentInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableStudentInfo.Size = new Size(507, 160);
            tableStudentInfo.TabIndex = 16;
            // 
            // labelEdad
            // 
            labelEdad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelEdad.AutoSize = true;
            labelEdad.Font = new Font("Segoe UI", 12F);
            labelEdad.Location = new Point(90, 130);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(414, 30);
            labelEdad.TabIndex = 11;
            labelEdad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.ForeColor = Color.FromArgb(17, 24, 39);
            label13.Location = new Point(3, 130);
            label13.Name = "label13";
            label13.Size = new Size(81, 30);
            label13.TabIndex = 10;
            label13.Text = "Edad:";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCurso
            // 
            labelCurso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCurso.AutoSize = true;
            labelCurso.Font = new Font("Segoe UI", 12F);
            labelCurso.Location = new Point(90, 104);
            labelCurso.Name = "labelCurso";
            labelCurso.Size = new Size(414, 26);
            labelCurso.TabIndex = 9;
            labelCurso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.FromArgb(17, 24, 39);
            label11.Location = new Point(3, 104);
            label11.Name = "label11";
            label11.Size = new Size(81, 26);
            label11.TabIndex = 8;
            label11.Text = "Curso:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelCorreo
            // 
            labelCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Segoe UI", 12F);
            labelCorreo.Location = new Point(90, 78);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(414, 26);
            labelCorreo.TabIndex = 7;
            labelCorreo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = Color.FromArgb(17, 24, 39);
            label9.Location = new Point(3, 78);
            label9.Name = "label9";
            label9.Size = new Size(81, 26);
            label9.TabIndex = 6;
            label9.Text = "Correo:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTelefono
            // 
            labelTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI", 12F);
            labelTelefono.Location = new Point(90, 52);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(414, 26);
            labelTelefono.TabIndex = 5;
            labelTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.FromArgb(17, 24, 39);
            label7.Location = new Point(3, 52);
            label7.Name = "label7";
            label7.Size = new Size(81, 26);
            label7.TabIndex = 4;
            label7.Text = "Telefono:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelApellido
            // 
            labelApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 12F);
            labelApellido.Location = new Point(90, 26);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(414, 26);
            labelApellido.TabIndex = 3;
            labelApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(17, 24, 39);
            label5.Location = new Point(3, 26);
            label5.Name = "label5";
            label5.Size = new Size(81, 26);
            label5.TabIndex = 2;
            label5.Text = "Apellido:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelNombre
            // 
            labelNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F);
            labelNombre.Location = new Point(90, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(414, 26);
            labelNombre.TabIndex = 1;
            labelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(17, 24, 39);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 26);
            label3.TabIndex = 0;
            label3.Text = "Nombre: ";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999962F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999962F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnEditar, 3, 0);
            tableLayoutPanel3.Controls.Add(buttonAsignaturas, 2, 0);
            tableLayoutPanel3.Location = new Point(80, 348);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(693, 75);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEditar.BackColor = Color.FromArgb(37, 99, 235);
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(522, 16);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(168, 42);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // buttonAsignaturas
            // 
            buttonAsignaturas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonAsignaturas.BackColor = Color.FromArgb(37, 99, 235);
            buttonAsignaturas.Font = new Font("Segoe UI", 12F);
            buttonAsignaturas.ForeColor = Color.White;
            buttonAsignaturas.Location = new Point(349, 16);
            buttonAsignaturas.Name = "buttonAsignaturas";
            buttonAsignaturas.Size = new Size(167, 42);
            buttonAsignaturas.TabIndex = 1;
            buttonAsignaturas.Text = "Asignaturas";
            buttonAsignaturas.UseVisualStyleBackColor = false;
            buttonAsignaturas.Click += buttonAsignaturas_Click;
            // 
            // StudentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "StudentView";
            Text = "StudentView";
            Load += StudentView_Load;
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
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox inputRut;
        private Button button2;
        private TableLayoutPanel tableStudentInfo;
        private Label labelEdad;
        private Label label13;
        private Label labelCurso;
        private Label label11;
        private Label labelCorreo;
        private Label label9;
        private Label labelTelefono;
        private Label label7;
        private Label labelApellido;
        private Label label5;
        private Label labelNombre;
        private Label label3;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnEditar;
        private Button buttonAsignaturas;
    }
}