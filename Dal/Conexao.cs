using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRhForm.Dal
{
   public  class Conexao
    {
        SqlConnection con = new SqlConnection();

        public  Conexao()
        {
            con.ConnectionString = @"Password=sa1234;Persist Security Info=True;User ID=sa;Initial Catalog=rh_pim4;Data Source=DESKTOP-S5FPDQK";
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
