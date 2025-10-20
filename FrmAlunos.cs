using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymSystem;

namespace GymSystem
{
    public partial class FrmAlunos : Form
    {
        public FrmAlunos()
        {
            InitializeComponent();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            MostrarAlunos();
        }
        private void MostrarAlunos()
        {
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand("Select * from Alunos", con.AbrirConexao());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAlunos.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MostrarAlunos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para excluir!");
                return;
            }


            int id = Convert.ToInt32(dgvAlunos.SelectedRows[0].Cells["Id"].Value);
            var confirmar = MessageBox.Show("Deseja realmente excluir este aluno?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                try
                {
                    Conexao con = new Conexao();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Alunos WHERE Id = @id", con.AbrirConexao());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.FecharConexao();
                    MessageBox.Show("Aluno excluído com sucesso!");
                    MostrarAlunos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir: " + ex.Message);

                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para editar!");
                return;
            }
            
            int id = Convert.ToInt32(dgvAlunos.SelectedRows[0].Cells["Id"].Value);
            string nome = dgvAlunos.SelectedRows[0].Cells["Nome"].Value.ToString();
            string cpf = dgvAlunos.SelectedRows[0].Cells["CPF"].Value.ToString();
            string telefone = dgvAlunos.SelectedRows[0].Cells["Telefone"].Value.ToString();

            // Aqui você pode abrir a tela de edição
            FrmAlunos frm = new FrmAlunos();
            frm.txtNome.text = nome;
            frm.txtCPF.Text = cpf;
            frm.txtTelefone.Text = telefone;
            frm.ShowDialog();

            // Depois de editar, recarregar a lista
            MostrarAlunos();
        }
    }
}
