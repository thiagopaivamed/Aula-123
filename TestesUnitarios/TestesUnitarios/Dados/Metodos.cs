using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestesUnitarios.Models;

namespace TestesUnitarios.Dados
{
    public class Metodos : IMetodos
    {
        private readonly Contexto _contexto;

        public Metodos(Contexto contexto)
        {
            _contexto = contexto;
        }

        public string PegarNomePeloId(int id)
        {
            return _contexto.Carros.Find(id).Nome;
        }

        public IEnumerable<Carro> PegarTodos()
        {
            return _contexto.Carros.ToList();
        }
    }
}
