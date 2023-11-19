using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace ProjetoRhForm.Dal
{
    internal class PontoDaoComandos
    {
        public int num = 0;
        SqlDataReader dr; // leitor do banco
        SqlCommand cmd = new SqlCommand();
        public bool tem = false;
        public string msg = "";
        Conexao con = new Conexao();

        public string cadPontoEntrada(DateTime entrada, string cpf, DateTime data)
        {
            tem = false;
            int id_funcionario = -1;

            cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE cpf = @cpfinserido";
            cmd.Parameters.AddWithValue("@cpfinserido", cpf);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    id_funcionario = Convert.ToInt32(dr["idfuncionario"]);
                }

                dr.Close();

                // Verifica se já existe uma entrada para o mesmo dia sem a saída correspondente
                cmd.CommandText = "SELECT COUNT(*) FROM FolhaPonto " +
                                 "WHERE id_funcionario = @IdFuncionario " +
                                 "AND data = @DataDesejada " +
                                 "AND entrada IS NOT NULL " + // Verifica se a entrada já foi registrada
                                 "AND saida IS NULL"; // Verifica se a saída ainda não foi registrada

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdFuncionario", id_funcionario);
                cmd.Parameters.AddWithValue("@DataDesejada", SqlDbType.Date).Value = data;

                try
                {
                    int count = (int)cmd.ExecuteScalar(); // Obtém o número de registros encontrados

                    if (count > 0)
                    {
                        this.msg = "Não é permitido registrar uma nova entrada no mesmo dia sem ter registrado a saída anterior.";
                    }
                    else
                    {
                        // Prossiga para registrar a entrada
                        cmd.CommandText = "INSERT INTO FolhaPonto (entrada,id_funcionario,data) values (@entrada,@id_funcionario,@data)";
                        cmd.Parameters.AddWithValue("@entrada", SqlDbType.Time).Value = entrada;
                        cmd.Parameters.AddWithValue("@id_funcionario", id_funcionario);
                        cmd.Parameters.AddWithValue("@data", SqlDbType.Date).Value = data;

                        cmd.ExecuteNonQuery();
                        con.desconectar();
                        tem = true;
                    }
                }
                catch (SqlException ex)
                {
                    this.msg = "Erro com o banco" + ex;
                }
            }
            else
            {
                this.msg = "Funcionário inexistente!";
            }
            return msg;
        }



        public string cadPontoInicio(string cpf, DateTime inicioIntervalo, DateTime data)
        {
            tem = false;
            int id_funcionario = -1;
            cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE cpf = @cpfinserido";
            cmd.Parameters.AddWithValue("@cpfinserido", cpf);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    id_funcionario = Convert.ToInt32(dr["idfuncionario"]);

                }
                dr.Close();
                cmd.CommandText = "UPDATE FolhaPonto SET inicioIntervalo = @horainicio " +
                  "WHERE id_funcionario = @IdFuncionario AND data = @DataDesejada " +
                  "AND inicioIntervalo IS NULL";
                cmd.Parameters.AddWithValue("@horainicio", SqlDbType.Time).Value = inicioIntervalo;
                cmd.Parameters.AddWithValue("@IdFuncionario", id_funcionario);
                cmd.Parameters.AddWithValue("@DataDesejada", SqlDbType.Date).Value = data;
                try
                {
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
                    this.msg = "Erro com o banco " + ex;
                }
            }
            else
            {
                this.msg = "cpf invalido!";
            }
            return msg;
        }

        public string cadFimIntervalo(string cpf, DateTime fimIntervalo, DateTime date)
        {

            tem = false;
            int id_funcionario = -1;
            cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE cpf = @cpfinserido";
            cmd.Parameters.AddWithValue("@cpfinserido", cpf);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    id_funcionario = Convert.ToInt32(dr["idfuncionario"]);
                }
                dr.Close();
                cmd.CommandText = "UPDATE FolhaPonto SET fimIntervalo = @fimIntervalo " +
                  "WHERE id_funcionario = @IdFuncionario AND data = @data " +
                  " AND fimIntervalo IS NULL" +
                  " AND inicioIntervalo IS NOT NULL";
                cmd.Parameters.AddWithValue("@fimIntervalo", SqlDbType.Time).Value = fimIntervalo;
                cmd.Parameters.AddWithValue("@IdFuncionario", id_funcionario);
                cmd.Parameters.AddWithValue("@data", SqlDbType.Date).Value = date;
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.desconectar();

                    if (rowsAffected == 0)
                    {
                        this.msg = "É Preciso estar no horário de intervalo para sair!!";
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
                this.msg = "Usuário inexistente";
            }

            return msg;
        }
        public string saidaPonto(string cpf, DateTime saidaPonto, DateTime date)
        {
            tem = false;
            int id_funcionario = -1;
            cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE cpf = @cpfinserido";
            cmd.Parameters.AddWithValue("@cpfinserido", cpf);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    id_funcionario = Convert.ToInt32(dr["idfuncionario"]);
                }
                dr.Close();
                cmd.CommandText = "UPDATE FolhaPonto SET saida = @saidaPonto " +
                  " WHERE id_funcionario = @IdFuncionario AND data = @data " +
                  " AND entrada IS NOT NULL" +
                  " AND saida IS NULL";
                cmd.Parameters.AddWithValue("@saidaPonto", SqlDbType.Time).Value = saidaPonto;
                cmd.Parameters.AddWithValue("@IdFuncionario", id_funcionario);
                cmd.Parameters.AddWithValue("@data", SqlDbType.Date).Value = date;
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.desconectar();

                    if (rowsAffected == 0)
                    {
                        this.msg = "É Preciso estar no horário de trabalho!!";
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
                this.msg = "Usuário inexistente";
            }
            return msg;

        }
    }

    
}
