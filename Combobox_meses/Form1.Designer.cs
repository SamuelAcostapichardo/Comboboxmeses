namespace Combobox_meses
{
    partial class Form1
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
            this.CmbMeses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CmbMeses
            // 
            this.CmbMeses.FormattingEnabled = true;
            this.CmbMeses.Location = new System.Drawing.Point(60, 36);
            this.CmbMeses.Name = "CmbMeses";
            this.CmbMeses.Size = new System.Drawing.Size(121, 21);
            this.CmbMeses.TabIndex = 0;
            this.CmbMeses.Text = "Enero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 336);
            this.Controls.Add(this.CmbMeses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbMeses;
    }
}

