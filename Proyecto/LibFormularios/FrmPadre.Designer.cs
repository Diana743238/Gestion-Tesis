namespace LibFormularios
{
    partial class FrmPadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPadre));
            this.titulo = new System.Windows.Forms.Label();
            this.panelDeBotones = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardarPadre = new System.Windows.Forms.Button();
            this.btnNuevoPadre = new System.Windows.Forms.Button();
            this.btnSalirPadre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDeBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(757, 100);
            this.titulo.TabIndex = 4;
            this.titulo.Text = "titulo de ventana";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // panelDeBotones
            // 
            this.panelDeBotones.Controls.Add(this.btnEliminar);
            this.panelDeBotones.Controls.Add(this.btnGuardarPadre);
            this.panelDeBotones.Controls.Add(this.btnNuevoPadre);
            this.panelDeBotones.Controls.Add(this.btnSalirPadre);
            this.panelDeBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeBotones.Location = new System.Drawing.Point(0, 399);
            this.panelDeBotones.Name = "panelDeBotones";
            this.panelDeBotones.Size = new System.Drawing.Size(757, 51);
            this.panelDeBotones.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SeaShell;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(147, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 43);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardarPadre
            // 
            this.btnGuardarPadre.BackColor = System.Drawing.Color.SeaShell;
            this.btnGuardarPadre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarPadre.BackgroundImage")));
            this.btnGuardarPadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPadre.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPadre.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPadre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarPadre.Location = new System.Drawing.Point(486, 3);
            this.btnGuardarPadre.Name = "btnGuardarPadre";
            this.btnGuardarPadre.Size = new System.Drawing.Size(126, 43);
            this.btnGuardarPadre.TabIndex = 2;
            this.btnGuardarPadre.Text = " Guardar";
            this.btnGuardarPadre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPadre.UseVisualStyleBackColor = false;
            this.btnGuardarPadre.Click += new System.EventHandler(this.btnGuardarPadre_Click);
            // 
            // btnNuevoPadre
            // 
            this.btnNuevoPadre.BackColor = System.Drawing.Color.SeaShell;
            this.btnNuevoPadre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoPadre.BackgroundImage")));
            this.btnNuevoPadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPadre.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPadre.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPadre.Location = new System.Drawing.Point(40, 3);
            this.btnNuevoPadre.Name = "btnNuevoPadre";
            this.btnNuevoPadre.Size = new System.Drawing.Size(101, 43);
            this.btnNuevoPadre.TabIndex = 1;
            this.btnNuevoPadre.Text = "Nuevo";
            this.btnNuevoPadre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPadre.UseVisualStyleBackColor = false;
            this.btnNuevoPadre.Click += new System.EventHandler(this.btnNuevoPadre_Click);
            // 
            // btnSalirPadre
            // 
            this.btnSalirPadre.BackColor = System.Drawing.Color.SeaShell;
            this.btnSalirPadre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalirPadre.BackgroundImage")));
            this.btnSalirPadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalirPadre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirPadre.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirPadre.ForeColor = System.Drawing.Color.White;
            this.btnSalirPadre.Location = new System.Drawing.Point(618, 3);
            this.btnSalirPadre.Name = "btnSalirPadre";
            this.btnSalirPadre.Size = new System.Drawing.Size(101, 43);
            this.btnSalirPadre.TabIndex = 0;
            this.btnSalirPadre.Text = "Salir";
            this.btnSalirPadre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirPadre.UseVisualStyleBackColor = false;
            this.btnSalirPadre.Click += new System.EventHandler(this.btnSalirPadre_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 100);
            this.panel1.TabIndex = 6;
            // 
            // FrmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDeBotones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.panelDeBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label titulo;
        protected System.Windows.Forms.Button btnNuevoPadre;
        protected System.Windows.Forms.Button btnEliminar;
        protected System.Windows.Forms.Button btnSalirPadre;
        protected System.Windows.Forms.Panel panelDeBotones;
        protected System.Windows.Forms.Button btnGuardarPadre;
    }
}