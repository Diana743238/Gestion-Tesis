﻿namespace AppGestionDeTesis
{
    partial class FrmGestionTesis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionTesis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tramites = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRODETESISTASToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRODEDOCENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRAMITESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Requisitos = new System.Windows.Forms.ToolStripMenuItem();
            this.RequisitosSolicitud = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
            this.pROCESOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSCRIPCIÓNDEPLANDETESISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gENERAREXPEDIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gENERARPROVEIDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRARINFORMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRARRESOLUCIÓNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
=======
            this.tRAMITESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> 28d1e63058a456b02821e0f9358a209782f0681d
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 86);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Stencil", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(751, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIÓN DE TESIS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 38);
            this.panel2.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.Tramites,
            this.pROCESOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 2);
            this.menuStrip1.Name = "menuStrip1";
<<<<<<< HEAD
            this.menuStrip1.Size = new System.Drawing.Size(555, 30);
=======
            this.menuStrip1.Size = new System.Drawing.Size(453, 32);
>>>>>>> 28d1e63058a456b02821e0f9358a209782f0681d
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNICIOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iNICIOToolStripMenuItem.Image")));
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            this.iNICIOToolStripMenuItem.Click += new System.EventHandler(this.iNICIOToolStripMenuItem_Click);
            // 
            // Tramites
            // 
            this.Tramites.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRODETESISTASToolStripMenuItem1,
            this.rEGISTRODEDOCENTESToolStripMenuItem,
            this.tRAMITESToolStripMenuItem,
            this.Requisitos,
            this.RequisitosSolicitud});
            this.Tramites.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tramites.Image = ((System.Drawing.Image)(resources.GetObject("Tramites.Image")));
            this.Tramites.Name = "Tramites";
            this.Tramites.Size = new System.Drawing.Size(210, 26);
            this.Tramites.Text = "MANTENIMIENTO";
            // 
            // rEGISTRODETESISTASToolStripMenuItem1
            // 
            this.rEGISTRODETESISTASToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rEGISTRODETESISTASToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.rEGISTRODETESISTASToolStripMenuItem1.Name = "rEGISTRODETESISTASToolStripMenuItem1";
            this.rEGISTRODETESISTASToolStripMenuItem1.Size = new System.Drawing.Size(334, 26);
            this.rEGISTRODETESISTASToolStripMenuItem1.Text = "REGISTRO DE TESISTAS";
            this.rEGISTRODETESISTASToolStripMenuItem1.Click += new System.EventHandler(this.rEGISTRODETESISTASToolStripMenuItem1_Click);
            // 
            // rEGISTRODEDOCENTESToolStripMenuItem
            // 
            this.rEGISTRODEDOCENTESToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rEGISTRODEDOCENTESToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.rEGISTRODEDOCENTESToolStripMenuItem.Name = "rEGISTRODEDOCENTESToolStripMenuItem";
            this.rEGISTRODEDOCENTESToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.rEGISTRODEDOCENTESToolStripMenuItem.Text = "REGISTRO DE DOCENTES";
            this.rEGISTRODEDOCENTESToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRODEDOCENTESToolStripMenuItem_Click);
            // 
            // tRAMITESToolStripMenuItem
            // 
            this.tRAMITESToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tRAMITESToolStripMenuItem.Name = "tRAMITESToolStripMenuItem";
            this.tRAMITESToolStripMenuItem.Size = new System.Drawing.Size(334, 26);
            this.tRAMITESToolStripMenuItem.Text = "TRAMITES";
            this.tRAMITESToolStripMenuItem.Click += new System.EventHandler(this.tRAMITESToolStripMenuItem_Click);
            // 
            // Requisitos
            // 
            this.Requisitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Requisitos.Name = "Requisitos";
            this.Requisitos.Size = new System.Drawing.Size(334, 26);
            this.Requisitos.Text = "REQUISITOS";
            this.Requisitos.Click += new System.EventHandler(this.Requisitos_Click);
            // 
            // RequisitosSolicitud
            // 
            this.RequisitosSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RequisitosSolicitud.Name = "RequisitosSolicitud";
            this.RequisitosSolicitud.Size = new System.Drawing.Size(334, 26);
            this.RequisitosSolicitud.Text = "REQUISTOS POR TRAMITE";
            this.RequisitosSolicitud.Click += new System.EventHandler(this.RequisitosSolicitud_Click);
            // 
