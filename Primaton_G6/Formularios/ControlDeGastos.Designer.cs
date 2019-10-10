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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlDeGastos));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtRubro = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.chk_prioritario = new System.Windows.Forms.CheckBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tablaGastos = new System.Windows.Forms.DataGridView();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblGastado = new System.Windows.Forms.Label();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblImportante = new System.Windows.Forms.Label();
            this.lblRedundante = new System.Windows.Forms.Label();
            this.GrupoIngresos = new System.Windows.Forms.GroupBox();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaGastos)).BeginInit();
            this.GrupoIngresos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.BackgroundImage = global::Primaton_G6.Properties.Resources.botonMadera;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(967, 102);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(163, 49);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            this.btnBorrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBorrar_MouseDown);
            this.btnBorrar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnBorrar_MouseUp);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BackgroundImage = global::Primaton_G6.Properties.Resources.botonMadera;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(763, 102);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(163, 49);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            this.btnAgregar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAgregar_MouseDown);
            this.btnAgregar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAgregar_MouseUp);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(659, 57);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 34);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = global::Primaton_G6.Properties.Resources.botonMadera;
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(973, 546);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(163, 49);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver atrás";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.btnVolver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVolver_MouseDown);
            this.btnVolver.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnVolver_MouseUp);
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
            this.txtRubro.Location = new System.Drawing.Point(45, 57);
            this.txtRubro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(244, 37);
            this.txtRubro.TabIndex = 0;
            // 
            // txtFecha
            // 
            this.txtFecha.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(349, 58);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(239, 34);
            this.txtFecha.TabIndex = 2;
            // 
            // chk_prioritario
            // 
            this.chk_prioritario.AutoSize = true;
            this.chk_prioritario.BackColor = System.Drawing.Color.Transparent;
            this.chk_prioritario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_prioritario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chk_prioritario.Location = new System.Drawing.Point(45, 110);
            this.chk_prioritario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_prioritario.Name = "chk_prioritario";
            this.chk_prioritario.Size = new System.Drawing.Size(140, 33);
            this.chk_prioritario.TabIndex = 1;
            this.chk_prioritario.Text = "Prioritario";
            this.chk_prioritario.UseVisualStyleBackColor = false;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.BackColor = System.Drawing.Color.Transparent;
            this.lblRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRubro.Location = new System.Drawing.Point(39, 23);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(85, 29);
            this.lblRubro.TabIndex = 11;
            this.lblRubro.Text = "Rubro:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescripcion.Location = new System.Drawing.Point(653, 23);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(147, 29);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.BackColor = System.Drawing.Color.Transparent;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImporte.Location = new System.Drawing.Point(993, 23);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(109, 29);
            this.lblImporte.TabIndex = 13;
            this.lblImporte.Text = "Importe:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFecha.Location = new System.Drawing.Point(349, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 29);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            // 
            // tablaGastos
            // 
            this.tablaGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaGastos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaGastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaGastos.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaGastos.Location = new System.Drawing.Point(23, 170);
            this.tablaGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaGastos.Name = "tablaGastos";
            this.tablaGastos.ReadOnly = true;
            this.tablaGastos.RowHeadersWidth = 51;
            this.tablaGastos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.tablaGastos.RowTemplate.Height = 24;
            this.tablaGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaGastos.Size = new System.Drawing.Size(1133, 354);
            this.tablaGastos.TabIndex = 16;
            this.tablaGastos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.TablaGastos_CellFormatting);
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.SystemColors.Window;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.Location = new System.Drawing.Point(997, 57);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Lo que llevas gastado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Disponible para gastar:";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblIngresos.Location = new System.Drawing.Point(268, 606);
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
            this.lblGastado.Location = new System.Drawing.Point(260, 27);
            this.lblGastado.Name = "lblGastado";
            this.lblGastado.Size = new System.Drawing.Size(84, 25);
            this.lblGastado.TabIndex = 22;
            this.lblGastado.Text = "000000";
            // 
            // lblDisponible
            // 
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.BackColor = System.Drawing.Color.Transparent;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.ForeColor = System.Drawing.Color.White;
            this.lblDisponible.Location = new System.Drawing.Point(260, 71);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(96, 25);
            this.lblDisponible.TabIndex = 23;
            this.lblDisponible.Text = "0000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(92, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "% Importantes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(77, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "% Redundantes:";
            // 
            // lblImportante
            // 
            this.lblImportante.AutoSize = true;
            this.lblImportante.BackColor = System.Drawing.Color.Transparent;
            this.lblImportante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblImportante.Location = new System.Drawing.Point(260, 156);
            this.lblImportante.Name = "lblImportante";
            this.lblImportante.Size = new System.Drawing.Size(84, 25);
            this.lblImportante.TabIndex = 26;
            this.lblImportante.Text = "000000";
            // 
            // lblRedundante
            // 
            this.lblRedundante.AutoSize = true;
            this.lblRedundante.BackColor = System.Drawing.Color.Transparent;
            this.lblRedundante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedundante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRedundante.Location = new System.Drawing.Point(260, 117);
            this.lblRedundante.Name = "lblRedundante";
            this.lblRedundante.Size = new System.Drawing.Size(84, 25);
            this.lblRedundante.TabIndex = 27;
            this.lblRedundante.Text = "000000";
            // 
            // GrupoIngresos
            // 
            this.GrupoIngresos.BackColor = System.Drawing.Color.Transparent;
            this.GrupoIngresos.Controls.Add(this.label9);
            this.GrupoIngresos.Controls.Add(this.lblRedundante);
            this.GrupoIngresos.Controls.Add(this.label8);
            this.GrupoIngresos.Controls.Add(this.lblImportante);
            this.GrupoIngresos.Controls.Add(this.label7);
            this.GrupoIngresos.Controls.Add(this.lblDisponible);
            this.GrupoIngresos.Controls.Add(this.label6);
            this.GrupoIngresos.Controls.Add(this.lblGastado);
            this.GrupoIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoIngresos.ForeColor = System.Drawing.Color.White;
            this.GrupoIngresos.Location = new System.Drawing.Point(24, 544);
            this.GrupoIngresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrupoIngresos.Name = "GrupoIngresos";
            this.GrupoIngresos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrupoIngresos.Size = new System.Drawing.Size(697, 188);
            this.GrupoIngresos.TabIndex = 28;
            this.GrupoIngresos.TabStop = false;
            this.GrupoIngresos.Text = "Ingresos";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(219, 113);
            this.lblAviso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(490, 25);
            this.lblAviso.TabIndex = 29;
            this.lblAviso.Text = "No se pueden cargar datos si hay campos vacios.";
            this.lblAviso.Visible = false;
            // 
            // ControlDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 745);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.GrupoIngresos);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.tablaGastos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblRubro);
            this.Controls.Add(this.chk_prioritario);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtRubro);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlDeGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor gastos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaGastos)).EndInit();
            this.GrupoIngresos.ResumeLayout(false);
            this.GrupoIngresos.PerformLayout();
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
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridView tablaGastos;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblGastado;
        private System.Windows.Forms.Label lblDisponible;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblImportante;
        private System.Windows.Forms.Label lblRedundante;
        private System.Windows.Forms.GroupBox GrupoIngresos;
        private System.Windows.Forms.Label lblAviso;
    }
}