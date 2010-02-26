using System;
namespace SIDAF.Model
{
    interface IVenda
    {
        DateTime Data { get; set; }
        int? Oid { get; set; }
    }
}
