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
            this.CodSolicitud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRequisitosSolicitud = new System.Windows.Forms.DataGridView();
            this.dgvRequisitos = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Solicitud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodRequisito = new System.Windows.Forms.TextBox();
            this.panelDeBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitosSolicitud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).BeginInit();
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
            // CodSolicitud
            // 
            this.CodSolicitud.Location = new System.Drawing.Point(486, 116);
            this.CodSolicitud.Name = "CodSolicitud";
            this.CodSolicitud.Size = new System.Drawing.Size(109, 20);
            this.CodSolicitud.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Codigo Tramite:";
            // 
            // dgvRequisitosSolicitud
            // 
            this.dgvRequisitosSolicitud.AllowUserToAddRows = false;
            this.dgvRequisitosSolicitud.AllowUserToDeleteRows = false;
            this.dgvRequisitosSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitosSolicitud.Location = new System.Drawing.Point(15, 305);
            this.dgvRequisitosSolicitud.Name = "dgvRequisitosSolicitud";
            this.dgvRequisitosSolicitud.ReadOnly = true;
            this.dgvRequisitosSolicitud.Size = new System.Drawing.Size(732, 88);
            this.dgvRequisitosSolicitud.TabIndex = 18;
            this.dgvRequisitosSolicitud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequisitosSolicitud_CellContentClick);
            // 
            // dgvRequisitos
            // 
            this.dgvRequisitos.AllowUserToAddRows = false;
            this.dgvRequisitos.AllowUserToDeleteRows = false;
            this.dgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.dgvRequisitos.Location = new System.Drawing.Point(12, 185);
            this.dgvRequisitos.Name = "dgvRequisitos";
            this.dgvRequisitos.ReadOnly = true;
            this.dgvRequisitos.Size = new System.Drawing.Size(732, 101);
            this.dgvRequisitos.TabIndex = 17;
            // 
            // Check
            // 
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            // 
            // Solicitud
            // 
            this.Solicitud.AutoCompleteCustomSource.AddRange(new string[] {
            "Solicitud de Evaluacion de Plan de Tesis",
            "Solicitud de Evaluacion de Tesis",
            "Solicitud de Sustentacion Oral"});
            this.Solicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Solicitud.FormattingEnabled = true;
            this.Solicitud.Items.AddRange(new object[] {
            "Solicitud de evaluacion de plan de tesis",
            "Solicitud de evaluacion de tesis",
            "Solicitud de sustentacion oral"});
            this.Solicitud.Location = new System.Drawing.Point(486, 142);
            this.Solicitud.Name = "Solicitud";
            this.Solicitud.Size = new System.Drawing.Size(210, 21);
            this.Solicitud.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Solicitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Codigo Requisito";
            // 
            // CodRequisito
            // 
            this.CodRequisito.Location = new System.Drawing.Point(177, 129);
            this.CodRequisito.Name = "CodRequisito";
            this.CodRequisito.Size = new System.Drawing.Size(131, 20);
            this.CodRequisito.TabIndex = 22;
            // 
            // FrmRequisitoTramite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(753, 468);
            this.Controls.Add(this.CodRequisito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodSolicitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvRequisitosSolicitud);
            this.Controls.Add(this.dgvRequisitos);
            this.Controls.Add(this.Solicitud);
            this.Controls.Add(this.label1);
            this.Name = "FrmRequisitoTramite";
            this.Text = " GESTION TESIS";
            this.Load += new System.EventHandler(this.FrmEjemplar_Load);
            this.Controls.SetChildIndex(this.panelDeBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Solicitud, 0);
            this.Controls.SetChildIndex(this.dgvRequisitos, 0);
            this.Controls.SetChildIndex(this.dgvRequisitosSolicitud, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.CodSolicitud, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CodRequisito, 0);
            this.panelDeBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitosSolicitud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodSolicitud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRequisitosSolicitud;
        private System.Windows.Forms.DataGridView dgvRequisitos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.ComboBox Solicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodRequisito;
    }
}