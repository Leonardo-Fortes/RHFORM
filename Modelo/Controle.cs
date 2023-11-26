using ProjetoRhForm.Apresentação;
using ProjetoRhForm.Dal;
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
        public string cadastrar(string login, string senha, string confSenha, string tipo)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.msg = loginDao.cadastrarUsuario(login, senha, confSenha, tipo);
            if (loginDao.tem) 
            {
                this.tem = true;
            }
            return msg;
        }
        public bool verificarAdmin(string cpf)
        {
            LoginDaoComandos loginDaoComandos = new LoginDaoComandos();
            bool isAdmin = loginDaoComandos.verificaTipo(cpf);
            return isAdmin;
        }

        public string cadastrarFunc(string nome, DateTime date, string telefone, string email, string sexo, string cpf, string cargo, string cnpj, DateTime dataadmissao, int salarioHr)
        {
            
            FuncionarioDaoComandos funcDao = new FuncionarioDaoComandos ();
            this.msg = funcDao.cadastrarFuncionario(nome, date, telefone, email, sexo, cpf, cargo, cnpj, dataadmissao, salarioHr );
           
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
            BeneficiosDaoComandos beneficiosDao = new BeneficiosDaoComandos(); 
            this.msg = beneficiosDao.VerificarCPF(cpf);
            if (beneficiosDao.tem)
            {
                this.tem = true;
            }        
            return msg;
        }
        public string cadastrarBeneficios(string cpf,double convenio, double valetransporte, double valealimentacao, double valerefeicao, double ferias, double decimoterceiro, string data)
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
        public string calcHorasTrabalhadas (string cpf, string mesAno, string cnpj)
        {
            FolhaDaoComandos folha = new FolhaDaoComandos ();
            this.msg = folha.CalcHorasFolha(cpf, mesAno, cnpj);
            if (folha.tem)
            {
                this.tem = true;
            }
            return msg;
        }
        public DataTable ExibirFolha(string cpf, string data)
        {
            FolhaDaoComandos folhaDao = new FolhaDaoComandos();
            return folhaDao.ExibirFolha(cpf, data);
        }
        public string BuscarDados(string cpf)
        {
            FolhaDaoComandos folhaDaoComandos = new FolhaDaoComandos();
            this.msg = folhaDaoComandos.PegarNome(cpf);
            if (folhaDaoComandos.tem)
            {
                this.tem = true;
            }
            return msg;
        }

        public string AlterarBeneficios(string cpf, double convenio, double valetransporte, double valealimentacao, double valerefeicao, double ferias, double decimoterceiro, string data)
        {
            BeneficiosDaoComandos beneficiosDao = new BeneficiosDaoComandos();
            this.msg = beneficiosDao.AlterarBeneficio(cpf, convenio, valetransporte, valealimentacao, valerefeicao, ferias, decimoterceiro, data);
            if(beneficiosDao.tem)
            {
                this.tem = true;
            }
            return msg;
        }
       
        public string AlterarEmpresa(string nome, string cnpj, string rua, string numero, string bairro, string cidade, string uf, string pais, string cep)
        {
            EmpresaDaoComandos empresa = new EmpresaDaoComandos();
            this.msg =  empresa.alterarEmp(nome, cnpj, rua, numero, bairro, cidade, uf, pais, cep);
            if (empresa.tem)
            {
                this.tem = true;
            }
            return msg;
        }
        public DataTable ConsultarEmpresa(string cnpj)
        {   
            EmpresaDaoComandos emp = new EmpresaDaoComandos();
            return  emp.ExibirEmpresa(cnpj);
           
        }
        public string DeleteEmpresa(string cnpj)
        {
            EmpresaDaoComandos emp = new EmpresaDaoComandos();
            this.msg = emp.DeleteEmpresa(cnpj);
            if(emp.tem)
            {
                this.tem = true;
            }
            return msg;
        }
        public string AlterFunc(string nome, DateTime date, string telefone, string email, string sexo, string cpf, string cargo, string cnpj, DateTime dataadmissao, int salarioHr)
        {
            FuncionarioDaoComandos func = new FuncionarioDaoComandos();
            this.msg = func.alterarFunc(nome, date, telefone, email, sexo, cpf, cargo, cnpj, dataadmissao, salarioHr);
            if(func.tem)
            {
                this.tem = true;
            }
            return msg;
        }
        public DataTable ConsultarFunc(string cpf)
        {
            FuncionarioDaoComandos func = new FuncionarioDaoComandos();          
                return func.ConsultarFuncionario(cpf);          
        }
        public string DeletarFunc(string cpf)
        {
            FuncionarioDaoComandos func = new FuncionarioDaoComandos();
            this.msg = func.DeletarFunc(cpf);
            if (func.tem)
            {
                this.tem = true;
            }
            return msg;
        }
    }
}
