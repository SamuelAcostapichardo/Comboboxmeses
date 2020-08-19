namespace Combobox_meses
{
    partial class FormFechas
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
            this.cmbinicio = new System.Windows.Forms.ComboBox();
            this.cmbfin = new System.Windows.Forms.ComboBox();
            this.Btncalcular = new System.Windows.Forms.Button();
            this.Txtresultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbinicio
            // 
            this.cmbinicio.FormattingEnabled = true;
            this.cmbinicio.Location = new System.Drawing.Point(74, 48);
            this.cmbinicio.Name = "cmbinicio";
            this.cmbinicio.Size = new System.Drawing.Size(121, 21);
            this.cmbinicio.TabIndex = 0;
            // 
            // cmbfin
            // 
            this.cmbfin.FormattingEnabled = true;
            this.cmbfin.Location = new System.Drawing.Point(74, 102);
            this.cmbfin.Name = "cmbfin";
            this.cmbfin.Size = new System.Drawing.Size(121, 21);
            this.cmbfin.TabIndex = 1;
            // 
            // Btncalcular
            // 
            this.Btncalcular.Location = new System.Drawing.Point(74, 152);
            this.Btncalcular.Name = "Btncalcular";
            this.Btncalcular.Size = new System.Drawing.Size(75, 23);
            this.Btncalcular.TabIndex = 2;
            this.Btncalcular.Text = "calcular";
            this.Btncalcular.UseVisualStyleBackColor = true;
            this.Btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // Txtresultado
            // 
            this.Txtresultado.Location = new System.Drawing.Point(290, 155);
            this.Txtresultado.Name = "Txtresultado";
            this.Txtresultado.Size = new System.Drawing.Size(100, 20);
            this.Txtresultado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "La diferencia es:";
            // 
            // FormFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtresultado);
            this.Controls.Add(this.Btncalcular);
            this.Controls.Add(this.cmbfin);
            this.Controls.Add(this.cmbinicio);
            this.Name = "FormFechas";
            this.Text = "FormFechas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbinicio;
        private System.Windows.Forms.ComboBox cmbfin;
        private System.Windows.Forms.Button Btncalcular;
        private System.Windows.Forms.TextBox Txtresultado;
        private System.Windows.Forms.Label label1;
    }
}