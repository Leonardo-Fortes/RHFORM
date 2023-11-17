using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRhForm.Dal
{
    internal class FuncionarioDaoComandos
    {
        public int num = 0;
        SqlDataReader dr; // leitor do banco
        SqlCommand cmd = new SqlCommand();
        public bool tem = false;
        public string msg = "";
        Conexao con = new Conexao();

        public string cadastrarFuncionario(string nome, DateTime date, string telefone, string email, string sexo, string cpf, string cargo, string cnpj, DateTime dateadmissao)
        {
            int empresaId = 0;
            tem = false;
            try
            {
                SqlCommand cpfcommand = new SqlCommand("select count(*) from funcionario where cpf = @cpff");//verificar se ja existe cpf
                cpfcommand.Parameters.AddWithValue("@cpff", cpf);
                cpfcommand.Connection = con.conectar();
                int count = Convert.ToInt32(cpfcommand.ExecuteScalar());
                con.desconectar();
                if (count == 0)
                {
                    cmd.CommandText = "select idempresa from Empresa where cnpj = @cnpj";
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            empresaId = Convert.ToInt32(dr["idempresa"]);
                        }
                        dr.Close();
                        cmd.Parameters.Clear();
                        cmd.CommandText = "insert into Funcionario values (@nomeemp,@telefone,@email,@sexo,@cpf,@cargo,@cnpj,@data,@idempresa,@dataadmissao)";
                        cmd.Parameters.AddWithValue("@nomeemp", nome);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@cargo", cargo);
                        cmd.Parameters.AddWithValue("@cnpj", cnpj);
                        cmd.Parameters.AddWithValue("@data", SqlDbType.Date).Value = date;
                        cmd.Parameters.AddWithValue("@idempresa", empresaId);
                        cmd.Parameters.AddWithValue("@dataadmissao", SqlDbType.Date).Value = dateadmissao;

                        try
                        {
                            cmd.ExecuteNonQuery();
                            con.desconectar();
                            tem = true;
                        }
                        catch (SqlException ex)
                        {
                            this.msg = "erro com o banco" + ex;
                        }
                    }
                    else
                    {
                        this.msg = "Empresa inexistente";
                    }
                }
                else
                {
                    this.msg = "funcionario já existe";
                }
            }
            catch (SqlException sqlEx)
            {
                this.msg = "erro com banco" + sqlEx;
            }
            return msg;
        }
    }
}
