
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
            cmd.CommandText = "SELECT Usuario.*, Funcionario.cpf FROM Usuario INNER JOIN Funcionario ON Usuario.login = Funcionario.cpf WHERE Usuario.login = @login AND Usuario.senha = @senha AND Funcionario.status = @status";
            
            cmd.Parameters.AddWithValue("@status", status);
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
                else
                {
                    return false;
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
            int id_funcionario = -1;
            if (senha.Equals(confSenha)) // verificação de senha
            {
                cmd.CommandText = "Select idfuncionario from Funcionario where cpf = @login and status = @status";
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@status", status);
                
                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();
                    
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            id_funcionario = Convert.ToInt32(dr["idfuncionario"]);
                        }
                    }
                    else
                    {
                        this.msg = "Funcionário inexistente!";
                    }
                    dr.Close();
                        cmd.CommandText = "Select login from Usuario where login = @cpff";
                        cmd.Parameters.AddWithValue("@cpff", login);
                        dr = cmd.ExecuteReader();
                        if (!dr.HasRows)
                        {
                            dr.Close ();
                            cmd.CommandText = "insert into Usuario (login,senha,tipo,id_funcionario) values (@l,@s,@t,@id)";
                            cmd.Parameters.AddWithValue("@l", login);
                            cmd.Parameters.AddWithValue("@s", senha);
                            cmd.Parameters.AddWithValue("@t", tipo);
                            cmd.Parameters.AddWithValue("@id", id_funcionario);
                            cmd.ExecuteNonQuery(); // executando dados 
                            con.desconectar();
                            tem = true;
                        }
                        else
                        {
                            this.msg = "Já existe um Usuário com essas credenciais!";
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

        public bool verificaUsu(string cpf)
        {
            if (string.IsNullOrEmpty(cpf)) // Adicione essa verificação
            {
                return false;
            }

            string usu = "funcionario";
            cmd.CommandText = "SELECT login FROM Usuario WHERE login = @cpf AND tipo = @tipo";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@tipo", usu);
            cmd.Connection = con.conectar();

            dr = cmd.ExecuteReader();

            bool temUsu = dr.HasRows;

            dr.Close();
            con.desconectar();

            return temUsu;
        }
    }
}



