using iTasks.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks
{
    public partial class frmGereUtilizadores : Form
    {
        public frmGereUtilizadores()
        {
            InitializeComponent();
        }
        private UtController controller = new UtController();

        private void btGravarGestor_Click(object sender, EventArgs e)
        {
            utilizador.Departamento departamento = (utilizador.Departamento)cbDepartamento.SelectedItem;

            controller.AdicionarGestor(
                txtNomeGestor.Text,
                txtUsernameGestor.Text,
                txtPasswordGestor.Text,
                departamento);
            MessageBox.Show("Gestor guardado com sucesso!");
        }

        private void btGravarProg_Click(object sender, EventArgs e)
        {
            // Conversão dos itens do ComboBox para os enums e obtenção do ID do gestor selecionado
            utilizador.NivelExp nivelExp = (utilizador.NivelExp)cbNivelProg.SelectedItem;
            int gestorId = (int)cbGestorProg.SelectedValue; // assumindo que cmbGestor está preenchido com os gestores

            controller.AdicionarProgramador(
                txtNomeProg.Text,
                txtUsernameProg.Text,
                txtPasswordProg.Text,
                nivelExp,
                gestorId);

            MessageBox.Show("Programador guardado com sucesso!");
        }
    }
}
