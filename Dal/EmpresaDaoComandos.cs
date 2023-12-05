using System;
using System.Collections.Generic;
using System.Data;
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
            int status = 1;
            tem = false;
            cmd.CommandText = "select 1 from Empresa where cnpj = @cnpj1";
            cmd.Parameters.AddWithValue("@cnpj1", cnpj);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                cmd.CommandText = "insert into Empresa (nome, cnpj, rua, numero, bairro, cidade, UF, pais, cep, status)  values (@nome,@cnpj,@rua,@numero,@bairro,@cidade,@uf,@pais,@cep,@status)";
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cnpj", cnpj);
                cmd.Parameters.AddWithValue("@rua", rua);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.Parameters.AddWithValue("@bairro", bairro);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@uf", uf);
                cmd.Parameters.AddWithValue("@pais", pais);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@status", status);
                dr.Close();
                try
                {
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    tem = true;
                }
                catch (SqlException e)
                {

                    this.msg = "erro com o banco" + e;
                }
            }
            else
            {
                this.msg = "Já existe uma empresa com esse CNPJ";
            }
            return msg;
        }
        public string alterarEmp(string nome, string cnpj, string rua, string numero, string bairro, string cidade, string uf, string pais, string cep)
        {
            tem = false;
            cmd.CommandText = "UPDATE Empresa SET nome = @nome, rua = @rua, numero = @numero, bairro = @bairro, cidade = @cidade, uf = @uf, pais = @pais, cep = @cep where cnpj = @cnpj1";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@uf", uf);
            cmd.Parameters.AddWithValue("@pais", pais);
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@cnpj1", cnpj);
            try
            {
                cmd.Connection = con.conectar();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.desconectar();

                if (rowsAffected == 0)
                {
                    this.msg = "Nenhum registro atualizado, Empresa Inexistente.";
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
            return msg;
        }

        public DataTable ExibirEmpresa(string cnpj)
        {
            DataTable tabelaEmpresa = new DataTable();
            tem = false;

            try
            {
                string columnNamesEmpresa = "nome, cnpj, rua, numero, bairro, cidade, UF, pais, cep, status, dataQuebraContrato";
                string queryFolha;

                if (string.IsNullOrEmpty(cnpj))
                {
                    // Se o CNPJ for nulo, traga todas as empresas
                    queryFolha = $"SELECT {columnNamesEmpresa} FROM Empresa";
                }
                else
                {
                    // Caso contrário, traga a empresa com o CNPJ especificado
                    queryFolha = $"SELECT {columnNamesEmpresa} FROM Empresa WHERE cnpj = @cnpj";
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                }

                cmd.Connection = con.conectar();
                cmd.CommandText = queryFolha;
                dr = cmd.ExecuteReader();

                foreach (var columnName in columnNamesEmpresa.Split(',').Select(c => c.Trim()))
                {
                    if (!tabelaEmpresa.Columns.Contains(columnName))
                    {
                        tabelaEmpresa.Columns.Add(columnName);
                    }
                }

                try
                {
                    while (dr.Read())
                    {
                        DataRow linha = tabelaEmpresa.NewRow();

                        foreach (var columnName in columnNamesEmpresa.Split(',').Select(c => c.Trim()))
                        {
                            linha[columnName] = dr[columnName];
                        }

                        tabelaEmpresa.Rows.Add(linha);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao processar dados da tabela Folha.", ex);
                }
                finally
                {
                    this.tem = true;
                    dr.Close();
                    con.desconectar();
                }

                // Retorna o DataTable com todas as linhas ou uma tabela vazia se não houver dados
                return tabelaEmpresa.Rows.Count > 0 ? tabelaEmpresa : new DataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                throw new Exception("Erro ao executar a consulta.", ex);
            }
        }
        public string DeleteEmpresa(string cnpj)
        {
            DateTime data = DateTime.Now;
            int status = 0;
            tem = false;
            cmd.CommandText = "update Empresa set status = @status, dataQuebraContrato = @data where cnpj = @cnpj";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@data", SqlDbType.Date).Value = data;
            try
            {
                cmd.Connection = con.conectar();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    this.msg = "Nenhum registro deletado, Empresa Inexistente.";
                }
                else
                {
                    tem = true;
                }
                con.desconectar();              
            }
            catch
            {
                this.msg = "Cnpj não foi encontrado!";
            }
            return msg;
        }

    }
}
