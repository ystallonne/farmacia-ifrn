using System;
namespace SIDAF.Model
{
    interface IEndereco
    {
        int Cep { get; set; }
        string Cidade { get; set; }
        string Uf { get; set; }
        string Complemento { get; set; }
        string Logradouro { get; set; }
        string Numero { get; set; }
        int? Oid { get; set; }
        System.Collections.Generic.List<Telefone> Telefone { get; set; }
        string ToString();
       
    }
}
