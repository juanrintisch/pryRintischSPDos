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
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.mskKm = new System.Windows.Forms.MaskedTextBox();
            this.lblTextoKm = new System.Windows.Forms.Label();
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
            this.txtNombre.Size = new System.Drawing.Size(118, 20);
            this.txtNombre.TabIndex = 0;
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
            this.cmbDias.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Window;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCalcular.Location = new System.Drawing.Point(286, 95);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 40);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Consultar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // mskKm
            // 
            this.mskKm.Location = new System.Drawing.Point(210, 37);
            this.mskKm.Mask = "9999";
            this.mskKm.Name = "mskKm";
            this.mskKm.Size = new System.Drawing.Size(40, 20);
            this.mskKm.TabIndex = 1;
            this.mskKm.ValidatingType = typeof(int);
            // 
            // lblTextoKm
            // 
            this.lblTextoKm.AutoSize = true;
            this.lblTextoKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoKm.Location = new System.Drawing.Point(256, 44);
            this.lblTextoKm.Name = "lblTextoKm";
            this.lblTextoKm.Size = new System.Drawing.Size(24, 13);
            this.lblTextoKm.TabIndex = 4;
            this.lblTextoKm.Text = "Km";
            // 
            // frmDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(378, 147);
            this.Controls.Add(this.lblTextoKm);
            this.Controls.Add(this.mskKm);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cmbDias);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organización Ferro - Viajes";
            this.Load += new System.EventHandler(this.frmDos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MaskedTextBox mskKm;
        private System.Windows.Forms.Label lblTextoKm;
    }
}