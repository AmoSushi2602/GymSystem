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
            try
            {
                // 1 - Desabilita constraints do DataSet inteiro
                this.gymSystemDataSet.EnforceConstraints = false;

                // 2 - Carrega as tabelas NA ORDEM CORRETA
                this.usuariosTableAdapter.Fill(this.gymSystemDataSet.Usuarios);
                this.alunosTableAdapter.Fill(this.gymSystemDataSet.Alunos);

                // 3 - Reativa constraints (vai disparar erro se houver algo inconsistente)
                this.gymSystemDataSet.EnforceConstraints = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar DataSet:\n\n" + ex);
            }

            // wallpaper e layout
            this.BackgroundImage = Properties.Resources.fundo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

