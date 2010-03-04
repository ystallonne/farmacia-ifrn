﻿using System;
using SIDAF.Model.Interface;


namespace SIDAF.Model
{
   public class Cliente : ICliente
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

        private string orgaoEmissor;

        public string OrgaoEmissor
        {
            get { return orgaoEmissor; }
            set { orgaoEmissor = value; }
        }
        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
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




        public Cliente(Usuario usuario, Endereco endereco, string nome, int cpf,
            int rg, DateTime dataNasc,string orgaoEmissor, string naturalidade, string nacionalidade)
        {
            this.usuario = usuario;
            this.endereco = endereco;
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.orgaoEmissor = orgaoEmissor;
            this.dataNascimento = dataNasc;
            this.naturalidade = naturalidade;
            this.nacionalidade = nacionalidade;
        }

        public override string ToString()
        {
            return this.nome + " - " + this.dataNascimento.ToString() + " - " + this.cpf.ToString() + " - " + this.endereco.ToString();
        } 
        
    }
}