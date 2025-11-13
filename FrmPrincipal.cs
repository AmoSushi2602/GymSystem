using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show(
                "Deseja realmente sair do sistema?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
                Application.Exit();
        }
        private void BtnCadastroAlunos_Click(object sender, EventArgs e)
            {
            foreach(Form form in this.MdiChildren)
            {
                if (form is FrmCadastroAlunos)
                {
                form.Activate();
                    return;
                }
            }
            
            FrmCadastroAlunos frm = new FrmCadastroAlunos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gymSystemDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.gymSystemDataSet.Alunos);
            // TODO: esta linha de código carrega dados na tabela 'gymSystemDataSet.Usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.gymSystemDataSet.Usuarios);

            // define o wallpaper do sistema
            this.BackgroundImage = Properties.Resources.fundo;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // cor base caso nao preencha toda a tela
            this.BackColor = Color.Black;
        }

        private void UsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gymSystemDataSet);

        }

        private void UsuariosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void AlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmAlunos)
                {
                    form.Activate();
                    return;
                }
            }


            FrmAlunos frm = new FrmAlunos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}

