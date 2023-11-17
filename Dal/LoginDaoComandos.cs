
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
                cmd.CommandText = "Select cpf from Funcionario where cpf = @login";
                cmd.Parameters.AddWithValue("@login", login);
                try
                {
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        cmd.CommandText = "insert into Usuario (nome,senha) values (@l,@s)";
                        cmd.Parameters.AddWithValue("@l", login);
                        cmd.Parameters.AddWithValue("@s", senha);
                        cmd.ExecuteNonQuery(); // executando dados 
                        con.desconectar();
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


        public string VerificarCPF(string cpf)
        {
            tem = false;
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
            return msg;

        }

    }

}



