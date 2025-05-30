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

        private void btGravarGestor_Click(object sender, EventArgs e)
        {
            Gestor g = new Gestor
            {
                Nome = txtNomeGestor.Text,
                Username = txtUsernameGestor.Text,
                Password = txtPasswordGestor.Text,
                Departamento = (Departamento)cbDepartamento.SelectedItem
            };

            var controller = new UtController();
            
            controller.AdicionarGestor(g);

            MessageBox.Show("Dados gravados");
        }

        private void btGravarProg_Click(object sender, EventArgs e)
        {
            Programador p = new Programador
            {
                Nome = txtNomeGestor.Text,
                Username = txtUsernameGestor.Text,
                Password = txtPasswordGestor.Text,
                NivelExperiencia = (NivelExp)cbNivelProg.SelectedItem,
                GestorId = (int)cbGestorProg.SelectedValue
            };

            var controller = new UtController();

            controller.AdicionarProgramador(p);

            MessageBox.Show("Dados gravados");
        }
    }
}
