namespace Primaton_G6.Formularios
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNoEstas = new System.Windows.Forms.Label();
            this.btnAddgasto = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.btnCompras = new System.Windows.Forms.Button();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblAvisoUsuario = new System.Windows.Forms.Label();
            this.lblPassInco = new System.Windows.Forms.Label();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblNoEstas
            // 
            resources.ApplyResources(this.lblNoEstas, "lblNoEstas");
            this.lblNoEstas.BackColor = System.Drawing.Color.Transparent;
            this.lblNoEstas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNoEstas.ForeColor = System.Drawing.Color.White;
            this.lblNoEstas.Name = "lblNoEstas";
            // 
            // btnAddgasto
            // 
            this.btnAddgasto.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnAddgasto, "btnAddgasto");
            this.btnAddgasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddgasto.FlatAppearance.BorderSize = 0;
            this.btnAddgasto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddgasto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddgasto.ForeColor = System.Drawing.Color.White;
            this.btnAddgasto.Name = "btnAddgasto";
            this.btnAddgasto.UseVisualStyleBackColor = false;
            this.btnAddgasto.Click += new System.EventHandler(this.BtnAddgasto_Click);
            this.btnAddgasto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAddgasto_MouseDown);
            this.btnAddgasto.MouseEnter += new System.EventHandler(this.btnAddgasto_MouseEnter);
            this.btnAddgasto.MouseLeave += new System.EventHandler(this.btnAddgasto_MouseLeave);
            this.btnAddgasto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAddgasto_MouseUp);
            // 
            // lblMensaje
            // 
            resources.ApplyResources(this.lblMensaje, "lblMensaje");
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Name = "lblMensaje";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "blank-profile-picture-973460_960_720.png");
            this.imageList.Images.SetKeyName(1, "DLOiduYU8AAKbwi.jpg");
            this.imageList.Images.SetKeyName(2, "pez-payaso.jpg");
            this.imageList.Images.SetKeyName(3, "nigeriana.jpg");
            this.imageList.Images.SetKeyName(4, "Caballo-Reto.jpg");
            this.imageList.Images.SetKeyName(5, "Animales-salvajes-2018-SF-fotos-divertidas-7.jpg");
            this.imageList.Images.SetKeyName(6, "989289_w767h767c1cx511cy250.jpg");
            this.imageList.Images.SetKeyName(7, "aereos-aguila.jpg");
            this.imageList.Images.SetKeyName(8, "1524913221_572475_1524913364_noticia_normal.jpg");
            this.imageList.Images.SetKeyName(9, "23815272238_77f1b41a56_k.jpg");
            this.imageList.Images.SetKeyName(10, "1016079.jpg");
            this.imageList.Images.SetKeyName(11, "Fotos-Divertidas-del-mundo-animal-P.png");
            // 
            // lblFoto
            // 
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblFoto, "lblFoto");
            this.lblFoto.ImageList = this.imageList;
            this.lblFoto.Name = "lblFoto";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnIngresar, "btnIngresar");
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            this.btnIngresar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIngresar_MouseDown);
            this.btnIngresar.MouseEnter += new System.EventHandler(this.btnIngresar_MouseEnter);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);
            this.btnIngresar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIngresar_MouseUp);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtPass, "txtPass");
            this.txtPass.Name = "txtPass";
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // lblPass
            // 
            resources.ApplyResources(this.lblPass, "lblPass");
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Name = "lblPass";
            // 
            // lblRegistrar
            // 
            resources.ApplyResources(this.lblRegistrar, "lblRegistrar");
            this.lblRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrar.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblRegistrar_MouseClick);
            this.lblRegistrar.MouseEnter += new System.EventHandler(this.lblRegistrar_MouseEnter);
            this.lblRegistrar.MouseLeave += new System.EventHandler(this.lblRegistrar_MouseLeave);
            // 
            // lblEliminar
            // 
            resources.ApplyResources(this.lblEliminar, "lblEliminar");
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminar.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblEliminar_MouseClick);
            this.lblEliminar.MouseEnter += new System.EventHandler(this.lblEliminar_MouseEnter);
            this.lblEliminar.MouseLeave += new System.EventHandler(this.lblEliminar_MouseLeave);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnCompras, "btnCompras");
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            this.btnCompras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCompras_MouseDown);
            this.btnCompras.MouseEnter += new System.EventHandler(this.btnCompras_MouseEnter);
            this.btnCompras.MouseLeave += new System.EventHandler(this.btnCompras_MouseLeave);
            this.btnCompras.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCompras_MouseUp);
            // 
            // lblCambio
            // 
            resources.ApplyResources(this.lblCambio, "lblCambio");
            this.lblCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblCambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCambio.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCambio_MouseClick);
            this.lblCambio.MouseEnter += new System.EventHandler(this.lblCambio_MouseEnter);
            this.lblCambio.MouseLeave += new System.EventHandler(this.lblCambio_MouseLeave);
            // 
            // lblAvisoUsuario
            // 
            resources.ApplyResources(this.lblAvisoUsuario, "lblAvisoUsuario");
            this.lblAvisoUsuario.BackColor = System.Drawing.Color.Red;
            this.lblAvisoUsuario.ForeColor = System.Drawing.Color.White;
            this.lblAvisoUsuario.Name = "lblAvisoUsuario";
            // 
            // lblPassInco
            // 
            resources.ApplyResources(this.lblPassInco, "lblPassInco");
            this.lblPassInco.BackColor = System.Drawing.Color.Red;
            this.lblPassInco.ForeColor = System.Drawing.Color.White;
            this.lblPassInco.Name = "lblPassInco";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnEstadisticas, "btnEstadisticas");
            this.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.ForeColor = System.Drawing.Color.White;
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.lblPassInco);
            this.Controls.Add(this.lblAvisoUsuario);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.lblRegistrar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnAddgasto);
            this.Controls.Add(this.lblNoEstas);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblFoto);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNoEstas;
        private System.Windows.Forms.Button btnAddgasto;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblAvisoUsuario;
        private System.Windows.Forms.Label lblPassInco;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}

