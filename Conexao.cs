using GymSystem;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymSystem
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);

        public SqlConnection AbrirConexao()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            return con;
        }
        public void FecharConexao()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

    }
}
