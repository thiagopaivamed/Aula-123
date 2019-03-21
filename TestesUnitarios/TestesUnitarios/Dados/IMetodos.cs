using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestesUnitarios.Models;

namespace TestesUnitarios.Dados
{
    public interface IMetodos
    {
        string PegarNomePeloId(int id);
        IEnumerable<Carro> PegarTodos();
    }
}
