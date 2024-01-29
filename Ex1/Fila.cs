using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface Fila
    {
        public List<Jogador> BatataQuente(int jogadores);
    }

    public class Jogador
    {
        public int numero;
        public Jogador(int num)
        {
            numero = num;
        }
    }
}
