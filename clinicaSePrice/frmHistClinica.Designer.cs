namespace clinicaSePrice
{
    partial class frmHistClinica
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
            if (disposing && (components != null)) {
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
            lblHistClinica = new Label();
            SuspendLayout();
            // 
            // lblHistClinica
            // 
            lblHistClinica.Anchor = AnchorStyles.None;
            lblHistClinica.AutoSize = true;
            lblHistClinica.Location = new Point(300, 192);
            lblHistClinica.Name = "lblHistClinica";
            lblHistClinica.Size = new Size(131, 20);
            lblHistClinica.TabIndex = 0;
            lblHistClinica.Text = "HISTORIA CLÍNICA";
            // 
            // frmHistClinica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHistClinica);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHistClinica";
            Text = "frmHistClinica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHistClinica;
    }
}