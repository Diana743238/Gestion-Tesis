namespace LibFormularios
{
    partial class FrmRequisitoTramite
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
            this.dgvRequisitosSolicitud = new System.Windows.Forms.DataGridView();
            this.Solicitud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkListBoxRequisitos = new System.Windows.Forms.CheckedListBox();
            this.panelDeBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitosSolicitud)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titulo.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Size = new System.Drawing.Size(753, 100);
            this.titulo.Text = "REGISTRO DE REQUISITOS POR TRAMITE";
            // 
            // panelDeBotones
            // 
            this.panelDeBotones.Location = new System.Drawing.Point(0, 408);
            this.panelDeBotones.Size = new System.Drawing.Size(753, 60);
            // 
            // dgvRequisitosSolicitud
            // 
            this.dgvRequisitosSolicitud.AllowUserToAddRows = false;
            this.dgvRequisitosSolicitud.AllowUserToDeleteRows = false;
            this.dgvRequisitosSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitosSolicitud.Location = new System.Drawing.Point(15, 286);
            this.dgvRequisitosSolicitud.Name = "dgvRequisitosSolicitud";
            this.dgvRequisitosSolicitud.ReadOnly = true;
            this.dgvRequisitosSolicitud.Size = new System.Drawing.Size(732, 107);
            this.dgvRequisitosSolicitud.TabIndex = 18;
            // 
            // Solicitud
            // 
            this.Solicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Solicitud.FormattingEnabled = true;
            this.Solicitud.Location = new System.Drawing.Point(430, 114);
            this.Solicitud.Name = "Solicitud";
            this.Solicitud.Size = new System.Drawing.Size(210, 21);
            this.Solicitud.TabIndex = 16;
            this.Solicitud.SelectedIndexChanged += new System.EventHandler(this.ChkListBoxRequisitos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Seleccione tipo de Solicitud:";
            // 
            // ChkListBoxRequisitos
            // 
            this.ChkListBoxRequisitos.FormattingEnabled = true;
            this.ChkListBoxRequisitos.Items.AddRange(new object[] {
            "FICHA DE SEGUIMIENTO",
            "CARTA DE ACEPTACIÓN DEL ASESOR",
            "RECIBO DE PAGO",
            "COPIA DE DNI",
            "CONSTANCIA DE NO DEUDOR",
            "EJEMPLAR ANILLADO DE LA TESIS",
            "COPIA DE DIPLOMA DE BACHILLER",
            "COPIA DE CERTIFICADO DE ESTUDIOS DE IDIOMA EXTRANJERO",
            "COPIA DE CERTIFICADO DE ESTUDIOS",
            "RESOLUCIÓN DE APROBACIÓN DE PLAN DE TESIS",
            "RESOLUCIÓN FAVORABLE DE LOS DICTAMINANTES"});
            this.ChkListBoxRequisitos.Location = new System.Drawing.Point(229, 141);
            this.ChkListBoxRequisitos.Name = "ChkListBoxRequisitos";
            this.ChkListBoxRequisitos.Size = new System.Drawing.Size(411, 139);
            this.ChkListBoxRequisitos.TabIndex = 19;
            // 
            // FrmRequisitoTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(753, 468);
            this.Controls.Add(this.ChkListBoxRequisitos);
            this.Controls.Add(this.dgvRequisitosSolicitud);
            this.Controls.Add(this.Solicitud);
            this.Controls.Add(this.label1);
            this.Name = "FrmRequisitoTramite";
            this.Text = " GESTION TESIS";
            this.Load += new System.EventHandler(this.FrmEjemplar_Load);
            this.Controls.SetChildIndex(this.panelDeBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Solicitud, 0);
            this.Controls.SetChildIndex(this.dgvRequisitosSolicitud, 0);
            this.Controls.SetChildIndex(this.ChkListBoxRequisitos, 0);
            this.panelDeBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitosSolicitud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRequisitosSolicitud;
        private System.Windows.Forms.ComboBox Solicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ChkListBoxRequisitos;
    }
}