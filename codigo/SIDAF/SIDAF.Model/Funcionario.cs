using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SIDAF.Model.Interface;
using SIDAF.Model.Interface;


namespace SIDAF.Model
{
    public class Funcionario : IFuncionario
    {
        private Nullable<int> oid;

        public Nullable<int> Oid
        {
            get { return oid; }
            set { oid = value; }
        }

        private Usuario usuario;

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private Categoria categoria;

        public Categoria categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private Empresa empresa;

        public Empresa Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }
        private Endereco endereco;

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int cpf;

        public int Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private int rg;

        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        private DateTime dataNasc;

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
        private DateTime dataAdmissao;

        public DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }
        private Nullable<DateTime> dataDemissao;

        public Nullable<DateTime> DataDemissao
        {
            get { return dataDemissao; }
            set { dataDemissao = value; }
        }
        private string naturalidade;

        public string Naturalidade
        {
            get { return naturalidade; }
            set { naturalidade = value; }
        }
        private string nacionalidade;

        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }

        public Funcionario()
        {
        }
        public Funcionario(Usuario usuario,Categoria categoria, Empresa empresa, Endereco endereco, string nome, int cpf,
            int rg, DateTime dataNasc, DateTime dataAdmissao, Nullable<DateTime> dataDemissao,
            string naturalidade, string nacionalidade)
        {
            this.usuario = usuario;
            this.categoria = categoria;
            this.empresa = empresa;
            this.endereco = endereco;
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.dataNasc = dataNasc;
            this.dataAdmissao = dataAdmissao;
            this.dataDemissao = dataDemissao;
            this.naturalidade = naturalidade;
            this.nacionalidade = nacionalidade;

        }


        public override string ToString()
        {
            return this.nome + " - " + this.dataNasc.ToString() + " , " + this.dataAdmissao.ToString()
                + " - " + this.empresa.RazaoSocial + " - " + this.nacionalidade + " - " + this.naturalidade;
        } 




    }
}
