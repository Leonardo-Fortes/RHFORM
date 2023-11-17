using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRhForm.Dal
{
    internal class EmpresaDaoComandos
    {
        public int num = 0;
        SqlDataReader dr; // leitor do banco
        SqlCommand cmd = new SqlCommand();
        public bool tem = false;
        public string msg = "";
        Conexao con = new Conexao();

        public string cadastrarEmp(string nome, string cnpj, string rua, string numero, string bairro, string cidade, string uf, string pais, string cep)
        {
            tem = false;
            cmd.CommandText = "insert into Empresa values (@nome,@cnpj,@rua,@numero,@bairro,@cidade,@uf,@pais,@cep)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@uf", uf);
            cmd.Parameters.AddWithValue("@pais", pais);
            cmd.Parameters.AddWithValue("@cep", cep);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();
                tem = true;
            }
            catch (SqlException e)
            {

                this.msg = "erro com o banco" + e;
            }
            return msg;
        }
    }
}