<<<<<<< HEAD
            // pROCESOSToolStripMenuItem
            // 
            this.pROCESOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNSCRIPCIÓNDEPLANDETESISToolStripMenuItem,
            this.rEGISTRARToolStripMenuItem});
            this.pROCESOSToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROCESOSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pROCESOSToolStripMenuItem.Image")));
            this.pROCESOSToolStripMenuItem.Name = "pROCESOSToolStripMenuItem";
            this.pROCESOSToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.pROCESOSToolStripMenuItem.Text = "PROCESOS";
            // 
            // iNSCRIPCIÓNDEPLANDETESISToolStripMenuItem
            // 
            this.iNSCRIPCIÓNDEPLANDETESISToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iNSCRIPCIÓNDEPLANDETESISToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gENERAREXPEDIENTEToolStripMenuItem,
            this.gENERARPROVEIDOToolStripMenuItem});
            this.iNSCRIPCIÓNDEPLANDETESISToolStripMenuItem.Name = "iNSCRIPCIÓNDEPLANDETESISToolStripMenuItem";
            this.iNSCRIPCIÓNDEPLANDETESISToolStripMenuItem.Size = new System.Drawing.Size(389, 26);
            this.iNSCRIPCIÓNDEPLANDETESISToolStripMenuItem.Text = "INSCRIPCIÓN DE PLAN DE TESIS";
            // 
            // gENERAREXPEDIENTEToolStripMenuItem
            // 
            this.gENERAREXPEDIENTEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gENERAREXPEDIENTEToolStripMenuItem.Name = "gENERAREXPEDIENTEToolStripMenuItem";
            this.gENERAREXPEDIENTEToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.gENERAREXPEDIENTEToolStripMenuItem.Text = "GENERAR EXPEDIENTE";
            this.gENERAREXPEDIENTEToolStripMenuItem.Click += new System.EventHandler(this.gENERAREXPEDIENTEToolStripMenuItem_Click);
            // 
            // gENERARPROVEIDOToolStripMenuItem
            // 
            this.gENERARPROVEIDOToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gENERARPROVEIDOToolStripMenuItem.Name = "gENERARPROVEIDOToolStripMenuItem";
            this.gENERARPROVEIDOToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.gENERARPROVEIDOToolStripMenuItem.Text = "GENERAR PROVEIDO";
            // 
            // rEGISTRARToolStripMenuItem
            // 
            this.rEGISTRARToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rEGISTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRARINFORMESToolStripMenuItem,
            this.rEGISTRARRESOLUCIÓNToolStripMenuItem});
            this.rEGISTRARToolStripMenuItem.Name = "rEGISTRARToolStripMenuItem";
            this.rEGISTRARToolStripMenuItem.Size = new System.Drawing.Size(389, 26);
            this.rEGISTRARToolStripMenuItem.Text = "REGISTRAR DICTAMEN";
            // 
            // rEGISTRARINFORMESToolStripMenuItem
            // 
            this.rEGISTRARINFORMESToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rEGISTRARINFORMESToolStripMenuItem.Name = "rEGISTRARINFORMESToolStripMenuItem";
            this.rEGISTRARINFORMESToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.rEGISTRARINFORMESToolStripMenuItem.Text = "REGISTRAR INFORMES";
            // 
            // rEGISTRARRESOLUCIÓNToolStripMenuItem
            // 
            this.rEGISTRARRESOLUCIÓNToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rEGISTRARRESOLUCIÓNToolStripMenuItem.Name = "rEGISTRARRESOLUCIÓNToolStripMenuItem";
            this.rEGISTRARRESOLUCIÓNToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.rEGISTRARRESOLUCIÓNToolStripMenuItem.Text = "REGISTRAR RESOLUCIÓN";
=======
            // tRAMITESToolStripMenuItem
            // 
            this.tRAMITESToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tRAMITESToolStripMenuItem.Name = "tRAMITESToolStripMenuItem";
            this.tRAMITESToolStripMenuItem.Size = new System.Drawing.Size(341, 28);
            this.tRAMITESToolStripMenuItem.Text = "TRAMITES";
            this.tRAMITESToolStripMenuItem.Click += new System.EventHandler(this.tRAMITESToolStripMenuItem_Click);
>>>>>>> 28d1e63058a456b02821e0f9358a209782f0681d
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 327);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGestionTesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionTesis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Tesis";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tramites;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRODETESISTASToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRODEDOCENTESToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem Requisitos;
        private System.Windows.Forms.ToolStripMenuItem RequisitosSolicitud;
        private System.Windows.Forms.ToolStripMenuItem tRAMITESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCESOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSCRIPCIÓNDEPLANDETESISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gENERAREXPEDIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gENERARPROVEIDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRARINFORMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRARRESOLUCIÓNToolStripMenuItem;
    }
}

