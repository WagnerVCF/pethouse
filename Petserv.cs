using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace petserv
{
    class Petserv
    {
        public int Id { get; set; }
        public string servico { get; set; }
        public string preco { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\pethouse\\DBPethouse.mdf;Integrated Security=True");

        public void InserirServ(string servico, string preco)
        {
            string sql = "INSERT INTO Serviços(servico,preco) VALUES ('" + servico + "','" + preco + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<Petserv> listaservico()
        {
            List<Petserv> li = new List<Petserv>();
            string sql = "SELECT * FROM Serviços";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Petserv f = new Petserv();
                f.Id = Convert.ToInt32(dr["Id"]);
                f.servico = dr["servico"].ToString();
                f.preco = dr["preco"].ToString();
            }
            return li;
        }

        public void ExcluirFunc(int id)
        {
            string sql = "DELETE FROM Serviços WHERE Id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}