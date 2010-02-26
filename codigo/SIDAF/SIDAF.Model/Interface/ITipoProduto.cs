using System;
namespace SidafCore
{
    interface ITipoProduto
    {
        int? Id { get; }
        string? Nome { get; set; }
        string ToString();
    }
}
