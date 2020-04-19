namespace Formularios
{
    partial class FormularioPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPagos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocumentoBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombresCompletos = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tablePagosAprobados = new System.Windows.Forms.DataGridView();
            this.ConceptoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCancelado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoPendiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbConceptoPago = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFiltroAnio = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.PictureBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnioCancelar = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePagosAprobados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiltrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por documento";
            // 
            // txtDocumentoBusqueda
            // 
            this.txtDocumentoBusqueda.Location = new System.Drawing.Point(39, 107);
            this.txtDocumentoBusqueda.Name = "txtDocumentoBusqueda";
            this.txtDocumentoBusqueda.Size = new System.Drawing.Size(229, 20);
            this.txtDocumentoBusqueda.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(297, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 32);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datos Basicos Estudiante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(606, 81);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(229, 20);
            this.txtDocumento.TabIndex = 6;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(527, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre completo";
            // 
            // txtNombresCompletos
            // 
            this.txtNombresCompletos.Location = new System.Drawing.Point(530, 151);
            this.txtNombresCompletos.Name = "txtNombresCompletos";
            this.txtNombresCompletos.Size = new System.Drawing.Size(305, 20);
            this.txtNombresCompletos.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 615);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtAnioCancelar);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnLimpiarFiltros);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.txtFiltroAnio);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tablePagosAprobados);
            this.panel2.Controls.Add(this.cbMes);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.btnPagar);
            this.panel2.Controls.Add(this.txtValorPagar);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.cbConceptoPago);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNombresCompletos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDocumentoBusqueda);
            this.panel2.Controls.Add(this.txtDocumento);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 611);
            this.panel2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(967, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 15);
            this.label8.TabIndex = 33;
            this.label8.Text = "Filtrar pago por año";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Año a cancelar";
            // 
            // tablePagosAprobados
            // 
            this.tablePagosAprobados.AllowUserToAddRows = false;
            this.tablePagosAprobados.AllowUserToDeleteRows = false;
            this.tablePagosAprobados.AllowUserToOrderColumns = true;
            this.tablePagosAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePagosAprobados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConceptoPago,
            this.anio,
            this.mes,
            this.ValorCancelado,
            this.saldoPendiente,
            this.estadoPago});
            this.tablePagosAprobados.Location = new System.Drawing.Point(39, 195);
            this.tablePagosAprobados.Name = "tablePagosAprobados";
            this.tablePagosAprobados.ReadOnly = true;
            this.tablePagosAprobados.Size = new System.Drawing.Size(894, 192);
            this.tablePagosAprobados.TabIndex = 28;
            // 
            // ConceptoPago
            // 
            this.ConceptoPago.HeaderText = "Concepto Pago";
            this.ConceptoPago.Name = "ConceptoPago";
            this.ConceptoPago.ReadOnly = true;
            this.ConceptoPago.Width = 150;
            // 
            // anio
            // 
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Width = 150;
            // 
            // mes
            // 
            this.mes.HeaderText = "Mes";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            this.mes.Width = 150;
            // 
            // ValorCancelado
            // 
            this.ValorCancelado.HeaderText = "Valor Cancelado";
            this.ValorCancelado.Name = "ValorCancelado";
            this.ValorCancelado.ReadOnly = true;
            this.ValorCancelado.Width = 150;
            // 
            // saldoPendiente
            // 
            this.saldoPendiente.HeaderText = "Saldo Pendiente";
            this.saldoPendiente.Name = "saldoPendiente";
            this.saldoPendiente.ReadOnly = true;
            // 
            // estadoPago
            // 
            this.estadoPago.HeaderText = "Estado";
            this.estadoPago.Name = "estadoPago";
            this.estadoPago.ReadOnly = true;
            this.estadoPago.Width = 150;
            // 
            // cbMes
            // 
            this.cbMes.Enabled = false;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE"});
            this.cbMes.Location = new System.Drawing.Point(633, 526);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(212, 21);
            this.cbMes.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 529);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Mes a cancelar";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(1018, 23);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 32);
            this.btnVolver.TabIndex = 25;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.Location = new System.Drawing.Point(896, 519);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(107, 32);
            this.btnPagar.TabIndex = 24;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(633, 476);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(229, 20);
            this.txtValorPagar.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(539, 479);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Valor a pagar    $";
            // 
            // cbConceptoPago
            // 
            this.cbConceptoPago.FormattingEnabled = true;
            this.cbConceptoPago.Location = new System.Drawing.Point(181, 476);
            this.cbConceptoPago.Name = "cbConceptoPago";
            this.cbConceptoPago.Size = new System.Drawing.Size(212, 21);
            this.cbConceptoPago.TabIndex = 21;
            this.cbConceptoPago.SelectedIndexChanged += new System.EventHandler(this.cbConceptoPago_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 479);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Concepto pago";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(76, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Realizar pago";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(77, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(967, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________________________";
            // 
            // txtFiltroAnio
            // 
            this.txtFiltroAnio.Location = new System.Drawing.Point(970, 231);
            this.txtFiltroAnio.Name = "txtFiltroAnio";
            this.txtFiltroAnio.Size = new System.Drawing.Size(95, 20);
            this.txtFiltroAnio.TabIndex = 34;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(1071, 216);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(37, 35);
            this.btnFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnFiltrar.TabIndex = 35;
            this.btnFiltrar.TabStop = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(970, 355);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(107, 32);
            this.btnLimpiarFiltros.TabIndex = 36;
            this.btnLimpiarFiltros.Text = "Quitar Filtros";
            this.btnLimpiarFiltros.UseCompatibleTextRendering = true;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(36, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Pagos realizados";
            // 
            // txtAnioCancelar
            // 
            this.txtAnioCancelar.FormattingEnabled = true;
            this.txtAnioCancelar.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.txtAnioCancelar.Location = new System.Drawing.Point(181, 526);
            this.txtAnioCancelar.Name = "txtAnioCancelar";
            this.txtAnioCancelar.Size = new System.Drawing.Size(212, 21);
            this.txtAnioCancelar.TabIndex = 38;
            // 
            // FormularioPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 615);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioPagos";
            this.Text = "FormularioPagos";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePagosAprobados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFiltrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocumentoBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombresCompletos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbConceptoPago;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tablePagosAprobados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConceptoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCancelado;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoPendiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFiltroAnio;
        private System.Windows.Forms.PictureBox btnFiltrar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtAnioCancelar;
    }
}