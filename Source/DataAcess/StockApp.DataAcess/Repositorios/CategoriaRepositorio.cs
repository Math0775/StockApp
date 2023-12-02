using StockApp.Business.Entidades;
using StockApp.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.DataAcess.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        public bool Ativar(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Atualizar(Categoria categoria)
        {
            throw new NotImplementedException();
        }
        
        public bool Incluir(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public Categoria ObertPorId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Categoria> ObeterTodos()
        {
            throw new NotImplementedException();
        }

        public List<Categoria> ObterTodasAtivas()
        {
            throw new NotImplementedException();
        }

        public bool Reativar(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Remover(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
