﻿using ProjetoRhForm.Apresentação;
using ProjetoRhForm.Modelo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string cadastrarFuncionario(string nome, DateTime date, string telefone, string email, string sexo, string cpf, string cargo, string cnpj, DateTime dateadmissao)
        {
            int empresaId = 0;
            tem = false;
            try
            {
                SqlCommand cpfcommand = new SqlCommand("select count(*) from funcionario where cpf = @cpff");//verificar se ja existe cpf
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
                        cmd.CommandText = "insert into Funcionario values (@nomeemp,@telefone,@email,@sexo,@cpf,@cargo,@cnpj,@data,@idempresa,@dataadmissao)";
                        cmd.Parameters.AddWithValue("@nomeemp", nome);
                        cmd.Parameters.AddWithValue("@telefone", telefone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@cargo", cargo);
                        cmd.Parameters.AddWithValue("@cnpj", cnpj);
                        cmd.Parameters.AddWithValue("@data", SqlDbType.Date).Value = date;
                        cmd.Parameters.AddWithValue("@idempresa", empresaId);
                        cmd.Parameters.AddWithValue("@dataadmissao", SqlDbType.Date).Value = dateadmissao;

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
            cmd.Parameters.AddWithValue("@pais", pais);
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
                this.msg = "cpf não encontrado" ;
            }
            return msg;
            
        }
        public string CadastrarBeneficio(string cpf, double convenio, double valetransporte, double valealimentacao, double valerefeicao, double ferias, double decimoterceiro, DateTime data)
        { 
            int idfuncionario = -1;
            tem = false;
            try
            {
                cmd.Parameters.Clear();
                if (!string.IsNullOrEmpty(cpf)) 
                {
                    cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE cpf = @cpfinserido";
                    cmd.Parameters.AddWithValue("@cpfinserido", cpf);                 
                    cmd.Connection = con.conectar();
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            idfuncionario = Convert.ToInt32(dr["idfuncionario"]);                                                  
                        }
                        dr.Close();
                        cmd.CommandText = "INSERT INTO Beneficios (convenio, valetransporte, valealimentacao, valerefeicao, ferias, decimoterceiro, id_funcionario, mes_ano) VALUES (@convenio, @valetransporte, @valealimentacao, @valerefeicao, @ferias, @decimoterceiro, @id_funcionario, @mes_ano)";
                        cmd.Parameters.AddWithValue("@convenio", convenio);
                        cmd.Parameters.AddWithValue("@valetransporte", valetransporte);
                        cmd.Parameters.AddWithValue("@valealimentacao", valealimentacao);
                        cmd.Parameters.AddWithValue("@valerefeicao", valerefeicao);
                        cmd.Parameters.AddWithValue("@ferias", ferias);
                        cmd.Parameters.AddWithValue("@decimoterceiro", decimoterceiro);
                        cmd.Parameters.AddWithValue("@id_funcionario", idfuncionario);
                        cmd.Parameters.AddWithValue("@mes_ano", SqlDbType.Date).Value = data;
                        try
                        {
                            cmd.ExecuteNonQuery();
                            con.desconectar();
                            tem = true;
                        }
                        catch (SqlException ex)
                        {
                            this.msg = "Erro com o banco " + ex;
                        }
                    }
                    else
                    {
                        this.msg = "Funcionário inexistente";
                    }
                }
                else
                {
                    this.msg = "valor vazio";
                }
            }
            catch (SqlException exe)
            {
                this.msg = "erro" + exe;
            }

            return msg;
        }
        public string verificaCpfPonto(string cpf)
        {
            tem = false;
            string nomeFunc = "";
            cmd.CommandText = "SELECT nome from funcionario where cpf = @cpf";
            cmd.Parameters.AddWithValue("@cpf", cpf);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();  
                if (dr.HasRows)
                {
                    if (dr.Read())
                    {
                        nomeFunc = dr["nome"].ToString();
                    }
                    tem = true;
                }            
                else
                {
                    this.msg = "Usuário não foi encontrado";
                }
                dr.Close();
                con.desconectar();
            }
            catch (SqlException ex)
            {
                this.msg = "";
                this.msg = "Erro com o banco " + ex;
            }
            return nomeFunc;
        }
        public string cadPontoEntrada(DateTime entrada, string cpf, DateTime data)
        {
            tem = false;
            int id_funcionario = -1;
            cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE cpf = @cpfinserido";
            cmd.Parameters.AddWithValue("@cpfinserido", cpf);         
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    id_funcionario = Convert.ToInt32(dr["idfuncionario"]);
                }
                cmd.CommandText = "INSERT INTO FolhaPonto (entrada,id_funcionario,data) values (@entrada,@id_funcionario,@data)";
                cmd.Parameters.AddWithValue("@entrada", SqlDbType.Time).Value = entrada;
                cmd.Parameters.AddWithValue("@id_funcionario", id_funcionario);
                cmd.Parameters.AddWithValue("@data", SqlDbType.Date).Value = data;
                dr.Close();
                try
                {
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    tem = true;
                }
                catch (SqlException ex)
                {
                    this.msg = "Erro com o banco" + ex;
                }
            }
            else
            {
                this.msg = "Funcionário inexistente!";
            }
                return msg;
        }
        public string cadPontoInicio(string cpf, DateTime inicioIntervalo, DateTime data)
        {
            tem = false;
            int id_funcionario = -1;            
            cmd.CommandText = "SELECT idfuncionario FROM Funcionario WHERE cpf = @cpfinserido";
            cmd.Parameters.AddWithValue("@cpfinserido", cpf);
            cmd.Connection = con.conectar();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                  id_funcionario = Convert.ToInt32(dr["idfuncionario"]);
            
                }
                dr.Close();
                cmd.CommandText = "UPDATE FolhaPonto SET InicioIntervalo = @HoraInicioIntervalo" +
                                 "WHERE id_funcionario = @IdFuncionario AND data = @DataDesejada";
                cmd.Parameters.AddWithValue("@HoraInicioIntervalo", SqlDbType.Time).Value = inicioIntervalo;              
                cmd.Parameters.AddWithValue("@IdFuncionario", id_funcionario);
                cmd.Parameters.AddWithValue("@DataDesejada", SqlDbType.Date).Value = data;
                try
                {
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    tem = true;
                }
                catch (SqlException ex)
                {
                    this.msg = "Erro com o banco " + ex;
                }
            }           
            else
            {
                this.msg = "cpf invalido!";
            }
            return msg;
        }
    }
}


