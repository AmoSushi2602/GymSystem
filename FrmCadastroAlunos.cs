using GymSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

    namespace GymSystem
    {
        public partial class FrmCadastroAlunos : Form
        {
            public FrmCadastroAlunos()
            {
                InitializeComponent();
            }

            private void btnSalvar_Click(object sender, EventArgs e)
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Alunos (Nome, CPF, DataNascimento, Telefone) VALUES (@n, @c, @d, @t)",
                    con.AbrirConexao());

                cmd.Parameters.AddWithValue("@n", txtNome.Text);
                cmd.Parameters.AddWithValue("@c", txtCPF.Text);
                cmd.Parameters.AddWithValue("@d", dtNascimento.Value);
                cmd.Parameters.AddWithValue("@t", txtTelefone.Text);
            

                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno cadastrado com sucesso!");

                con.FecharConexao();
            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }
    }
    }
