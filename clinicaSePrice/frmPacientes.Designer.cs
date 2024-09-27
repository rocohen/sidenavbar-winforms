namespace clinicaSePrice
{
    partial class frmPacientes
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
            lblPacTitulo = new Label();
            SuspendLayout();
            // 
            // lblPacTitulo
            // 
            lblPacTitulo.Anchor = AnchorStyles.None;
            lblPacTitulo.AutoSize = true;
            lblPacTitulo.Location = new Point(348, 216);
            lblPacTitulo.Name = "lblPacTitulo";
            lblPacTitulo.Size = new Size(82, 20);
            lblPacTitulo.TabIndex = 0;
            lblPacTitulo.Text = "PACIENTES";
            // 
            // frmPacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 495);
            Controls.Add(lblPacTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPacientes";
            Text = "PACIENTES";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPacTitulo;
    }
}