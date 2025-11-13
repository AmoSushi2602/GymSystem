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

        private void FrmAlunos_Load(object sender, EventArgs e)
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
                DgvAlunos.DataSource = dt;
                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            MostrarAlunos();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (DgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para excluir!");
                return;
            }


            int id = Convert.ToInt32(DgvAlunos.SelectedRows[0].Cells["Id"].Value);
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
    
          private void DgvAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // garante que clicou em uma linha válida
            {
                if (DgvAlunos.CurrentRow != null)
                {
                    int id = Convert.ToInt32(DgvAlunos.Rows[e.RowIndex].Cells["Id"].Value);
                    string nome = DgvAlunos.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                    string cpf = DgvAlunos.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                    string telefone = DgvAlunos.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();

                    // abre o formulário de edição e passa os dados
                    FrmEditarAlunos frm = new FrmEditarAlunos(id, nome, cpf, telefone);
                    frm.ShowDialog();

                    // após fechar o form de edição, atualiza a lista
                    MostrarAlunos();
                }
            }
        }

    }    
}
