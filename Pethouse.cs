using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pethouse
{
    class Pethouse
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string celular { get; set; }
        public string dataadmissao { get; set; }
        public string genero { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\pethouse\\DBPethouse.mdf;Integrated Security=True");

        public void InserirFunc(string nome, string login, string senha, string celular, string dataadmissao, string genero)
        {
            string sql = "INSERT INTO Funcionarios(nome,login,senha,celular,dataadmissao,genero) VALUES ('" + nome + "','" + login + "','" + senha + "','" + celular + "','" + dataadmissao + "','" + genero + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //codificar
        public string Base64Encode(string textoencode)
        {
            var textoencodebytes = System.Text.Encoding.UTF8.GetBytes(textoencode);
            return System.Convert.ToBase64String(textoencodebytes);
        }
        //decodificar
        public string Base64Decode(string textodecode)
        {
            var textodecodebytes = System.Convert.FromBase64String(textodecode);
            return System.Text.Encoding.UTF8.GetString(textodecodebytes);
        }

        public List<Pethouse> listafuncionario()
        {
            List<Pethouse> li = new List<Pethouse>();
            string sql = "SELECT * FROM Funcionarios";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Pethouse f = new Pethouse();
                f.Id = Convert.ToInt32(dr["Id"]);
                f.nome = dr["nome"].ToString();
                f.login = dr["login"].ToString();
                f.senha = dr["senha"].ToString();
                f.celular = dr["celular"].ToString();
                f.dataadmissao = dr["dataadmissao"].ToString();
                f.genero = dr["genero"].ToString();
                li.Add(f);
            }
            return li;
        }

        public void ExcluirFunc(int id)
        {
            string sql = "DELETE FROM Funcionarios WHERE Id = '" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void LocalizaFunc(int id)
        {
            con.Open();
            string sql = "SELECT * FROM Funcionarios WHERE Id = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            string data = Convert.ToString(dataadmissao);
            while (dr.Read())
            {
                Id = Convert.ToInt32(dr["Id"]);
                nome = dr["nome"].ToString();
                login = dr["login"].ToString();
                senha = dr["senha"].ToString();
                celular = dr["celular"].ToString();
                dataadmissao = dr["dataadmissao"].ToString();
                genero = dr["genero"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public void AtualizarFunc(int id, string nome, string login, string senha, string celular, string dataadmissao, string genero)
        {
            string sql = "UPDATE Funcionario SET nome='" + nome + "',login='" + login + "',senha='" + senha + "',celular='" + celular + "',dataadmissao='" + dataadmissao + "',genero='" + genero + "' WHERE Id='" + id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}