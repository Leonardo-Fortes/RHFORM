using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRhForm.Dal
{
    internal class BeneficiosDaoComandos
    {
        public int num = 0;
        public bool tem = false;
        public string msg = "";
        SqlCommand cmd;
        SqlDataReader dr;
        Conexao con = new Conexao();

        public string CadastrarBeneficio(string cpf, double convenio, double valetransporte, double valealimentacao, double valerefeicao, double ferias, double decimoterceiro, DateTime data)
        {
            int idfuncionario = -1;
            tem = false;
            try
            {
                cmd.Parameters.Clear();
                if (!string.IsNullOrEmpty(cpf))
                {
                    cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE cpf = @cpfinserido";
                    cmd.Parameters.AddWithValue("@cpfinserido", cpf);
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            idfuncionario = Convert.ToInt32(dr["idfuncionario"]);
                        }
                        dr.Close();
                        cmd.CommandText = "INSERT INTO Beneficios (convenio, valetransporte, valealimentacao, valerefeicao, ferias, decimoterceiro, id_funcionario, mes_ano) VALUES (@convenio, @valetransporte, @valealimentacao, @valerefeicao, @ferias, @decimoterceiro, @id_funcionario, @mes_ano)";
                        cmd.Parameters.AddWithValue("@convenio", convenio);
                        cmd.Parameters.AddWithValue("@valetransporte", valetransporte);
                        cmd.Parameters.AddWithValue("@valealimentacao", valealimentacao);
                        cmd.Parameters.AddWithValue("@valerefeicao", valerefeicao);
                        cmd.Parameters.AddWithValue("@ferias", ferias);
                        cmd.Parameters.AddWithValue("@decimoterceiro", decimoterceiro);
                        cmd.Parameters.AddWithValue("@id_funcionario", idfuncionario);
                        cmd.Parameters.AddWithValue("@mes_ano", SqlDbType.Date).Value = data;
                        try
                        {
                            cmd.ExecuteNonQuery();
                            con.desconectar();
                            tem = true;
                        }
                        catch (SqlException ex)
                        {
                            this.msg = "Erro com o banco " + ex;
                        }
                    }
                    else
                    {
                        this.msg = "Funcionário inexistente";
                    }
                }
                else
                {
                    this.msg = "valor vazio";
                }
            }
            catch (SqlException exe)
            {
                this.msg = "erro" + exe;
            }

            return msg;
        }
    }
}
