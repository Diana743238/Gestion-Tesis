namespace LibFormularios
{
    partial class FrmProveido
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
            this.label1 = new System.Windows.Forms.Label();
            this.NroProveido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombreTesis = new System.Windows.Forms.TextBox();
            this.CodTesis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuscarTesis = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTeistas = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BuscarDocentes = new System.Windows.Forms.Button();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panelDeBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeistas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Text = "PROVEIDO";
            // 
            // panelDeBotones
            // 
            this.panelDeBotones.Location = new System.Drawing.Point(0, 698);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nro Proveido";
            // 
            // NroProveido
            // 
            this.NroProveido.Location = new System.Drawing.Point(321, 119);
            this.NroProveido.Name = "NroProveido";
            this.NroProveido.ReadOnly = true;
            this.NroProveido.Size = new System.Drawing.Size(100, 20);
            this.NroProveido.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción";
            // 
            // Descripcion
            // 
            this.Descripcion.Location = new System.Drawing.Point(26, 168);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(705, 71);
            this.Descripcion.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NombreTesis);
            this.groupBox1.Controls.Add(this.CodTesis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BuscarTesis);
            this.groupBox1.Location = new System.Drawing.Point(26, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 104);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tesis";
            // 
            // NombreTesis
            // 
            this.NombreTesis.Location = new System.Drawing.Point(140, 70);
            this.NombreTesis.Name = "NombreTesis";
            this.NombreTesis.ReadOnly = true;
            this.NombreTesis.Size = new System.Drawing.Size(559, 20);
            this.NombreTesis.TabIndex = 12;
            // 
            // CodTesis
            // 
            this.CodTesis.Location = new System.Drawing.Point(140, 31);
            this.CodTesis.Name = "CodTesis";
            this.CodTesis.Size = new System.Drawing.Size(100, 20);
            this.CodTesis.TabIndex = 3;
            this.CodTesis.Leave += new System.EventHandler(this.CodTesis_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre de tesis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código de tesis";
            // 
            // BuscarTesis
            // 
            this.BuscarTesis.Location = new System.Drawing.Point(26, 44);
            this.BuscarTesis.Name = "BuscarTesis";
            this.BuscarTesis.Size = new System.Drawing.Size(75, 23);
            this.BuscarTesis.TabIndex = 0;
            this.BuscarTesis.Text = "Buscar Tesis";
            this.BuscarTesis.UseVisualStyleBackColor = true;
            this.BuscarTesis.Click += new System.EventHandler(this.BuscarTesis_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTeistas);
            this.groupBox2.Location = new System.Drawing.Point(26, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 134);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tesistas";
            // 
            // dgvTeistas
            // 
            this.dgvTeistas.AllowUserToAddRows = false;
            this.dgvTeistas.AllowUserToDeleteRows = false;
            this.dgvTeistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeistas.Location = new System.Drawing.Point(9, 21);
            this.dgvTeistas.Name = "dgvTeistas";
            this.dgvTeistas.ReadOnly = true;
            this.dgvTeistas.Size = new System.Drawing.Size(667, 107);
            this.dgvTeistas.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BuscarDocentes);
            this.groupBox3.Controls.Add(this.dgvDocentes);
            this.groupBox3.Location = new System.Drawing.Point(26, 520);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(705, 175);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comision Designada";
            // 
            // BuscarDocentes
            // 
            this.BuscarDocentes.Location = new System.Drawing.Point(313, 8);
            this.BuscarDocentes.Name = "BuscarDocentes";
            this.BuscarDocentes.Size = new System.Drawing.Size(75, 23);
            this.BuscarDocentes.TabIndex = 1;
            this.BuscarDocentes.Text = "Buscar";
            this.BuscarDocentes.UseVisualStyleBackColor = true;
            this.BuscarDocentes.Click += new System.EventHandler(this.BuscarDocentes_Click);
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(9, 37);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.Size = new System.Drawing.Size(667, 132);
            this.dgvDocentes.TabIndex = 0;
            // 
            // Tipo
            // 
            this.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo.FormattingEnabled = true;
            this.Tipo.Location = new System.Drawing.Point(26, 117);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(121, 21);
            this.Tipo.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Tipo";
            // 
            // FrmProveido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(757, 749);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NroProveido);
            this.Controls.Add(this.label1);
            this.Name = "FrmProveido";
            this.Text = " ";
            this.Controls.SetChildIndex(this.panelDeBotones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.NroProveido, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Descripcion, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.Tipo, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.panelDeBotones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeistas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NroProveido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombreTesis;
        private System.Windows.Forms.TextBox CodTesis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BuscarTesis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.Button BuscarDocentes;
        private System.Windows.Forms.ComboBox Tipo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvTeistas;
    }
}
