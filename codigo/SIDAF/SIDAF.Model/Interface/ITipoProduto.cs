using System;

namespace SIDAF.Model
{
    public interface ITipoProduto
    {
        int? Id { get; }
        string? Nome { get; set; }
        string ToString();
    }
}
