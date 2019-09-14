namespace Primaton_G6
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pb3 = new Primaton_G6.pictureBoxRedonda();
            this.pb2 = new Primaton_G6.pictureBoxRedonda();
            this.pb1 = new Primaton_G6.pictureBoxRedonda();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(101, 121);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 42);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Agregar Usuario";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(328, 121);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 42);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Agregar Usuario";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(555, 121);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 42);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Agregar Usuario";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(687, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.White;
            this.pb3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb3.BackgroundImage")));
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Location = new System.Drawing.Point(492, 42);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(200, 200);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 4;
            this.pb3.TabStop = false;
            this.pb3.Visible = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.White;
            this.pb2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb2.BackgroundImage")));
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Location = new System.Drawing.Point(265, 42);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(200, 200);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 2;
            this.pb2.TabStop = false;
            this.pb2.Visible = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.White;
            this.pb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb1.BackgroundImage")));
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Location = new System.Drawing.Point(38, 42);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(200, 200);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Visible = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pictureBoxRedonda pb1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private pictureBoxRedonda pb2;
        private System.Windows.Forms.Button btn3;
        private pictureBoxRedonda pb3;
        private System.Windows.Forms.Label label1;
    }
}

