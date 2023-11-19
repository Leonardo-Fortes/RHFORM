using ProjetoRhForm.Dal;

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
            
            FuncionarioDaoComandos funcDao = new FuncionarioDaoComandos ();
            this.msg = funcDao.cadastrarFuncionario(nome, date, telefone, email, sexo, cpf, cargo, cnpj, dataadmissao );
           
            if (funcDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }
        public string cadastrarEmp(string nome, string cnpj, string rua, string numero, string bairro, string cidade, string uf, string pais, string cep)
        {
            EmpresaDaoComandos empresaDao = new EmpresaDaoComandos ();
            this.msg = empresaDao.cadastrarEmp(nome, cnpj, rua, numero, bairro, cidade, uf, pais, cep);
            if (empresaDao.tem)
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
            BeneficiosDaoComandos beneficiosDao = new BeneficiosDaoComandos ();
            this.msg = beneficiosDao.CadastrarBeneficio(cpf, convenio, valetransporte,valealimentacao, valerefeicao, ferias, decimoterceiro, data);
            if(beneficiosDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }
 
       public string cadPontoInicioIntervalo(string cpf, DateTime inicioIntervalo, DateTime data)
        {
            PontoDaoComandos pontoDao = new PontoDaoComandos();
            this.msg = pontoDao.cadPontoInicio(cpf, inicioIntervalo, data );
            if(pontoDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }
        public string cadPontoEntradaFolha(DateTime entrada, string cpf, DateTime data)
        {
            PontoDaoComandos pontoDao = new PontoDaoComandos();
            this.msg = pontoDao.cadPontoEntrada(entrada,cpf, data);
            if (pontoDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }

        public string cadFimIntervalo(string cpf, DateTime fimIntervalo, DateTime data)
        {
            PontoDaoComandos pontoDao =new PontoDaoComandos();
            this.msg = pontoDao.cadFimIntervalo(cpf, fimIntervalo, data);
            if (pontoDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }
        public string saidaPonto(string cpf, DateTime saida, DateTime data)
        {
            PontoDaoComandos pontoDao = new PontoDaoComandos();
            this.msg = pontoDao.saidaPonto(cpf, saida, data);
            if (pontoDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }
        
    }
}
