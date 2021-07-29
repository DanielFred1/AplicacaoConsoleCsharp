using System.Collections.Generic;

namespace TesteImc
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T objeto);
    }
}