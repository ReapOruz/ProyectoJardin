namespace Formularios
{
    partial class ReportePeriodo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGrupos = new System.Windows.Forms.ComboBox();
            this.gruposBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtSetGrupos = new Formularios.DtSetGrupos();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAlumnos = new System.Windows.Forms.ComboBox();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.periodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTSetTodosPeriodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTSetTodosPeriodos = new Formularios.DTSetTodosPeriodos();
            this.tableNotas = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtSetListarGrupos = new Formularios.DtSetListarGrupos();
            this.jardinDataSet1 = new Formularios.JardinDataSet1();
            this.jardinDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gruposTableAdapter = new Formularios.DtSetListarGruposTableAdapters.gruposTableAdapter();
            this.periodoTableAdapter = new Formularios.DTSetTodosPeriodosTableAdapters.periodoTableAdapter();
            this.gruposTableAdapter1 = new Formularios.DtSetGruposTableAdapters.gruposTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSetGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSetTodosPeriodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSetTodosPeriodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSetListarGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jardinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jardinDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 551);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.tableNotas);
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 547);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGrupos);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbAlumnos);
            this.groupBox2.Controls.Add(this.cbPeriodo);
            this.groupBox2.Location = new System.Drawing.Point(121, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 136);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // cbGrupos
            // 
            this.cbGrupos.DataSource = this.gruposBindingSource1;
            this.cbGrupos.DisplayMember = "nombre_grupo";
            this.cbGrupos.FormattingEnabled = true;
            this.cbGrupos.Location = new System.Drawing.Point(93, 29);
            this.cbGrupos.Name = "cbGrupos";
            this.cbGrupos.Size = new System.Drawing.Size(196, 21);
            this.cbGrupos.TabIndex = 19;
            this.cbGrupos.ValueMember = "id_grupo";
            this.cbGrupos.SelectedIndexChanged += new System.EventHandler(this.cbGrupos_SelectedIndexChanged);
            // 
            // gruposBindingSource1
            // 
            this.gruposBindingSource1.DataMember = "grupos";
            this.gruposBindingSource1.DataSource = this.dtSetGrupos;
            // 
            // dtSetGrupos
            // 
            this.dtSetGrupos.DataSetName = "DtSetGrupos";
            this.dtSetGrupos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(271, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alumno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Periodo";
            // 
            // cbAlumnos
            // 
            this.cbAlumnos.FormattingEnabled = true;
            this.cbAlumnos.Location = new System.Drawing.Point(93, 67);
            this.cbAlumnos.Name = "cbAlumnos";
            this.cbAlumnos.Size = new System.Drawing.Size(263, 21);
            this.cbAlumnos.TabIndex = 7;
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DataSource = this.periodoBindingSource;
            this.cbPeriodo.DisplayMember = "descripcion_periodo";
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Location = new System.Drawing.Point(93, 103);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(140, 21);
            this.cbPeriodo.TabIndex = 10;
            this.cbPeriodo.ValueMember = "id_periodo";
            // 
            // periodoBindingSource
            // 
            this.periodoBindingSource.DataMember = "periodo";
            this.periodoBindingSource.DataSource = this.dTSetTodosPeriodosBindingSource;
            // 
            // dTSetTodosPeriodosBindingSource
            // 
            this.dTSetTodosPeriodosBindingSource.DataSource = this.dTSetTodosPeriodos;
            this.dTSetTodosPeriodosBindingSource.Position = 0;
            // 
            // dTSetTodosPeriodos
            // 
            this.dTSetTodosPeriodos.DataSetName = "DTSetTodosPeriodos";
            this.dTSetTodosPeriodos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableNotas
            // 
            this.tableNotas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column3});
            this.tableNotas.Location = new System.Drawing.Point(121, 238);
            this.tableNotas.Name = "tableNotas";
            this.tableNotas.Size = new System.Drawing.Size(444, 290);
            this.tableNotas.TabIndex = 16;
            // 
            // Column4
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Id Materia";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Materia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Valoración";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(539, 17);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(81, 30);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de periodos";
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "grupos";
            this.gruposBindingSource.DataSource = this.dtSetListarGrupos;
            // 
            // dtSetListarGrupos
            // 
            this.dtSetListarGrupos.DataSetName = "DtSetListarGrupos";
            this.dtSetListarGrupos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jardinDataSet1
            // 
            this.jardinDataSet1.DataSetName = "JardinDataSet1";
            this.jardinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jardinDataSet1BindingSource
            // 
            this.jardinDataSet1BindingSource.DataSource = this.jardinDataSet1;
            this.jardinDataSet1BindingSource.Position = 0;
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // periodoTableAdapter
            // 
            this.periodoTableAdapter.ClearBeforeFill = true;
            // 
            // gruposTableAdapter1
            // 
            this.gruposTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportePeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 555);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportePeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePeriodo";
            this.Load += new System.EventHandler(this.ReportePeriodo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSetGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSetTodosPeriodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSetTodosPeriodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSetListarGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jardinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jardinDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tableNotas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private DTSetTodosPeriodos dTSetTodosPeriodos;
        private System.Windows.Forms.BindingSource dTSetTodosPeriodosBindingSource;
        private JardinDataSet1 jardinDataSet1;
        private System.Windows.Forms.BindingSource jardinDataSet1BindingSource;
        private DtSetListarGrupos dtSetListarGrupos;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private DtSetListarGruposTableAdapters.gruposTableAdapter gruposTableAdapter;
        private System.Windows.Forms.BindingSource periodoBindingSource;
        private DTSetTodosPeriodosTableAdapters.periodoTableAdapter periodoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DtSetGrupos dtSetGrupos;
        private System.Windows.Forms.BindingSource gruposBindingSource1;
        private DtSetGruposTableAdapters.gruposTableAdapter gruposTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbGrupos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAlumnos;
        private System.Windows.Forms.ComboBox cbPeriodo;
    }
}