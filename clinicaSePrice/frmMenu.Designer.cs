namespace clinicaSePrice
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            pnlMenuVertical = new Panel();
            btnHistoriaClinica = new Button();
            btnHonorarios = new Button();
            btnAgenda = new Button();
            btnTurnos = new Button();
            btnPacientes = new Button();
            lblClinica = new Label();
            lblSePrice = new Label();
            picLogo = new PictureBox();
            pnlTop = new Panel();
            lblRol = new Label();
            lblNombre = new Label();
            picUsuarioLogueado = new PictureBox();
            pnlContenedor = new Panel();
            pnlMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUsuarioLogueado).BeginInit();
            SuspendLayout();
            // 
            // pnlMenuVertical
            // 
            pnlMenuVertical.BackColor = Color.FromArgb(100, 97, 129);
            pnlMenuVertical.Controls.Add(btnHistoriaClinica);
            pnlMenuVertical.Controls.Add(btnHonorarios);
            pnlMenuVertical.Controls.Add(btnAgenda);
            pnlMenuVertical.Controls.Add(btnTurnos);
            pnlMenuVertical.Controls.Add(btnPacientes);
            pnlMenuVertical.Controls.Add(lblClinica);
            pnlMenuVertical.Controls.Add(lblSePrice);
            pnlMenuVertical.Controls.Add(picLogo);
            pnlMenuVertical.Dock = DockStyle.Left;
            pnlMenuVertical.Location = new Point(0, 0);
            pnlMenuVertical.Name = "pnlMenuVertical";
            pnlMenuVertical.Size = new Size(250, 703);
            pnlMenuVertical.TabIndex = 0;
            // 
            // btnHistoriaClinica
            // 
            btnHistoriaClinica.FlatAppearance.BorderSize = 0;
            btnHistoriaClinica.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 64, 86);
            btnHistoriaClinica.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 64, 86);
            btnHistoriaClinica.FlatStyle = FlatStyle.Flat;
            btnHistoriaClinica.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHistoriaClinica.ForeColor = Color.White;
            btnHistoriaClinica.Image = (Image)resources.GetObject("btnHistoriaClinica.Image");
            btnHistoriaClinica.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistoriaClinica.Location = new Point(1, 340);
            btnHistoriaClinica.Name = "btnHistoriaClinica";
            btnHistoriaClinica.Size = new Size(250, 41);
            btnHistoriaClinica.TabIndex = 7;
            btnHistoriaClinica.Text = "Historia Clinica";
            btnHistoriaClinica.UseVisualStyleBackColor = true;
            btnHistoriaClinica.Click += btnHistoriaClinica_Click;
            // 
            // btnHonorarios
            // 
            btnHonorarios.FlatAppearance.BorderSize = 0;
            btnHonorarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 64, 86);
            btnHonorarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 64, 86);
            btnHonorarios.FlatStyle = FlatStyle.Flat;
            btnHonorarios.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHonorarios.ForeColor = Color.White;
            btnHonorarios.Image = (Image)resources.GetObject("btnHonorarios.Image");
            btnHonorarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnHonorarios.Location = new Point(0, 290);
            btnHonorarios.Name = "btnHonorarios";
            btnHonorarios.Size = new Size(250, 41);
            btnHonorarios.TabIndex = 6;
            btnHonorarios.Text = "Honorarios";
            btnHonorarios.UseVisualStyleBackColor = true;
            btnHonorarios.Click += btnHonorarios_Click;
            // 
            // btnAgenda
            // 
            btnAgenda.FlatAppearance.BorderSize = 0;
            btnAgenda.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 64, 86);
            btnAgenda.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 64, 86);
            btnAgenda.FlatStyle = FlatStyle.Flat;
            btnAgenda.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgenda.ForeColor = Color.White;
            btnAgenda.Image = (Image)resources.GetObject("btnAgenda.Image");
            btnAgenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgenda.Location = new Point(1, 239);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(250, 41);
            btnAgenda.TabIndex = 5;
            btnAgenda.Text = "Agenda";
            btnAgenda.UseVisualStyleBackColor = true;
            btnAgenda.Click += btnAgenda_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.FlatAppearance.BorderSize = 0;
            btnTurnos.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 64, 86);
            btnTurnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 64, 86);
            btnTurnos.FlatStyle = FlatStyle.Flat;
            btnTurnos.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTurnos.ForeColor = Color.White;
            btnTurnos.Image = (Image)resources.GetObject("btnTurnos.Image");
            btnTurnos.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurnos.Location = new Point(0, 190);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Size = new Size(250, 41);
            btnTurnos.TabIndex = 4;
            btnTurnos.Text = "Turnos";
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 64, 86);
            btnPacientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(66, 64, 86);
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPacientes.ForeColor = Color.White;
            btnPacientes.Image = (Image)resources.GetObject("btnPacientes.Image");
            btnPacientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnPacientes.Location = new Point(2, 141);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Size = new Size(250, 41);
            btnPacientes.TabIndex = 3;
            btnPacientes.Text = "Pacientes";
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // lblClinica
            // 
            lblClinica.AutoSize = true;
            lblClinica.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinica.ForeColor = Color.White;
            lblClinica.Location = new Point(105, 26);
            lblClinica.Name = "lblClinica";
            lblClinica.Size = new Size(104, 32);
            lblClinica.TabIndex = 1;
            lblClinica.Text = "CLÍNICA";
            // 
            // lblSePrice
            // 
            lblSePrice.AutoSize = true;
            lblSePrice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSePrice.ForeColor = Color.White;
            lblSePrice.Location = new Point(106, 53);
            lblSePrice.Name = "lblSePrice";
            lblSePrice.Size = new Size(91, 32);
            lblSePrice.TabIndex = 2;
            lblSePrice.Text = "SePrice";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(25, 23);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(85, 66);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.WhiteSmoke;
            pnlTop.Controls.Add(lblRol);
            pnlTop.Controls.Add(lblNombre);
            pnlTop.Controls.Add(picUsuarioLogueado);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(250, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1082, 50);
            pnlTop.TabIndex = 1;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.FromArgb(33, 32, 43);
            lblRol.Location = new Point(860, 29);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(107, 20);
            lblRol.TabIndex = 1;
            lblRol.Text = "Administrador";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(855, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(112, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Lucrecia Duarte";
            // 
            // picUsuarioLogueado
            // 
            picUsuarioLogueado.Image = (Image)resources.GetObject("picUsuarioLogueado.Image");
            picUsuarioLogueado.Location = new Point(978, 3);
            picUsuarioLogueado.Name = "picUsuarioLogueado";
            picUsuarioLogueado.Size = new Size(60, 50);
            picUsuarioLogueado.SizeMode = PictureBoxSizeMode.Zoom;
            picUsuarioLogueado.TabIndex = 0;
            picUsuarioLogueado.TabStop = false;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(250, 50);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1082, 653);
            pnlContenedor.TabIndex = 2;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 703);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlTop);
            Controls.Add(pnlMenuVertical);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(1350, 750);
            MinimizeBox = false;
            MinimumSize = new Size(1350, 750);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            Load += Menu_Load;
            pnlMenuVertical.ResumeLayout(false);
            pnlMenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUsuarioLogueado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuVertical;
        private Panel pnlTop;
        private Panel pnlContenedor;
        private PictureBox picUsuarioLogueado;
        private Label lblNombre;
        private Label lblRol;
        private PictureBox picLogo;
        private Label lblClinica;
        private Label lblSePrice;
        private Button btnPacientes;
        private Button btnHistoriaClinica;
        private Button btnHonorarios;
        private Button btnAgenda;
        private Button btnTurnos;
    }
}
