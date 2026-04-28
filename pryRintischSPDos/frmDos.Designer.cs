namespace pryRintischSPDos
{
    partial class frmDos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDos));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(192, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Ingrese el Nombre de su Destino";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.Location = new System.Drawing.Point(12, 40);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(112, 13);
            this.lblKm.TabIndex = 1;
            this.lblKm.Text = "Distancia del viaje";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(12, 71);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(104, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Cantidad de Dias";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(210, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(210, 37);
            this.txtKm.MaxLength = 123123;
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(64, 20);
            this.txtKm.TabIndex = 4;
            // 
            // cmbDias
            // 
            this.cmbDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cmbDias.Location = new System.Drawing.Point(210, 68);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(40, 21);
            this.cmbDias.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(155, 114);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 40);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 251);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbDias);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizacion Ferro - Viajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Button btnCalcular;
    }
}