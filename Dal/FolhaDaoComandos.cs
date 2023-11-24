using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace ProjetoRhForm.Dal
{
    internal class FolhaDaoComandos
    {
        public int num = 0;
        SqlDataReader dr; // leitor do banco
        SqlCommand cmd = new SqlCommand();
        public bool tem = false;
        public string msg = "";
        Conexao con = new Conexao();

        public string CalcHorasFolha(string cpf, string mes_ano, string cnpjEmpresa)
        {
            try
            {
                int idEmpresa = 0;

                cmd.CommandText = "select idempresa  from Empresa where cnpj = @cnpjEmpresa";
                cmd.Parameters.AddWithValue("@cnpjEmpresa", cnpjEmpresa);

                tem = false;
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows && dr.Read())
                {
                    idEmpresa = Convert.ToInt32(dr["idempresa"]);
                }
                dr.Close();


                if (!string.IsNullOrEmpty(cpf))
                {
                    // Se um CPF foi fornecido, busque o ID do funcionário associado
                    int idFuncionario = BuscarIdFuncionarioPorCpf(cpf);


                    if (idFuncionario != -1)
                    {
                        // Verifique se o funcionário pertence à empresa especificada
                        if (FuncionarioPertenceAEmpresa(idFuncionario, idEmpresa))
                        {
                            // Se encontrou o ID e o funcionário pertence à empresa, execute a stored procedure para esse funcionário
                            ExecutarStoredProcedure(idFuncionario, mes_ano);
                            ExecutarStoredProcedureSalarioBase(idFuncionario, mes_ano);
                            ExecutarStoredProcedureCalcularDesconto(idFuncionario, mes_ano);
                            ExecutarStoredProcedureSalarioLiquido(idFuncionario, mes_ano);
                            this.tem = true;
                        }
                        else
                        {
                            this.msg = "Funcionário não pertence à empresa especificada.";
                        }
                    }
                    else
                    {
                        this.msg = "Funcionário não encontrado.";
                    }
                }
                else
                {
                    // Se nenhum CPF foi fornecido, busque todos os IDs de funcionários da empresa especificada
                    List<int> idsFuncionarios = BuscarTodosIDsFuncionariosDaEmpresa(idEmpresa);

                    // Itere sobre todos os IDs e execute a stored procedure para cada um
                    foreach (int idFuncionario in idsFuncionarios)
                    {
                        ExecutarStoredProcedure(idFuncionario, mes_ano);
                        ExecutarStoredProcedureSalarioBase(idFuncionario, mes_ano);
                        ExecutarStoredProcedureCalcularDesconto(idFuncionario, mes_ano);
                        ExecutarStoredProcedureSalarioLiquido(idFuncionario, mes_ano);
                        this.tem = true;
                    }

                    tem = true;
                }
            }
            catch (Exception ex)
            {
                this.msg = "Erro com o banco: " + ex.Message;
            }

            return msg;


        }

        private int BuscarIdFuncionarioPorCpf(string cpf)
        {
            int idFuncionario = -1;

            cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE cpf = @cpfinserido";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cpfinserido", cpf);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();

            if (dr.HasRows && dr.Read())
            {
                idFuncionario = Convert.ToInt32(dr["idfuncionario"]);
            }

            dr.Close();
            con.desconectar();

            return idFuncionario;
        }



        private void ExecutarStoredProcedure(int idFuncionario, string mes_ano)
        {

            try
            {
                cmd.CommandText = "execute CalcularHorasTrabalhadas @id, @mes_ano ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idFuncionario);
                cmd.Parameters.AddWithValue("@mes_ano", mes_ano);
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 || ex.Number == 50002)
                {
                    this.msg = ex.Message;
                }
            }

        }


        private List<int> BuscarTodosIDsFuncionariosDaEmpresa(int idEmpresa)
        {
            List<int> idsFuncionarios = new List<int>();

            cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE id_empresa = @idempresa";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idempresa", idEmpresa);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int idFuncionario = Convert.ToInt32(dr["idfuncionario"]);
                idsFuncionarios.Add(idFuncionario);
            }

            dr.Close();
            con.desconectar();

            return idsFuncionarios;
        }

        private bool FuncionarioPertenceAEmpresa(int idFuncionario, int idEmpresa)
        {
            cmd.CommandText = "SELECT 1 FROM Funcionario WHERE idfuncionario = @idfuncionario AND id_empresa = @idempresa";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@idfuncionario", idFuncionario);
            cmd.Parameters.AddWithValue("@idempresa", idEmpresa);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            bool pertence = dr.HasRows;
            dr.Close();
            con.desconectar();
            return pertence;
        }

        private void ExecutarStoredProcedureSalarioBase(int idFuncionario, string mes_ano)
        {
            try
            {
                cmd.CommandText = "execute CalcularSalarioBase @id, @mes_ano ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idFuncionario);
                cmd.Parameters.AddWithValue("@mes_ano", mes_ano);
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.desconectar();

                if (rowsAffected == 0)
                {
                    this.msg = "Nenhum registro atualizado, Funcionário fora de serviço.";
                }
                else
                {
                    tem = true;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000)
                {
                    this.msg = ex.Message;
                }
            }

        }
        private void ExecutarStoredProcedureSalarioLiquido(int idFuncionario, string mes_ano)
        {
            try
            {
                cmd.CommandText = "execute SalarioLiquido @id, @mes_ano ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idFuncionario);
                cmd.Parameters.AddWithValue("@mes_ano", mes_ano);
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 50001)
                {
                    this.msg = ex.Message;
                }
            }

        }

        private void ExecutarStoredProcedureCalcularDesconto(int idFuncionario, string mesAno)
        {
            try
            {
                cmd.CommandText = "execute CalcularDescontos @id, @mesAno";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", idFuncionario);
                cmd.Parameters.AddWithValue("@mesAno", mesAno);
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
                con.desconectar();

            }
            catch (SqlException ex)
            {
                if (ex.Number == 50000 || ex.Number == 50002)
                {
                    this.msg = ex.Message;
                }
            }

        }
        public string PegarNome(string cpf)
        {
            tem = false;
            int id_funcionario = 0;
            string nome = "";
            string nomeEmpresa = "";

            try
            {
                // Consulta para obter o ID do funcionário com base no CPF
                cmd.CommandText = "SELECT idfuncionario, id_empresa FROM Funcionario WHERE cpf = @cpf";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cpf", cpf);

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    id_funcionario = Convert.ToInt32(dr["idfuncionario"]);
                    int id_empresa = Convert.ToInt32(dr["id_empresa"]);

                    // Consulta para obter o nome da empresa
                    cmd.CommandText = "SELECT nome FROM Empresa WHERE idempresa = @id_empresa";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id_empresa", id_empresa);

                    dr.Close();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows && dr.Read())
                    {
                        nomeEmpresa = dr["nome"].ToString();
                    }

                    // Consulta para obter o nome do funcionário
                    cmd.CommandText = "SELECT nome FROM Funcionario WHERE idfuncionario = @idfunc";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idfunc", id_funcionario);

                    dr.Close();
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows && dr.Read())
                    {
                        nome = dr["nome"].ToString();
                    }
                    else
                    {
                        
                        msg = "Funcionário não encontrado!";
                    }

                    dr.Close();
                }
                else
                {
                    
                    msg = "Funcionário não encontrado!";
                }
            }
            catch (Exception ex)
            {
                msg = "Erro ao obter nome do funcionário: " + ex.Message;
            }
            finally
            {
                dr.Close();
            }
            this.tem = true;
            return $"Nome: {nome}\n" +
                   $"Empresa: {nomeEmpresa}";
        }

        public DataTable ExibirFolha(string cpf, string data)
        {
            DataTable tabelaFolha = new DataTable();
            int id_funcionario = 0;

            try
            {
                // Consulta para obter o ID do funcionário com base no CPF
                cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE cpf = @cpf";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cpf", cpf);

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows && dr.Read())
                {
                    id_funcionario = Convert.ToInt32(dr["idfuncionario"]);
                }

                dr.Close();
                   
                // Consulta para obter os dados da tabela Folha
                string columnNamesFolha = "mes_ano, hora_extra, qtd_hora, salario_base, salario_liquido";
                string queryFolha = $"SELECT {columnNamesFolha} FROM Folha WHERE id_funcionario = @idfunc AND mes_ano = @data";

                // Consulta para obter os dados da tabela Desconto
                string columnNamesDesconto = "inss, fgts, irrf";
                string queryDesconto = $"SELECT {columnNamesDesconto} FROM Desconto WHERE id_funcionario = @idfunc AND mes_ano = @data";

                cmd.Parameters.AddWithValue("@idfunc", id_funcionario);
                cmd.Parameters.AddWithValue("@data", data);

                // Executar a consulta da tabela Folha
                cmd.CommandText = queryFolha;
                dr = cmd.ExecuteReader();

                foreach (var columnName in columnNamesFolha.Split(',').Select(c => c.Trim()))
                {
                    if (!tabelaFolha.Columns.Contains(columnName))
                    {
                        tabelaFolha.Columns.Add(columnName);
                    }
                }

                try
                {
                    while (dr.Read())
                    {
                        DataRow linha = tabelaFolha.NewRow();

                        foreach (var columnName in columnNamesFolha.Split(',').Select(c => c.Trim()))
                        {
                            linha[columnName] = dr[columnName];
                        }

                        tabelaFolha.Rows.Add(linha);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao processar dados da tabela Folha.", ex);
                }
                finally
                {
                    dr.Close();
                }

                // Executar a consulta da tabela Desconto
                cmd.CommandText = queryDesconto;
                dr = cmd.ExecuteReader();

                foreach (var columnName in columnNamesDesconto.Split(',').Select(c => c.Trim()))
                {
                    if (!tabelaFolha.Columns.Contains(columnName))
                    {
                        tabelaFolha.Columns.Add(columnName);
                    }
                }

                try
                {
                    while (dr.Read())
                    {
                        DataRow linha = tabelaFolha.NewRow();

                        foreach (var columnName in columnNamesDesconto.Split(',').Select(c => c.Trim()))
                        {
                            linha[columnName] = dr[columnName];
                        }

                        tabelaFolha.Rows.Add(linha);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao processar dados da tabela Desconto.", ex);
                }
                finally
                {
                    dr.Close();
                }

                // Retorna o DataTable com todas as linhas ou uma tabela vazia se não houver dados
                return tabelaFolha.Rows.Count > 0 ? tabelaFolha : new DataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                throw new Exception("Erro ao executar a consulta.", ex);
            }
        }

    }
}


