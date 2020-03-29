namespace Formularios
{
    partial class CrudEstudiantes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.ConsultarEstudiante = new System.Windows.Forms.Button();
            this.modificarEstudiante = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.volver = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFechaNacEstudiante = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOcupacionAcudiente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableEstudiantes = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acudiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OcupacionAcudiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtNombreAcudiente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEstudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 547);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 547);
            this.panel6.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnAgregarEstudiante);
            this.panel2.Controls.Add(this.ConsultarEstudiante);
            this.panel2.Controls.Add(this.modificarEstudiante);
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 471);
            this.panel2.TabIndex = 8;
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.BackColor = System.Drawing.Color.White;
            this.btnAgregarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(34, 106);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(217, 42);
            this.btnAgregarEstudiante.TabIndex = 0;
            this.btnAgregarEstudiante.Text = "Agregar";
            this.btnAgregarEstudiante.UseVisualStyleBackColor = false;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // ConsultarEstudiante
            // 
            this.ConsultarEstudiante.BackColor = System.Drawing.Color.White;
            this.ConsultarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ConsultarEstudiante.Location = new System.Drawing.Point(34, 206);
            this.ConsultarEstudiante.Name = "ConsultarEstudiante";
            this.ConsultarEstudiante.Size = new System.Drawing.Size(217, 42);
            this.ConsultarEstudiante.TabIndex = 2;
            this.ConsultarEstudiante.Text = "Consultar";
            this.ConsultarEstudiante.UseVisualStyleBackColor = false;
            this.ConsultarEstudiante.Click += new System.EventHandler(this.ConsultarEstudiante_Click);
            // 
            // modificarEstudiante
            // 
            this.modificarEstudiante.BackColor = System.Drawing.Color.White;
            this.modificarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.modificarEstudiante.Location = new System.Drawing.Point(34, 304);
            this.modificarEstudiante.Name = "modificarEstudiante";
            this.modificarEstudiante.Size = new System.Drawing.Size(217, 42);
            this.modificarEstudiante.TabIndex = 1;
            this.modificarEstudiante.Text = "Modificar";
            this.modificarEstudiante.UseVisualStyleBackColor = false;
            this.modificarEstudiante.Click += new System.EventHandler(this.modificarEstudiante_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.volver);
            this.panel5.Location = new System.Drawing.Point(5, 472);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(291, 72);
            this.panel5.TabIndex = 7;
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.ForeColor = System.Drawing.Color.White;
            this.volver.Location = new System.Drawing.Point(102, 25);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(88, 34);
            this.volver.TabIndex = 4;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtFechaNacEstudiante);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtOcupacionAcudiente);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtObservacion);
            this.panel3.Controls.Add(this.txtMail);
            this.panel3.Controls.Add(this.txtTelefono);
            this.panel3.Controls.Add(this.txtDireccion);
            this.panel3.Controls.Add(this.txtApellidos);
            this.panel3.Controls.Add(this.txtNombres);
            this.panel3.Controls.Add(this.txtNombreAcudiente);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(297, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(950, 543);
            this.panel3.TabIndex = 1;
            // 
            // txtFechaNacEstudiante
            // 
            this.txtFechaNacEstudiante.Location = new System.Drawing.Point(191, 164);
            this.txtFechaNacEstudiante.Name = "txtFechaNacEstudiante";
            this.txtFechaNacEstudiante.Size = new System.Drawing.Size(224, 20);
            this.txtFechaNacEstudiante.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha Nacimiento";
            // 
            // txtOcupacionAcudiente
            // 
            this.txtOcupacionAcudiente.Location = new System.Drawing.Point(191, 121);
            this.txtOcupacionAcudiente.Name = "txtOcupacionAcudiente";
            this.txtOcupacionAcudiente.Size = new System.Drawing.Size(285, 20);
            this.txtOcupacionAcudiente.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(43, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Ocupación Acudiente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(229, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Datos del estudiante";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(388, 217);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 34);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableEstudiantes);
            this.panel4.Location = new System.Drawing.Point(21, 266);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(907, 262);
            this.panel4.TabIndex = 22;
            // 
            // tableEstudiantes
            // 
            this.tableEstudiantes.AllowUserToAddRows = false;
            this.tableEstudiantes.AllowUserToDeleteRows = false;
            this.tableEstudiantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tableEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_nombres,
            this.col_apellidos,
            this.FechaNacimiento,
            this.acudiente,
            this.col_direccion,
            this.col_telefono,
            this.col_mail,
            this.col_observacion,
            this.OcupacionAcudiente});
            this.tableEstudiantes.Location = new System.Drawing.Point(3, 3);
            this.tableEstudiantes.Name = "tableEstudiantes";
            this.tableEstudiantes.ReadOnly = true;
            this.tableEstudiantes.Size = new System.Drawing.Size(901, 255);
            this.tableEstudiantes.TabIndex = 0;
            this.tableEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableEstudiantes_CellContentClick);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "Id";
            this.col_id.Name = "col_id";
            this.col_id.ReadOnly = true;
            this.col_id.Visible = false;
            // 
            // col_nombres
            // 
            this.col_nombres.HeaderText = "Nombres";
            this.col_nombres.Name = "col_nombres";
            this.col_nombres.ReadOnly = true;
            this.col_nombres.Width = 150;
            // 
            // col_apellidos
            // 
            this.col_apellidos.HeaderText = "Apellidos";
            this.col_apellidos.Name = "col_apellidos";
            this.col_apellidos.ReadOnly = true;
            this.col_apellidos.Width = 150;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // acudiente
            // 
            this.acudiente.HeaderText = "Acudiente";
            this.acudiente.Name = "acudiente";
            this.acudiente.ReadOnly = true;
            // 
            // col_direccion
            // 
            this.col_direccion.HeaderText = "Dirección";
            this.col_direccion.Name = "col_direccion";
            this.col_direccion.ReadOnly = true;
            this.col_direccion.Width = 150;
            // 
            // col_telefono
            // 
            this.col_telefono.HeaderText = "Telefóno";
            this.col_telefono.Name = "col_telefono";
            this.col_telefono.ReadOnly = true;
            // 
            // col_mail
            // 
            this.col_mail.HeaderText = "Email";
            this.col_mail.Name = "col_mail";
            this.col_mail.ReadOnly = true;
            this.col_mail.Width = 150;
            // 
            // col_observacion
            // 
            this.col_observacion.HeaderText = "Observaciones";
            this.col_observacion.Name = "col_observacion";
            this.col_observacion.ReadOnly = true;
            this.col_observacion.Width = 150;
            // 
            // OcupacionAcudiente
            // 
            this.OcupacionAcudiente.HeaderText = "Ocupacion Acudiente";
            this.OcupacionAcudiente.Name = "OcupacionAcudiente";
            this.OcupacionAcudiente.ReadOnly = true;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(610, 216);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(315, 20);
            this.txtObservacion.TabIndex = 19;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(610, 188);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(315, 20);
            this.txtMail.TabIndex = 18;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(610, 161);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(315, 20);
            this.txtTelefono.TabIndex = 17;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(610, 135);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(315, 20);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(610, 109);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(315, 20);
            this.txtApellidos.TabIndex = 15;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(610, 83);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(315, 20);
            this.txtNombres.TabIndex = 14;
            // 
            // txtNombreAcudiente
            // 
            this.txtNombreAcudiente.Location = new System.Drawing.Point(191, 84);
            this.txtNombreAcudiente.Name = "txtNombreAcudiente";
            this.txtNombreAcudiente.Size = new System.Drawing.Size(285, 20);
            this.txtNombreAcudiente.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Observación";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Acudiente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(515, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(515, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(514, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombres";
            // 
            // CrudEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 553);
            this.Controls.Add(this.panel1);
            this.Name = "CrudEstudiantes";
            this.Text = "CrudEstudiantes";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableEstudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOcupacionAcudiente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tableEstudiantes;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtNombreAcudiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.Button ConsultarEstudiante;
        private System.Windows.Forms.Button modificarEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn acudiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcupacionAcudiente;
        private System.Windows.Forms.DateTimePicker txtFechaNacEstudiante;
    }
}