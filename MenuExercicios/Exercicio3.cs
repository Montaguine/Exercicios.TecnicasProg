using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercicios
{
    internal class Exercicio3 : Fila
    {
        static Random random = new Random();
        public List<Jogador> BatataQuente(int jogadores)
        {
            List<Jogador> lista = new List<Jogador>();
            List<Jogador> classificacao = new List<Jogador>();
            Queue<Jogador> fila = new Queue<Jogador>();

            for (int i = 0; i < jogadores; i++)
            {
                lista.Add(new Jogador(i + 1));
            }

            lista = lista.OrderBy(x => random.Next()).ToList();

            foreach (var jogador in lista)
            {
                fila.Enqueue(jogador);
            }

            while (fila.Count > 1)
            {
                int passes = random.Next(1, 101);

                for (int i = passes; i >= 0; i--)
                {
                    if (i > 0)
                    {
                        Jogador passe = fila.Dequeue();
                        fila.Enqueue(passe);
                    }

                    if (i == 0)
                    {
                        Jogador eliminado = fila.Dequeue();
                        classificacao.Add(eliminado);
                    }
                }
            }
            classificacao.Add(fila.Dequeue());
            return classificacao;
        }
    }
}
