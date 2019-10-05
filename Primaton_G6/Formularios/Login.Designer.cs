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
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(136, 79);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(110, 29);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblNoEstas
            // 
            this.lblNoEstas.AutoSize = true;
            this.lblNoEstas.BackColor = System.Drawing.Color.Transparent;
            this.lblNoEstas.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNoEstas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoEstas.ForeColor = System.Drawing.Color.Navy;
            this.lblNoEstas.Location = new System.Drawing.Point(159, 329);
            this.lblNoEstas.Name = "lblNoEstas";
            this.lblNoEstas.Size = new System.Drawing.Size(196, 20);
            this.lblNoEstas.TabIndex = 7;
            this.lblNoEstas.Text = "¿No estás registrado?";
            // 
            // btnAddgasto
            // 
            this.btnAddgasto.BackColor = System.Drawing.Color.Transparent;
            this.btnAddgasto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddgasto.BackgroundImage")));
            this.btnAddgasto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddgasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddgasto.FlatAppearance.BorderSize = 0;
            this.btnAddgasto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddgasto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddgasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddgasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddgasto.ForeColor = System.Drawing.Color.White;
            this.btnAddgasto.Location = new System.Drawing.Point(163, 216);
            this.btnAddgasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddgasto.Name = "btnAddgasto";
            this.btnAddgasto.Size = new System.Drawing.Size(144, 86);
            this.btnAddgasto.TabIndex = 3;
            this.btnAddgasto.Text = "Agregar gastos";
            this.btnAddgasto.UseVisualStyleBackColor = false;
            this.btnAddgasto.Click += new System.EventHandler(this.BtnAddgasto_Click);
            this.btnAddgasto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAddgasto_MouseDown);
            this.btnAddgasto.MouseEnter += new System.EventHandler(this.btnAddgasto_MouseEnter);
            this.btnAddgasto.MouseLeave += new System.EventHandler(this.btnAddgasto_MouseLeave);
            this.btnAddgasto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnAddgasto_MouseUp);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Location = new System.Drawing.Point(174, 67);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(53, 24);
            this.lblMensaje.TabIndex = 9;
            this.lblMensaje.Text = "Hola";
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
            this.lblFoto.ImageIndex = 0;
            this.lblFoto.ImageList = this.imageList;
            this.lblFoto.Location = new System.Drawing.Point(12, 36);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(157, 117);
            this.lblFoto.TabIndex = 13;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIngresar.BackgroundImage")));
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(423, 164);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(131, 41);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            this.btnIngresar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnIngresar_MouseDown);
            this.btnIngresar.MouseEnter += new System.EventHandler(this.btnIngresar_MouseEnter);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_MouseLeave);
            this.btnIngresar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnIngresar_MouseUp);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(256, 79);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 30);
            this.txtNombre.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(256, 124);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(293, 30);
            this.txtPass.TabIndex = 1;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(95, 124);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(153, 29);
            this.lblPass.TabIndex = 15;
            this.lblPass.Text = "Contraseña:";
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.ForeColor = System.Drawing.Color.Red;
            this.lblRegistrar.Location = new System.Drawing.Point(393, 329);
            this.lblRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(116, 25);
            this.lblRegistrar.TabIndex = 16;
            this.lblRegistrar.Text = "Registrate!";
            this.lblRegistrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblRegistrar_MouseClick);
            this.lblRegistrar.MouseEnter += new System.EventHandler(this.lblRegistrar_MouseEnter);
            this.lblRegistrar.MouseLeave += new System.EventHandler(this.lblRegistrar_MouseLeave);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.Red;
            this.lblEliminar.Location = new System.Drawing.Point(517, 332);
            this.lblEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(147, 18);
            this.lblEliminar.TabIndex = 17;
            this.lblEliminar.Text = "Eliminar mi cuenta";
            this.lblEliminar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblEliminar_MouseClick);
            this.lblEliminar.MouseEnter += new System.EventHandler(this.lblEliminar_MouseEnter);
            this.lblEliminar.MouseLeave += new System.EventHandler(this.lblEliminar_MouseLeave);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompras.BackgroundImage")));
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(410, 216);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(144, 86);
            this.btnCompras.TabIndex = 19;
            this.btnCompras.Text = "Ver lista del super";
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Visible = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            this.btnCompras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCompras_MouseDown);
            this.btnCompras.MouseEnter += new System.EventHandler(this.btnCompras_MouseEnter);
            this.btnCompras.MouseLeave += new System.EventHandler(this.btnCompras_MouseLeave);
            this.btnCompras.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCompras_MouseUp);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblCambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.Color.Red;
            this.lblCambio.Location = new System.Drawing.Point(3, 316);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(219, 36);
            this.lblCambio.TabIndex = 21;
            this.lblCambio.Text = "No eres tu? \r\nQuieres cambiar de cuenta?";
            this.lblCambio.Visible = false;
            this.lblCambio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCambio_MouseClick);
            this.lblCambio.MouseEnter += new System.EventHandler(this.lblCambio_MouseEnter);
            this.lblCambio.MouseLeave += new System.EventHandler(this.lblCambio_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 364);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
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
    }
}

