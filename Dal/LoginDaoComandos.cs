using ProjetoRhForm.Modelo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRhForm.Dal
{
    internal class LoginDaoComandos

    {
        SqlDataReader dr; // leitor do banco
        SqlCommand cmd = new SqlCommand();
        public bool tem = false;
        public string msg = "";
        Conexao con = new Conexao();
        public bool verificarLogin(string login, string senha)
        {
            //comandos sql de verificação //
            cmd.CommandText = "select * from Usuario where nome = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) // verificar se tem informação do banco //
                {
                    tem = true;
                }
                
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {
                this.msg = "Erro com Banco de Dados";
            }
            return tem;
        }
        public string cadastrarUsuario(string login, string senha, string confSenha) //cadastro usuario
        {
            if (senha.Equals(confSenha)) // verificação de senha
            {           
                            cmd.CommandText = "insert into Usuario (nome,senha) values (@l,@s)";
                            cmd.Parameters.AddWithValue("@l", login);
                            cmd.Parameters.AddWithValue("@s", senha);
                
                        try
                        {
                            cmd.Connection = con.conectar();
                            cmd.ExecuteNonQuery(); // executando dados 
                            con.desconectar();
                            tem = true;
                        }
                        catch (SqlException ex)
                        {
                            this.msg = "ERRO AO INSERIR DADOS" +ex;
                        }         
            }
            else
            {
                this.msg = "SENHA ERRADA";
            }
            return msg;
        }
        public string cadastrarFuncionario(string nome, DateTime date, string telefone, string email, string sexo, string cpf, string cargo, string cnpj )
        {
            int empresaId = 0;
            tem = false;
            try
            {
                SqlCommand cpfcommand = new SqlCommand("select count(*) from funcionario where cpf = @cpff");
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
                        cmd.CommandText = "insert into Funcionario values (@nomeemp,@telefone,@email,@sexo,@cpf,@cargo,@cnpj,@data,@idempresa)";
                        cmd.Parameters.AddWithValue("@nomeemp", nome);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@cargo", cargo);
                        cmd.Parameters.AddWithValue("@cnpj", cnpj);
                        cmd.Parameters.AddWithValue("@data", SqlDbType.Date).Value = date;
                        cmd.Parameters.AddWithValue("@idempresa", empresaId);

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
            cmd.Parameters.AddWithValue("@pais",pais);
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

