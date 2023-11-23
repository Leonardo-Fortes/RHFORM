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
        SqlDataReader dr; // leitor do banco
        SqlCommand cmd = new SqlCommand();
        public bool tem = false;
        public string msg = "";
        Conexao con = new Conexao();
        public string VerificarCPF(string cpf)
        {
            tem = false;
            try
            {
                cmd.CommandText = "select cpf from Funcionario where cpf = @cpf";
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
                else
                {
                    this.msg = "cpf não encontrado";
                }
            }
            catch (Exception ex)
            {
                this.msg = "Cpf Inválido" + ex.Message;
            }
            return msg;

        }

        public string CadastrarBeneficio(string cpf, double convenio, double valetransporte, double valealimentacao, double valerefeicao, double ferias, double decimoterceiro, string data)
        {
            int idfuncionario = -1;
            tem = false;
            try
            {
               
                    cmd.CommandText = "select idfuncionario FROM Funcionario where cpf = @cpfinserido";
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
                        cmd.Parameters.Clear();
                        cmd.CommandText = "INSERT INTO Beneficios (convenio, valetransporte, valealimentacao, valerefeicao, ferias, decimoterceiro, id_funcionario, mes_ano) VALUES (@convenio, @valetransporte, @valealimentacao, @valerefeicao, @ferias, @decimoterceiro, @id_funcionario, @mes_ano)";
                        cmd.Parameters.AddWithValue("@convenio", convenio);
                        cmd.Parameters.AddWithValue("@valetransporte", valetransporte);
                        cmd.Parameters.AddWithValue("@valealimentacao", valealimentacao);
                        cmd.Parameters.AddWithValue("@valerefeicao", valerefeicao);
                        cmd.Parameters.AddWithValue("@ferias", ferias);
                        cmd.Parameters.AddWithValue("@decimoterceiro", decimoterceiro);
                        cmd.Parameters.AddWithValue("@id_funcionario", idfuncionario);
                        cmd.Parameters.AddWithValue("@mes_ano", data);
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
            catch (SqlException exe)
            {
                this.msg = "erro" + exe;
            }

            return msg;
        }
    }
}
