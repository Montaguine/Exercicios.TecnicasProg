using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace MenuExercicios
{
    internal class Exercicio1 : Lista
    {
       public List<string> input = new List<string>{
           "Idiossincrasia","Ambivalente","Quimérica",
           "Perpendicular","Efêmero","Pletora","Obnubilado",
           "Xilografia","Quixote","Inefável"};

        public List<string> MaiorQueNove(List<string> list)
        {
            List<string> newList = new List<string>();
            foreach (string item in list)
            {
                if (item.Length > 9)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }
    }
}
