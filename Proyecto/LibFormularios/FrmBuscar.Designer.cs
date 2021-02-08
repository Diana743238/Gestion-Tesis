namespace LibFormularios
{
    partial class FrmBuscar
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
            this.Tabla = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscador = new System.Windows.Forms.TextBox();
            this.Atributo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.Seleccionado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tabla.FormattingEnabled = true;
            this.Tabla.Items.AddRange(new object[] {
            "Tesis",
            "Tesistas",
            "Docentes"});
            this.Tabla.Location = new System.Drawing.Point(38, 36);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(121, 21);
            this.Tabla.TabIndex = 0;
            this.Tabla.Leave += new System.EventHandler(this.Tabla_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar";
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(35, 92);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(549, 20);
            this.buscador.TabIndex = 3;
            // 
            // Atributo
            // 
            this.Atributo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Atributo.FormattingEnabled = true;
            this.Atributo.Location = new System.Drawing.Point(264, 36);
            this.Atributo.Name = "Atributo";
            this.Atributo.Size = new System.Drawing.Size(121, 21);
            this.Atributo.TabIndex = 4;
            this.Atributo.Leave += new System.EventHandler(this.Atributo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Atributo";
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionado});
            this.dgvResultados.Location = new System.Drawing.Point(13, 160);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(775, 253);
            this.dgvResultados.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(605, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(709, 131);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.Seleccionar.TabIndex = 8;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // Seleccionado
            // 
            this.Seleccionado.HeaderText = "";
            this.Seleccionado.Name = "Seleccionado";
            // 
            // FrmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvResultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Atributo);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tabla);
            this.Name = "FrmBuscar";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ComboBox Tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.ComboBox Atributo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionado;
    }
}