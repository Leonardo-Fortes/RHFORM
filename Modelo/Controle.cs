using ProjetoRhForm.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
        public string cadastrar(string login, string senha, string confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.msg = loginDao.cadastrarUsuario(login, senha, confSenha);
            if (loginDao.tem) 
            {
                this.tem = true;
            }
            return msg;
        }
        public string cadastrarFunc(string nome, DateTime date, string telefone, string email, string sexo, string cpf, string cargo, string cnpj, DateTime dataadmissao)
        {
            
            LoginDaoComandos loginDao = new LoginDaoComandos ();
            this.msg = loginDao.cadastrarFuncionario(nome, date, telefone, email, sexo, cpf, cargo, cnpj, dataadmissao );
           
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }
        public string cadastrarEmp(string nome, string cnpj, string rua, string numero, string bairro, string cidade, string uf, string pais, string cep)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos ();
            this.msg = loginDao.cadastrarEmp(nome, cnpj, rua, numero, bairro, cidade, uf, pais, cep);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }

        public string verificaCPF(string cpf)
        {
            LoginDaoComandos loginDAO = new LoginDaoComandos(); 
            this.msg = loginDAO.VerificarCPF(cpf);
            if (loginDAO.tem)
            {
                this.tem = true;
            }        
            return msg;
        }
        public string cadastrarBeneficios(string cpf,double convenio, double valetransporte, double valealimentacao, double valerefeicao, double ferias, double decimoterceiro, DateTime data)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.msg = loginDao.CadastrarBeneficio(cpf, convenio, valetransporte,valealimentacao, valerefeicao, ferias, decimoterceiro, data);
            if(loginDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }
     
    }
}
