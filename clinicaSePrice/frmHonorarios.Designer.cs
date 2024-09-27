namespace clinicaSePrice
{
    partial class frmHonorarios
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
            lblHonorarios = new Label();
            SuspendLayout();
            // 
            // lblHonorarios
            // 
            lblHonorarios.Anchor = AnchorStyles.None;
            lblHonorarios.AutoSize = true;
            lblHonorarios.Location = new Point(373, 172);
            lblHonorarios.Name = "lblHonorarios";
            lblHonorarios.Size = new Size(104, 20);
            lblHonorarios.TabIndex = 0;
            lblHonorarios.Text = "HONORARIOS";
            // 
            // frmHonorarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHonorarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmHonorarios";
            Text = "frmHonorarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHonorarios;
    }
}