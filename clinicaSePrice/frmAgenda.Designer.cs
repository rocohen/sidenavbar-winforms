namespace clinicaSePrice
{
    partial class frmAgenda
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
            lblAgenda = new Label();
            SuspendLayout();
            // 
            // lblAgenda
            // 
            lblAgenda.Anchor = AnchorStyles.None;
            lblAgenda.AutoSize = true;
            lblAgenda.Location = new Point(350, 194);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(69, 20);
            lblAgenda.TabIndex = 0;
            lblAgenda.Text = "AGENDA";
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAgenda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAgenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgenda;
    }
}