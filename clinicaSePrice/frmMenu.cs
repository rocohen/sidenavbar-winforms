namespace clinicaSePrice
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmPacientes>();
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmTurnos>();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAgenda>();
        }

        private void btnHonorarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmHonorarios>();
        }

        private void btnHistoriaClinica_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmHistClinica>();
        }

        //Método para abrir formularios dentro del panel contenedor
        private void AbrirFormulario<InstanciaForm>() where InstanciaForm : Form, new()
        {
            Form formulario;
            formulario = pnlContenedor.Controls.OfType<InstanciaForm>().FirstOrDefault()!;
            // Si el formulario instancia no existe se crea uno
            if (formulario == null) {
                formulario = new InstanciaForm();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                pnlContenedor.Controls.Add(formulario);
                pnlContenedor.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            // Si el formulario instancia existe lo traemos al frente
            else {
                formulario.BringToFront();
            }
        }



    }
}
