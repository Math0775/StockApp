using StockApp.Business.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Business.Interfaces
{
    public interface ICategoriaRepositorio
    {
        bool Incluir(Categoria categoria);
        bool Atualizar(Categoria categoria);
        bool Remover(int Id);
        bool Ativar(int Id);
        bool Reativar(int Id);

        Categoria ObertPorId(int Id);
        List<Categoria> ObeterTodos();
        List<Categoria> ObterTodasAtivas();
    }
}
