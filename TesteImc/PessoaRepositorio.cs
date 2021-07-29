using System;
using System.Collections.Generic;

namespace TesteImc
{
    public class PessoaRepositorio : IRepositorio<Pessoa>
    {
        private List<Pessoa> ListaPessoa = new List<Pessoa>();

        public void Insere(Pessoa objeto)
        {
            ListaPessoa.Add(objeto);
        }

        public List<Pessoa> Lista()
        {
            return ListaPessoa;
        }

        public Pessoa RetornaPorId(int id)
        {
            return ListaPessoa[id];
        }
    }
}