namespace pryJuegoTpLab2
{
    partial class frmSeleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccion));
            this.gbJugador2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClasePJ2 = new System.Windows.Forms.ComboBox();
            this.btnElegirPJ2 = new System.Windows.Forms.Button();
            this.cmbHabPJ2 = new System.Windows.Forms.ComboBox();
            this.gbJugador1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClasePJ1 = new System.Windows.Forms.ComboBox();
            this.btnElegirPJ1 = new System.Windows.Forms.Button();
            this.cmbHabPJ1 = new System.Windows.Forms.ComboBox();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lstCaracteristicas = new System.Windows.Forms.ListBox();
            this.gbJugador2.SuspendLayout();
            this.gbJugador1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbJugador2
            // 
            this.gbJugador2.BackColor = System.Drawing.Color.Transparent;
            this.gbJugador2.Controls.Add(this.label4);
            this.gbJugador2.Controls.Add(this.label2);
            this.gbJugador2.Controls.Add(this.cmbClasePJ2);
            this.gbJugador2.Controls.Add(this.btnElegirPJ2);
            this.gbJugador2.Controls.Add(this.cmbHabPJ2);
            this.gbJugador2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbJugador2.Location = new System.Drawing.Point(269, 9);
            this.gbJugador2.Name = "gbJugador2";
            this.gbJugador2.Size = new System.Drawing.Size(247, 135);
            this.gbJugador2.TabIndex = 18;
            this.gbJugador2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Selecciona una habilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Selecciona una clase";
            // 
            // cmbClasePJ2
            // 
            this.cmbClasePJ2.FormattingEnabled = true;
            this.cmbClasePJ2.Location = new System.Drawing.Point(13, 31);
            this.cmbClasePJ2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClasePJ2.Name = "cmbClasePJ2";
            this.cmbClasePJ2.Size = new System.Drawing.Size(102, 21);
            this.cmbClasePJ2.TabIndex = 1;
            this.cmbClasePJ2.SelectedIndexChanged += new System.EventHandler(this.cmbClasePJ2_SelectedIndexChanged);
            // 
            // btnElegirPJ2
            // 
            this.btnElegirPJ2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnElegirPJ2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnElegirPJ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirPJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirPJ2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnElegirPJ2.Location = new System.Drawing.Point(161, 98);
            this.btnElegirPJ2.Margin = new System.Windows.Forms.Padding(2);
            this.btnElegirPJ2.Name = "btnElegirPJ2";
            this.btnElegirPJ2.Size = new System.Drawing.Size(81, 32);
            this.btnElegirPJ2.TabIndex = 7;
            this.btnElegirPJ2.Text = "Elegir";
            this.btnElegirPJ2.UseVisualStyleBackColor = false;
            this.btnElegirPJ2.Click += new System.EventHandler(this.btnElegirPJ2_Click);
            // 
            // cmbHabPJ2
            // 
            this.cmbHabPJ2.Enabled = false;
            this.cmbHabPJ2.FormattingEnabled = true;
            this.cmbHabPJ2.Location = new System.Drawing.Point(23, 78);
            this.cmbHabPJ2.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHabPJ2.Name = "cmbHabPJ2";
            this.cmbHabPJ2.Size = new System.Drawing.Size(126, 21);
            this.cmbHabPJ2.TabIndex = 11;
            this.cmbHabPJ2.SelectedIndexChanged += new System.EventHandler(this.cmbHabPJ2_SelectedIndexChanged);
            // 
            // gbJugador1
            // 
            this.gbJugador1.BackColor = System.Drawing.Color.Transparent;
            this.gbJugador1.Controls.Add(this.label3);
            this.gbJugador1.Controls.Add(this.label1);
            this.gbJugador1.Controls.Add(this.cmbClasePJ1);
            this.gbJugador1.Controls.Add(this.btnElegirPJ1);
            this.gbJugador1.Controls.Add(this.cmbHabPJ1);
            this.gbJugador1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbJugador1.Location = new System.Drawing.Point(10, 9);
            this.gbJugador1.Name = "gbJugador1";
            this.gbJugador1.Size = new System.Drawing.Size(247, 135);
            this.gbJugador1.TabIndex = 17;
            this.gbJugador1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selecciona una habilidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selecciona una clase";
            // 
            // cmbClasePJ1
            // 
            this.cmbClasePJ1.FormattingEnabled = true;
            this.cmbClasePJ1.Location = new System.Drawing.Point(14, 31);
            this.cmbClasePJ1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbClasePJ1.Name = "cmbClasePJ1";
            this.cmbClasePJ1.Size = new System.Drawing.Size(102, 21);
            this.cmbClasePJ1.TabIndex = 0;
            this.cmbClasePJ1.SelectedIndexChanged += new System.EventHandler(this.cmbClasePJ1_SelectedIndexChanged);
            // 
            // btnElegirPJ1
            // 
            this.btnElegirPJ1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnElegirPJ1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnElegirPJ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirPJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnElegirPJ1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnElegirPJ1.Location = new System.Drawing.Point(161, 98);
            this.btnElegirPJ1.Margin = new System.Windows.Forms.Padding(2);
            this.btnElegirPJ1.Name = "btnElegirPJ1";
            this.btnElegirPJ1.Size = new System.Drawing.Size(81, 32);
            this.btnElegirPJ1.TabIndex = 6;
            this.btnElegirPJ1.Text = "Elegir";
            this.btnElegirPJ1.UseVisualStyleBackColor = false;
            this.btnElegirPJ1.Click += new System.EventHandler(this.btnElegirPJ1_Click);
            // 
            // cmbHabPJ1
            // 
            this.cmbHabPJ1.Enabled = false;
            this.cmbHabPJ1.FormattingEnabled = true;
            this.cmbHabPJ1.Location = new System.Drawing.Point(24, 78);
            this.cmbHabPJ1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHabPJ1.Name = "cmbHabPJ1";
            this.cmbHabPJ1.Size = new System.Drawing.Size(126, 21);
            this.cmbHabPJ1.TabIndex = 10;
            this.cmbHabPJ1.SelectedIndexChanged += new System.EventHandler(this.cmbHabPJ1_SelectedIndexChanged);
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.Transparent;
            this.picImagen.Location = new System.Drawing.Point(10, 149);
            this.picImagen.Margin = new System.Windows.Forms.Padding(2);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(147, 198);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagen.TabIndex = 16;
            this.picImagen.TabStop = false;
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnJugar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJugar.FlatAppearance.BorderSize = 2;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Bradley Hand ITC", 18F, System.Drawing.FontStyle.Bold);
            this.btnJugar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJugar.Location = new System.Drawing.Point(257, 298);
            this.btnJugar.Margin = new System.Windows.Forms.Padding(2);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(190, 64);
            this.btnJugar.TabIndex = 15;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lstCaracteristicas
            // 
            this.lstCaracteristicas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstCaracteristicas.FormattingEnabled = true;
            this.lstCaracteristicas.HorizontalScrollbar = true;
            this.lstCaracteristicas.Location = new System.Drawing.Point(161, 174);
            this.lstCaracteristicas.Margin = new System.Windows.Forms.Padding(2);
            this.lstCaracteristicas.Name = "lstCaracteristicas";
            this.lstCaracteristicas.Size = new System.Drawing.Size(352, 108);
            this.lstCaracteristicas.TabIndex = 14;
            // 
            // frmSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::pryJuegoTpLab2.Properties.Resources.prueba2;
            this.ClientSize = new System.Drawing.Size(527, 370);
            this.Controls.Add(this.gbJugador2);
            this.Controls.Add(this.gbJugador1);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.lstCaracteristicas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medieval";
            this.gbJugador2.ResumeLayout(false);
            this.gbJugador2.PerformLayout();
            this.gbJugador1.ResumeLayout(false);
            this.gbJugador1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbJugador2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClasePJ2;
        private System.Windows.Forms.Button btnElegirPJ2;
        private System.Windows.Forms.ComboBox cmbHabPJ2;
        private System.Windows.Forms.GroupBox gbJugador1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClasePJ1;
        private System.Windows.Forms.Button btnElegirPJ1;
        private System.Windows.Forms.ComboBox cmbHabPJ1;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.ListBox lstCaracteristicas;
    }
}