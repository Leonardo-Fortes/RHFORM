
using System.Data;
using System.Data.SqlClient;


namespace ProjetoRhForm.Dal
{
    internal class LoginDaoComandos

    {
        public int num = 0;
        SqlDataReader dr; // leitor do banco
        SqlCommand cmd = new SqlCommand();
        public bool tem = false;
        public string msg = "";
        Conexao con = new Conexao();
        public bool verificarLogin(string login, string senha)
        {
            int status = 1;
            //comandos sql de verificação //
            cmd.CommandText = "select * from Usuario where nome = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.CommandText = "select cpf from Funcionario where status = @status";
            cmd.Parameters.AddWithValue("@status", status);
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
        public string cadastrarUsuario(string login, string senha, string confSenha, string tipo) //cadastro usuario
        {
            int status = 1;
            if (senha.Equals(confSenha)) // verificação de senha
            {
                cmd.CommandText = "Select cpf from Funcionario where cpf = @login and status = @status";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@status", status);
                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        cmd.CommandText = "Select login from Usuario where login = @cpff";
                        cmd.Parameters.AddWithValue("@cpff", login);
                        dr = cmd.ExecuteReader();
                        if (!dr.HasRows)
                        {
                            dr.Close ();
                            cmd.CommandText = "insert into Usuario (login,senha,tipo) values (@l,@s,@t)";
                            cmd.Parameters.AddWithValue("@l", login);
                            cmd.Parameters.AddWithValue("@s", senha);
                            cmd.Parameters.AddWithValue("@t", tipo);
                            cmd.ExecuteNonQuery(); // executando dados 
                            con.desconectar();
                            tem = true;
                        }
                        else
                        {
                            this.msg = "Já existe um Usuário com essas credenciais!";
                        }
                       
                    }
                    else
                    {
                        this.msg = "Funcionário inexistente!";
                    }
    
                    
                }
                catch (SqlException ex)
                {
                    this.msg = "Funcionário inexistente" + ex;
                }
            }
            else
            {
                this.msg = "SENHA ERRADA";
            }
            return msg;
        }

        public bool verificaTipo(string cpf)
        {
            if (string.IsNullOrEmpty(cpf)) // Adicione essa verificação
            {
                return false;
            }

            string admin = "admin";
            cmd.CommandText = "SELECT login FROM Usuario WHERE login = @cpf AND tipo = @tipo";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@tipo", admin);
            cmd.Connection = con.conectar();

            dr = cmd.ExecuteReader();

            bool temAdmin = dr.HasRows;

            dr.Close();
            con.desconectar();

            return temAdmin;
        }


    }
}



