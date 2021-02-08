namespace LibFormularios
{
    partial class FrmExpediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpediente));
            this.TxtNroExpediente = new System.Windows.Forms.TextBox();
            this.TxtCodTesis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTitloTesis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvTesistas = new System.Windows.Forms.DataGridView();
            this.BtnBuscarTesistas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvAsesores = new System.Windows.Forms.DataGridView();
            this.BtnBuscarAsesores = new System.Windows.Forms.Button();
            this.panelDeBotones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesistas)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsesores)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titulo.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.White;
            this.titulo.Size = new System.Drawing.Size(729, 100);
            this.titulo.Text = "EXPEDIENTE DEL TESISTA";
            // 
            // btnGuardarPadre
            // 
            this.btnGuardarPadre.Click += new System.EventHandler(this.btnGuardarPadre_Click);
            // 
            // panelDeBotones
            // 
            this.panelDeBotones.Location = new System.Drawing.Point(0, 503);
            this.panelDeBotones.Size = new System.Drawing.Size(729, 52);
            // 
            // TxtNroExpediente
            // 
            this.TxtNroExpediente.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroExpediente.Location = new System.Drawing.Point(600, 116);
            this.TxtNroExpediente.Name = "TxtNroExpediente";
            this.TxtNroExpediente.Size = new System.Drawing.Size(102, 21);
            this.TxtNroExpediente.TabIndex = 7;
            // 
            // TxtCodTesis
            // 
            this.TxtCodTesis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodTesis.Location = new System.Drawing.Point(16, 44);
            this.TxtCodTesis.Name = "TxtCodTesis";
            this.TxtCodTesis.Size = new System.Drawing.Size(70, 21);
            this.TxtCodTesis.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nro. Expediente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtTitloTesis);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCodTesis);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DE LA TESIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Titulo :";
            // 
            // TxtTitloTesis
            // 
            this.TxtTitloTesis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTitloTesis.Location = new System.Drawing.Point(119, 44);
            this.TxtTitloTesis.Name = "TxtTitloTesis";
            this.TxtTitloTesis.Size = new System.Drawing.Size(434, 21);
            this.TxtTitloTesis.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Código :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.DgvTesistas);
            this.groupBox2.Controls.Add(this.BtnBuscarTesistas);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 122);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LOS TESISTAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 2;
            // 
            // DgvTesistas
            // 
            this.DgvTesistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTesistas.Location = new System.Drawing.Point(18, 25);
            this.DgvTesistas.Name = "DgvTesistas";
            this.DgvTesistas.Size = new System.Drawing.Size(566, 79);
            this.DgvTesistas.TabIndex = 1;
            // 
            // BtnBuscarTesistas
            // 
            this.BtnBuscarTesistas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarTesistas.BackgroundImage")));
            this.BtnBuscarTesistas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarTesistas.FlatAppearance.BorderSize = 0;
            this.BtnBuscarTesistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarTesistas.Location = new System.Drawing.Point(600, 29);
            this.BtnBuscarTesistas.Name = "BtnBuscarTesistas";
            this.BtnBuscarTesistas.Size = new System.Drawing.Size(57, 36);
            this.BtnBuscarTesistas.TabIndex = 0;
            this.BtnBuscarTesistas.Text = " ";
            this.BtnBuscarTesistas.UseVisualStyleBackColor = true;
            this.BtnBuscarTesistas.Click += new System.EventHandler(this.BtnBuscarTesistas_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha :";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFecha.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DtpFecha.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DtpFecha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(106, 110);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DtpFecha.Size = new System.Drawing.Size(80, 25);
            this.DtpFecha.TabIndex = 13;
            this.DtpFecha.Value = new System.DateTime(2021, 2, 7, 6, 58, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.DgvAsesores);
            this.groupBox3.Controls.Add(this.BtnBuscarAsesores);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(28, 362);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 122);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATOS DE LOS ASESORES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 2;
            // 
            // DgvAsesores
            // 
            this.DgvAsesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAsesores.Location = new System.Drawing.Point(18, 25);
            this.DgvAsesores.Name = "DgvAsesores";
            this.DgvAsesores.Size = new System.Drawing.Size(566, 79);
            this.DgvAsesores.TabIndex = 1;
            // 
            // BtnBuscarAsesores
            // 
            this.BtnBuscarAsesores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarAsesores.BackgroundImage")));
            this.BtnBuscarAsesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarAsesores.FlatAppearance.BorderSize = 0;
            this.BtnBuscarAsesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarAsesores.Location = new System.Drawing.Point(600, 25);
            this.BtnBuscarAsesores.Name = "BtnBuscarAsesores";
            this.BtnBuscarAsesores.Size = new System.Drawing.Size(57, 36);
            this.BtnBuscarAsesores.TabIndex = 0;
            this.BtnBuscarAsesores.Text = " ";
            this.BtnBuscarAsesores.UseVisualStyleBackColor = true;
            this.BtnBuscarAsesores.Click += new System.EventHandler(this.BtnBuscarAsesores_Click);
            // 
            // FrmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(729, 555);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNroExpediente);
            this.Name = "FrmExpediente";
            this.Controls.SetChildIndex(this.panelDeBotones, 0);
            this.Controls.SetChildIndex(this.TxtNroExpediente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.DtpFecha, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.panelDeBotones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTesistas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNroExpediente;
        private System.Windows.Forms.TextBox TxtCodTesis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTitloTesis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvTesistas;
        private System.Windows.Forms.Button BtnBuscarTesistas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvAsesores;
        private System.Windows.Forms.Button BtnBuscarAsesores;
    }
}