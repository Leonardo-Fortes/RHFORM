using ProjetoRhForm.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRhForm.Modelo
{
    public class Controle
    {
        public bool tem;
        public string msg = "";
        public bool acessar (string login, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(login, senha);
            if(!loginDao.msg.Equals(""))
            {
                this.msg = msg;
            }
            return tem;
        }
        public string cadastrar(string login, string senha, string confSenha, int id)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.msg = loginDao.cadastrarUsuario(login, senha, confSenha, id);
            if (loginDao.tem) 
            {
                this.tem = true;
            }
            return msg;
        }
        public string cadastrarFunc(string nome, DateTime date, string telefone, string email, string sexo, string cpf)
        {
            
            LoginDaoComandos loginDao = new LoginDaoComandos ();
            this.msg = loginDao.cadastrarFuncionario(nome, date, telefone, email, sexo, cpf);
           
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }
     
    }
}
