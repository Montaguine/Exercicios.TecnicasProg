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
        Random random = new Random();
        public List<Jogador> BatataQuente(int jogadores)
        {
            List<Jogador> lista = new List<Jogador>();
            List<Jogador> classificacao = new List<Jogador>();
            for (int i = 0; i < jogadores; i++)
            {
                lista.Add(new Jogador(i+1));
            }
            lista = lista.OrderBy(x => random.Next()).ToList();
            int passes = random.Next(1, 101);
            while (lista.Count > 1)
            {
                for(int i = passes; i >= 0; i--)
                {
                    if (i > 0) 
                    { 
                        Jogador passe = lista[0];
                        lista.RemoveAt(0);
                        lista.Add(passe);
                    }

                    if(i == 0)
                    {
                        classificacao.Add(lista[0]);
                        lista.RemoveAt(0);
                    }
                }
                if (lista.Count == 1)
                {
                    classificacao.Add(lista[0]);
                    lista.RemoveAt(0);
                }
            }
            return classificacao;
        }
    }
}
