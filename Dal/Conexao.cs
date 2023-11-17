using System;
using System.Data.SqlClient;

namespace ProjetoRhForm.Dal
{
   public  class Conexao
    {
        SqlConnection con = new SqlConnection();

        public  Conexao()
        {
            con.ConnectionString = @"Password=sa4321!;Persist Security Info=True;User ID=sa;Initial Catalog=rh_pim;Data Source=SERVER\SQLEXPRESS";
        }
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
