using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Verifica se os campos estão vazios
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@u AND Senha=@s",
                    con.AbrirConexao());

                cmd.Parameters.AddWithValue("@u", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@s", txtSenha.Text);

                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    MessageBox.Show("Login Bem-Sucedido!");
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.FecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
