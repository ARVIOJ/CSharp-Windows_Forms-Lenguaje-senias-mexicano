namespace LMS
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblInfo = new System.Windows.Forms.Label();
            this.ptbPalabras = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txb5 = new System.Windows.Forms.TextBox();
            this.txb4 = new System.Windows.Forms.TextBox();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.ptb1 = new System.Windows.Forms.PictureBox();
            this.ptb2 = new System.Windows.Forms.PictureBox();
            this.ptb3 = new System.Windows.Forms.PictureBox();
            this.ptb4 = new System.Windows.Forms.PictureBox();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.ptb5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSalir = new LMS.ARVIOJButton();
            this.btnResetear = new LMS.ARVIOJButton();
            this.btnBuscar = new LMS.ARVIOJButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPalabras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblInfo.Location = new System.Drawing.Point(330, 438);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(230, 79);
            this.lblInfo.TabIndex = 99;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfo.Visible = false;
            // 
            // ptbPalabras
            // 
            this.ptbPalabras.BackColor = System.Drawing.Color.Transparent;
            this.ptbPalabras.Image = global::LMS.Properties.Resources.ATOLE;
            this.ptbPalabras.Location = new System.Drawing.Point(368, 254);
            this.ptbPalabras.Name = "ptbPalabras";
            this.ptbPalabras.Size = new System.Drawing.Size(154, 181);
            this.ptbPalabras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPalabras.TabIndex = 98;
            this.ptbPalabras.TabStop = false;
            this.ptbPalabras.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Goudy Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Location = new System.Drawing.Point(172, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(567, 55);
            this.lblTitulo.TabIndex = 97;
            this.lblTitulo.Text = "Lenguaje de señas mexicano";
            // 
            // txb5
            // 
            this.txb5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txb5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb5.ForeColor = System.Drawing.SystemColors.Window;
            this.txb5.Location = new System.Drawing.Point(729, 117);
            this.txb5.MaxLength = 1;
            this.txb5.Name = "txb5";
            this.txb5.Size = new System.Drawing.Size(81, 98);
            this.txb5.TabIndex = 5;
            this.txb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb5.TextChanged += new System.EventHandler(this.txb5_TextChanged);
            this.txb5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb5_KeyPress);
            // 
            // txb4
            // 
            this.txb4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txb4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb4.ForeColor = System.Drawing.SystemColors.Window;
            this.txb4.Location = new System.Drawing.Point(566, 117);
            this.txb4.MaxLength = 1;
            this.txb4.Name = "txb4";
            this.txb4.Size = new System.Drawing.Size(81, 98);
            this.txb4.TabIndex = 4;
            this.txb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb4.TextChanged += new System.EventHandler(this.txb4_TextChanged);
            this.txb4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb4_KeyPress);
            // 
            // txb3
            // 
            this.txb3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txb3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb3.ForeColor = System.Drawing.SystemColors.Window;
            this.txb3.Location = new System.Drawing.Point(408, 117);
            this.txb3.MaxLength = 1;
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(81, 98);
            this.txb3.TabIndex = 3;
            this.txb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb3.TextChanged += new System.EventHandler(this.txb3_TextChanged);
            this.txb3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb3_KeyPress);
            // 
            // txb2
            // 
            this.txb2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txb2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb2.ForeColor = System.Drawing.SystemColors.Window;
            this.txb2.Location = new System.Drawing.Point(245, 117);
            this.txb2.MaxLength = 1;
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(81, 98);
            this.txb2.TabIndex = 2;
            this.txb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb2.TextChanged += new System.EventHandler(this.txb2_TextChanged);
            this.txb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb2_KeyPress);
            // 
            // ptb1
            // 
            this.ptb1.BackColor = System.Drawing.Color.Transparent;
            this.ptb1.Image = global::LMS.Properties.Resources.A;
            this.ptb1.Location = new System.Drawing.Point(53, 221);
            this.ptb1.Name = "ptb1";
            this.ptb1.Size = new System.Drawing.Size(143, 143);
            this.ptb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb1.TabIndex = 92;
            this.ptb1.TabStop = false;
            this.ptb1.Visible = false;
            // 
            // ptb2
            // 
            this.ptb2.BackColor = System.Drawing.Color.Transparent;
            this.ptb2.Image = global::LMS.Properties.Resources.A;
            this.ptb2.Location = new System.Drawing.Point(211, 221);
            this.ptb2.Name = "ptb2";
            this.ptb2.Size = new System.Drawing.Size(143, 143);
            this.ptb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb2.TabIndex = 93;
            this.ptb2.TabStop = false;
            this.ptb2.Visible = false;
            // 
            // ptb3
            // 
            this.ptb3.BackColor = System.Drawing.Color.Transparent;
            this.ptb3.Image = global::LMS.Properties.Resources.A;
            this.ptb3.Location = new System.Drawing.Point(373, 221);
            this.ptb3.Name = "ptb3";
            this.ptb3.Size = new System.Drawing.Size(143, 143);
            this.ptb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb3.TabIndex = 94;
            this.ptb3.TabStop = false;
            this.ptb3.Visible = false;
            // 
            // ptb4
            // 
            this.ptb4.BackColor = System.Drawing.Color.Transparent;
            this.ptb4.Image = global::LMS.Properties.Resources.A;
            this.ptb4.Location = new System.Drawing.Point(533, 221);
            this.ptb4.Name = "ptb4";
            this.ptb4.Size = new System.Drawing.Size(143, 143);
            this.ptb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb4.TabIndex = 95;
            this.ptb4.TabStop = false;
            this.ptb4.Visible = false;
            // 
            // txb1
            // 
            this.txb1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.txb1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb1.ForeColor = System.Drawing.SystemColors.Window;
            this.txb1.Location = new System.Drawing.Point(85, 117);
            this.txb1.MaxLength = 1;
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(81, 98);
            this.txb1.TabIndex = 0;
            this.txb1.Tag = "";
            this.txb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb1.TextChanged += new System.EventHandler(this.txb1_TextChanged);
            this.txb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb1_KeyPress);
            // 
            // ptb5
            // 
            this.ptb5.BackColor = System.Drawing.Color.Transparent;
            this.ptb5.Image = global::LMS.Properties.Resources.A;
            this.ptb5.Location = new System.Drawing.Point(697, 221);
            this.ptb5.Name = "ptb5";
            this.ptb5.Size = new System.Drawing.Size(143, 143);
            this.ptb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb5.TabIndex = 96;
            this.ptb5.TabStop = false;
            this.ptb5.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblMinimizar);
            this.panel1.Controls.Add(this.lblCerrar);
            this.panel1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 36);
            this.panel1.TabIndex = 91;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.AutoSize = true;
            this.lblMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMinimizar.Font = new System.Drawing.Font("Aerolinea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMinimizar.Location = new System.Drawing.Point(841, 6);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(22, 24);
            this.lblMinimizar.TabIndex = 67;
            this.lblMinimizar.Text = "--";
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblCerrar
            // 
            this.lblCerrar.AutoSize = true;
            this.lblCerrar.BackColor = System.Drawing.Color.Transparent;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCerrar.Font = new System.Drawing.Font("Aerolinea", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCerrar.Location = new System.Drawing.Point(869, 5);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(22, 24);
            this.lblCerrar.TabIndex = 66;
            this.lblCerrar.Text = "X";
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.BackgroundImage = global::LMS.Properties.Resources.sign_info_icon_34361;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInfo.Location = new System.Drawing.Point(16, 492);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(50, 51);
            this.btnInfo.TabIndex = 8;
            this.btnInfo.Text = "&i";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalir.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnSalir.BackgroundImage = global::LMS.Properties.Resources.btnFondo;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.BorderColor = System.Drawing.Color.White;
            this.btnSalir.BorderRadius = 20;
            this.btnSalir.BorderSize = 1;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(785, 500);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 40);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextColor = System.Drawing.Color.White;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnResetear.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnResetear.BackgroundImage = global::LMS.Properties.Resources.btnFondo;
            this.btnResetear.BorderColor = System.Drawing.Color.White;
            this.btnResetear.BorderRadius = 20;
            this.btnResetear.BorderSize = 1;
            this.btnResetear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetear.Enabled = false;
            this.btnResetear.FlatAppearance.BorderSize = 0;
            this.btnResetear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.ForeColor = System.Drawing.Color.White;
            this.btnResetear.Location = new System.Drawing.Point(687, 500);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(92, 40);
            this.btnResetear.TabIndex = 7;
            this.btnResetear.Text = "&Resetear";
            this.btnResetear.TextColor = System.Drawing.Color.White;
            this.btnResetear.UseVisualStyleBackColor = false;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.BackgroundImage = global::LMS.Properties.Resources.btnFondo;
            this.btnBuscar.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.BorderRadius = 20;
            this.btnBuscar.BorderSize = 1;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Enabled = false;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(589, 500);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 40);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "&Buscar palabra";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::LMS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(903, 549);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.ptbPalabras);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txb5);
            this.Controls.Add(this.txb4);
            this.Controls.Add(this.txb3);
            this.Controls.Add(this.txb2);
            this.Controls.Add(this.ptb1);
            this.Controls.Add(this.ptb2);
            this.Controls.Add(this.ptb3);
            this.Controls.Add(this.ptb4);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.ptb5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LSM";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPalabras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox ptbPalabras;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txb5;
        private System.Windows.Forms.TextBox txb4;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.PictureBox ptb1;
        private System.Windows.Forms.PictureBox ptb2;
        private System.Windows.Forms.PictureBox ptb3;
        private System.Windows.Forms.PictureBox ptb4;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.PictureBox ptb5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.Button btnInfo;
        private ARVIOJButton btnBuscar;
        private ARVIOJButton btnResetear;
        private ARVIOJButton btnSalir;
    }
}

