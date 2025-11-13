using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FrmEditarAlunos : Form
    {
        private int alunoId; // guarda o ID do aluno que veio do outro form

        public FrmEditarAlunos(int id, string nome, string cpf, string telefone)
        {
            InitializeComponent();

            alunoId = id;
            txtNome.Text = nome;
            txtCPF.Text = cpf;
            txtTelefone.Text = telefone;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Alunos SET Nome=@n, CPF=@c, Telefone=@t WHERE Id=@id",
                    con.AbrirConexao());

                cmd.Parameters.AddWithValue("@n", txtNome.Text);
                cmd.Parameters.AddWithValue("@c", txtCPF.Text);
                cmd.Parameters.AddWithValue("@t", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@id", alunoId);

                cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Aluno atualizado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
