namespace Primaton_G6
{
    partial class ControlDeGastos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDeGastos));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtRubro = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.chk_prioritario = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tablaGastos = new System.Windows.Forms.DataGridView();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblGastado = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblImportante = new System.Windows.Forms.Label();
            this.lblRedundante = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGastos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(1025, 146);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(152, 49);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(782, 146);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 49);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(735, 84);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 34);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(981, 626);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(154, 59);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver atrás";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtRubro
            // 
            this.txtRubro.BackColor = System.Drawing.Color.Moccasin;
            this.txtRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRubro.FormattingEnabled = true;
            this.txtRubro.Items.AddRange(new object[] {
            "Salud",
            "Servicios",
            "Impuestos",
            "Alquiler",
            "Hipoteca",
            "Educacion",
            "Supermercado",
            "Mantenimiento casa",
            "Mantenimiento auto",
            "Transporte",
            "Viajes",
            "Salidas/Esparcimiento",
            "Tarjeta de crédito",
            "Otro"});
            this.txtRubro.Location = new System.Drawing.Point(45, 83);
            this.txtRubro.Margin = new System.Windows.Forms.Padding(4);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(244, 37);
            this.txtRubro.TabIndex = 0;
            // 
            // txtFecha
            // 
            this.txtFecha.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(462, 84);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(238, 34);
            this.txtFecha.TabIndex = 2;
            // 
            // chk_prioritario
            // 
            this.chk_prioritario.AutoSize = true;
            this.chk_prioritario.BackColor = System.Drawing.Color.Transparent;
            this.chk_prioritario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_prioritario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_prioritario.Location = new System.Drawing.Point(316, 88);
            this.chk_prioritario.Name = "chk_prioritario";
            this.chk_prioritario.Size = new System.Drawing.Size(140, 33);
            this.chk_prioritario.TabIndex = 1;
            this.chk_prioritario.Text = "Prioritario";
            this.chk_prioritario.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rubro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(731, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(1059, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Importe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(457, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha:";
            // 
            // tablaGastos
            // 
            this.tablaGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaGastos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaGastos.BackgroundColor = System.Drawing.Color.Moccasin;
            this.tablaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaGastos.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaGastos.Location = new System.Drawing.Point(140, 224);
            this.tablaGastos.Name = "tablaGastos";
            this.tablaGastos.ReadOnly = true;
            this.tablaGastos.RowHeadersWidth = 51;
            this.tablaGastos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tablaGastos.RowTemplate.Height = 24;
            this.tablaGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaGastos.Size = new System.Drawing.Size(973, 355);
            this.tablaGastos.TabIndex = 16;
            this.tablaGastos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.TablaGastos_CellFormatting);
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.SystemColors.Window;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(1064, 84);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(132, 34);
            this.txtImporte.TabIndex = 4;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtImporte_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(241, 170);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 17);
            this.lblNombre.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(157, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ingresos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(157, 642);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lo que llevas gastado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(157, 676);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Disponible para gastar:";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngresos.Location = new System.Drawing.Point(268, 605);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(0, 25);
            this.lblIngresos.TabIndex = 21;
            // 
            // lblGastado
            // 
            this.lblGastado.AutoSize = true;
            this.lblGastado.BackColor = System.Drawing.Color.Transparent;
            this.lblGastado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGastado.Location = new System.Drawing.Point(389, 642);
            this.lblGastado.Name = "lblGastado";
            this.lblGastado.Size = new System.Drawing.Size(0, 25);
            this.lblGastado.TabIndex = 22;
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.BackColor = System.Drawing.Color.Transparent;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisponible.Location = new System.Drawing.Point(389, 676);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(0, 25);
            this.lblDisponible.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(604, 605);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "% Importantes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(604, 650);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "% Redundantes:";
            // 
            // lblImportante
            // 
            this.lblImportante.AutoSize = true;
            this.lblImportante.BackColor = System.Drawing.Color.Transparent;
            this.lblImportante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImportante.Location = new System.Drawing.Point(761, 605);
            this.lblImportante.Name = "lblImportante";
            this.lblImportante.Size = new System.Drawing.Size(0, 25);
            this.lblImportante.TabIndex = 26;
            // 
            // lblRedundante
            // 
            this.lblRedundante.AutoSize = true;
            this.lblRedundante.BackColor = System.Drawing.Color.Transparent;
            this.lblRedundante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedundante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRedundante.Location = new System.Drawing.Point(777, 650);
            this.lblRedundante.Name = "lblRedundante";
            this.lblRedundante.Size = new System.Drawing.Size(0, 25);
            this.lblRedundante.TabIndex = 27;
            // 
            // ControlDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 758);
            this.Controls.Add(this.lblRedundante);
            this.Controls.Add(this.lblImportante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.lblGastado);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.tablaGastos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_prioritario);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtRubro);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ControlDeGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor gastos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox txtRubro;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.CheckBox chk_prioritario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tablaGastos;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblGastado;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblImportante;
        private System.Windows.Forms.Label lblRedundante;
    }
}