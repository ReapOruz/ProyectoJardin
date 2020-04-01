namespace Formularios
{
    partial class GruposEstudiantes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarAgrupo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbListaGrupos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableGrupos = new System.Windows.Forms.DataGridView();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 488);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.btnAgregarAgrupo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbListaGrupos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 485);
            this.panel2.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(46, 430);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 36);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarAgrupo
            // 
            this.btnAgregarAgrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarAgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAgrupo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarAgrupo.Location = new System.Drawing.Point(679, 82);
            this.btnAgregarAgrupo.Name = "btnAgregarAgrupo";
            this.btnAgregarAgrupo.Size = new System.Drawing.Size(185, 48);
            this.btnAgregarAgrupo.TabIndex = 4;
            this.btnAgregarAgrupo.Text = "Agregar a grupo";
            this.btnAgregarAgrupo.UseVisualStyleBackColor = false;
            this.btnAgregarAgrupo.Click += new System.EventHandler(this.btnAgregarAgrupo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grupos";
            // 
            // cbListaGrupos
            // 
            this.cbListaGrupos.FormattingEnabled = true;
            this.cbListaGrupos.Location = new System.Drawing.Point(216, 98);
            this.cbListaGrupos.Name = "cbListaGrupos";
            this.cbListaGrupos.Size = new System.Drawing.Size(341, 21);
            this.cbListaGrupos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asignación a grupos";
            this.label1.UseMnemonic = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableGrupos);
            this.panel3.Location = new System.Drawing.Point(216, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 327);
            this.panel3.TabIndex = 0;
            // 
            // tableGrupos
            // 
            this.tableGrupos.AllowUserToAddRows = false;
            this.tableGrupos.AllowUserToDeleteRows = false;
            this.tableGrupos.AllowUserToResizeColumns = false;
            this.tableGrupos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tableGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_alumno,
            this.doc,
            this.Nombres,
            this.Apellidos,
            this.Grupo_Actual});
            this.tableGrupos.Location = new System.Drawing.Point(3, 3);
            this.tableGrupos.Name = "tableGrupos";
            this.tableGrupos.ReadOnly = true;
            this.tableGrupos.Size = new System.Drawing.Size(644, 321);
            this.tableGrupos.TabIndex = 0;
            // 
            // id_alumno
            // 
            this.id_alumno.HeaderText = "Id";
            this.id_alumno.Name = "id_alumno";
            this.id_alumno.ReadOnly = true;
            this.id_alumno.Visible = false;
            // 
            // doc
            // 
            this.doc.HeaderText = "Documento";
            this.doc.Name = "doc";
            this.doc.ReadOnly = true;
            this.doc.Width = 150;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 150;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 150;
            // 
            // Grupo_Actual
            // 
            this.Grupo_Actual.HeaderText = "Grupo Actual";
            this.Grupo_Actual.Name = "Grupo_Actual";
            this.Grupo_Actual.ReadOnly = true;
            this.Grupo_Actual.Width = 150;
            // 
            // GruposEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 489);
            this.Controls.Add(this.panel1);
            this.Name = "GruposEstudiantes";
            this.Text = "GruposEstudiantes";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableGrupos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView tableGrupos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarAgrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbListaGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo_Actual;
    }
}