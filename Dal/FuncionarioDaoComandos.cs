using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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

        public string cadastrarFuncionario(string nome, DateTime date, string telefone, string email, string sexo, string cpf, string cargo, string cnpj, DateTime dateadmissao, int salarioHr)
        {
            int status = 1;
            int empresaId = 0;
            int ativo = 1;
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
                    cmd.CommandText = "select idempresa from Empresa where cnpj = @cnpj and status = @statuss";
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                    cmd.Parameters.AddWithValue("@statuss", status);
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
                        cmd.CommandText = "insert into Funcionario (nome, telefone, email, sexo, cpf, cargo, cnpj_empresa, datanascimento, id_empresa, dataadmissao, salario_hora, status) values (@nomeemp,@telefone,@email,@sexo,@cpf,@cargo,@cnpj,@data,@idempresa,@dataadmissao,@salarioHr, @status)";
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
                        cmd.Parameters.AddWithValue("@salarioHr", salarioHr);
                        cmd.Parameters.AddWithValue("@status", ativo);

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
        public string alterarFunc(string nome, DateTime date, string telefone, string email, string sexo, string cpf, string cargo, string cnpj, DateTime dateadmissao, int salarioHr)
        {
            tem = false;
            int empresaId = 0;
            int ativo = 1;
            tem = false;
            try
            {
                SqlCommand cpfcommand = new SqlCommand("select count(*) from funcionario where cpf = @cpff");//verificar se ja existe cpf
                cpfcommand.Parameters.AddWithValue("@cpff", cpf);
                cpfcommand.Connection = con.conectar();
                int count = Convert.ToInt32(cpfcommand.ExecuteScalar());
                con.desconectar();
                if (count == 1)
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
                        cmd.CommandText = "UPDATE Funcionario SET nome = @nomeemp, telefone = @telefone, email = @email, sexo = @sexo, cpf = @cpf, cargo = @cargo,  cnpj_empresa = @cnpj, datanascimento = @data, id_empresa = @idempresa, dataadmissao = @dataadmissao, salario_hora = @salarioHr, status = @status where  cpf = @cppf";
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
                        cmd.Parameters.AddWithValue("@salarioHr", salarioHr);
                        cmd.Parameters.AddWithValue("@status", ativo);
                        cmd.Parameters.AddWithValue("@cppf", cpf);
                        try
                        {
                            cmd.Connection = con.conectar();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            con.desconectar();

                            if (rowsAffected == 0)
                            {
                                this.msg = "Nenhum registro atualizado, Funcionário inexistente.";
                            }
                            else
                            {
                                tem = true;
                            }
                        }
                        catch (SqlException ex)
                        {
                            this.msg = "Erro com o banco " + ex;
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
            catch(SqlException sqlEx)
            {
                this.msg = "erro com banco" + sqlEx;
            }
            return msg;
        }
        public DataTable ConsultarFuncionario(string cpf)
        {
            DataTable tabelaFunc = new DataTable();
            tem = false;

            try
            {
                string columnNamesFunc = "nome, telefone, email, sexo, cpf, cargo, cnpj_empresa, datanascimento, dataadmissao, salario_hora, datademissao, status";
                string queryFunc;

                if (string.IsNullOrEmpty(cpf))
                {
                    // Se o CNPJ for nulo, traga todas as empresas
                    queryFunc = $"SELECT {columnNamesFunc} FROM Funcionario";
                }
                else
                {
                    // Caso contrário, traga a empresa com o CNPJ especificado
                    queryFunc = $"SELECT {columnNamesFunc} FROM Funcionario WHERE cpf = @cpf";
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                }

                cmd.Connection = con.conectar();
                cmd.CommandText = queryFunc;
                dr = cmd.ExecuteReader();

                foreach (var columnName in columnNamesFunc.Split(',').Select(c => c.Trim()))
                {
                    if (!tabelaFunc.Columns.Contains(columnName))
                    {
                        tabelaFunc.Columns.Add(columnName);
                    }
                }

                try
                {
                    while (dr.Read())
                    {
                        DataRow linha = tabelaFunc.NewRow();

                        foreach (var columnName in columnNamesFunc.Split(',').Select(c => c.Trim()))
                        {
                            linha[columnName] = dr[columnName];
                        }

                        tabelaFunc.Rows.Add(linha);
                    }
                   
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao processar dados da tabela Funcionários.", ex);
                }
                finally
                {
                    this.tem = true;
                    dr.Close();
                    con.desconectar();
                }

                // Retorna o DataTable com todas as linhas ou uma tabela vazia se não houver dados
                return tabelaFunc.Rows.Count > 0 ? tabelaFunc : new DataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                throw new Exception("Erro ao executar a consulta.", ex);
            }
        }
        public string DeletarFunc(string cpf)
        {
            tem = false;
            DateTime dateTime = DateTime.Now;
            cmd.CommandText = "update Funcionario set status = 0, datademissao = @data where cpf = @cpf";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@data", SqlDbType.Date).Value = dateTime;
            try
            {
                cmd.Connection = con.conectar();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    this.msg = "Nenhum registro deletado, FuncionárioInexistente.";
                }
                else
                {
                    tem = true;
                }
                con.desconectar();
            }
            catch
            {
                this.msg = "CPF não foi encontrado!";
            }

            return msg;
        }
    }
    
    
}
