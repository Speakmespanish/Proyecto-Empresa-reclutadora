using Capa_Presentacion.Controles_usuarios;

namespace Capa_Presentacion
{
    public partial class Inicio : Form
    {
        //Declaracion de controles de usuarios
        private VerCandidatos vistaCandidatos;
        private RegistrarCandidato registroCandidato;
        private VerVacantes vistaVacantes;
        private RegistrarVacante registroVacante;
        private InformacionInicial informacionInicial;

        public Inicio()
        {

            //Cargar Controles de usuarios
            vistaCandidatos = new VerCandidatos();
            registroCandidato = new RegistrarCandidato();
            vistaVacantes = new VerVacantes();
            registroVacante = new RegistrarVacante();
            informacionInicial = new InformacionInicial();

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(informacionInicial);
            informacionInicial.Dock = DockStyle.Fill;
            informacionInicial.Show();
        }

        private void btnRegistrarVacante_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(registroVacante);
            registroVacante.Dock = DockStyle.Fill;
            registroVacante.Show();
        }

        private void btnVerVacantes_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(vistaVacantes);
            vistaVacantes.Dock = DockStyle.Fill;
            vistaVacantes.Show();
        }

        private void btnRegistrarCandidato_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(registroCandidato);
            registroCandidato.Dock = DockStyle.Fill;
            registroCandidato.Show();
        }

        private void btnVerCandidatos_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(vistaCandidatos);
            vistaCandidatos.Dock = DockStyle.Fill;
            vistaCandidatos.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio_Load(sender, EventArgs.Empty);
        }
    }
}