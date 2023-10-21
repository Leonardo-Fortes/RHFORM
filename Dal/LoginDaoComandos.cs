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
            tem = false;
            cmd.CommandText = "select cnpj from Empresa where cnpj = @c";
            cmd.Parameters.AddWithValue("@c", cnpj);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {        
                    dr.Close();
                if (date < DateTime.MinValue || date > DateTime.Now)
                {
                    Console.WriteLine("A data inserida não é válida. Não é possível inserir datas fora do intervalo suportado.");
                }
                else
                {
                    cmd.CommandText = "insert into Funcionario values (@nome,@telefone,@email,@sexo,@cpf,@cargo,@cnpj,@data)";
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@cargo", cargo);
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                    cmd.Parameters.AddWithValue("@data", SqlDbType.Date).Value = date;
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
            }
            else
            {
                this.msg = "CNPJ INEXISTENTE, TENTE NOVAMENTE";
            }
            return msg;
        }
        public string cadastrarEmp(string nome, string cnpj)
        {
            tem = false;
            cmd.CommandText = "insert into Empresa values (@nome,@cnpj)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
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

