using ProjetoRhForm.Modelo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
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
        public string cadastrarFuncionario(string nome, DateTime date, string telefone, string email, string sexo, string cpf)
        {
            tem = false;
            cmd.CommandText = "select cpf from funcionario where cpf = @c";
            cmd.Parameters.AddWithValue("@c", cpf);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            if (!dr.HasRows)
            {         
                    dr.Close();
                    cmd.CommandText = "insert into Funcionario values (@nome,@data,@telefone,@email,@sexo,@cpf)";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@data", date);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
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
                this.msg = "CPF JÁ EXISTENTE, TENTE NOVAMENTE";
            }
            return msg;
        }
    }
}

