namespace clinicaSePrice
{
    partial class frmTurnos
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
            lblTurnos = new Label();
            SuspendLayout();
            // 
            // lblTurnos
            // 
            lblTurnos.Anchor = AnchorStyles.None;
            lblTurnos.AutoSize = true;
            lblTurnos.Location = new Point(359, 210);
            lblTurnos.Name = "lblTurnos";
            lblTurnos.Size = new Size(66, 20);
            lblTurnos.TabIndex = 0;
            lblTurnos.Text = "TURNOS";
            // 
            // frmTurnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTurnos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmTurnos";
            Text = "frmTurnos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTurnos;
    }
}