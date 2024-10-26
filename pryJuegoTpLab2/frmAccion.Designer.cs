namespace pryJuegoTpLab2
{
    partial class frmAccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccion));
            this.btnAtBasico = new System.Windows.Forms.Button();
            this.btn4PJ1 = new System.Windows.Forms.Button();
            this.btnAtEspecial = new System.Windows.Forms.Button();
            this.btnRecup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtBasico
            // 
            this.btnAtBasico.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAtBasico.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAtBasico.FlatAppearance.BorderSize = 2;
            this.btnAtBasico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtBasico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtBasico.Location = new System.Drawing.Point(18, 42);
            this.btnAtBasico.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtBasico.Name = "btnAtBasico";
            this.btnAtBasico.Size = new System.Drawing.Size(101, 36);
            this.btnAtBasico.TabIndex = 6;
            this.btnAtBasico.Text = "Ataque Basico";
            this.btnAtBasico.UseVisualStyleBackColor = false;
            this.btnAtBasico.Click += new System.EventHandler(this.btnAtBasico_Click);
            // 
            // btn4PJ1
            // 
            this.btn4PJ1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn4PJ1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn4PJ1.FlatAppearance.BorderSize = 2;
            this.btn4PJ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4PJ1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn4PJ1.Location = new System.Drawing.Point(132, 91);
            this.btn4PJ1.Margin = new System.Windows.Forms.Padding(2);
            this.btn4PJ1.Name = "btn4PJ1";
            this.btn4PJ1.Size = new System.Drawing.Size(101, 36);
            this.btn4PJ1.TabIndex = 7;
            this.btn4PJ1.Text = "Critico";
            this.btn4PJ1.UseVisualStyleBackColor = false;
            // 
            // btnAtEspecial
            // 
            this.btnAtEspecial.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAtEspecial.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnAtEspecial.FlatAppearance.BorderSize = 2;
            this.btnAtEspecial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtEspecial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtEspecial.Location = new System.Drawing.Point(18, 91);
            this.btnAtEspecial.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtEspecial.Name = "btnAtEspecial";
            this.btnAtEspecial.Size = new System.Drawing.Size(101, 36);
            this.btnAtEspecial.TabIndex = 8;
            this.btnAtEspecial.Text = "A. Especial";
            this.btnAtEspecial.UseVisualStyleBackColor = false;
            this.btnAtEspecial.Click += new System.EventHandler(this.btnAtEspecial_Click);
            // 
            // btnRecup
            // 
            this.btnRecup.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRecup.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRecup.FlatAppearance.BorderSize = 2;
            this.btnRecup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecup.Location = new System.Drawing.Point(132, 42);
            this.btnRecup.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecup.Name = "btnRecup";
            this.btnRecup.Size = new System.Drawing.Size(101, 36);
            this.btnRecup.TabIndex = 9;
            this.btnRecup.Text = "Recuperacion";
            this.btnRecup.UseVisualStyleBackColor = false;
            this.btnRecup.Click += new System.EventHandler(this.btnRecup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtBasico);
            this.groupBox1.Controls.Add(this.btnRecup);
            this.groupBox1.Controls.Add(this.btn4PJ1);
            this.groupBox1.Controls.Add(this.btnAtEspecial);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 152);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel de accion";
            // 
            // frmAccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccion";
            this.Text = "Realizar Ataque";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtBasico;
        private System.Windows.Forms.Button btn4PJ1;
        private System.Windows.Forms.Button btnAtEspecial;
        private System.Windows.Forms.Button btnRecup;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}