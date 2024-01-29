using Interfaces;

namespace MenuExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio = 0;
            do
            {
                Console.WriteLine("Selecione o exercicio:");
                Console.WriteLine("1 - Lista: maiores que 9");
                Console.WriteLine("2 - Pilha: expressões balanceadas");
                Console.WriteLine("3 - Fila: batata quente");
                Console.WriteLine("4 - Dicionario: contador de palavras");
                Console.WriteLine();
                Console.WriteLine("ENTER - Sair");
                exercicio = int.TryParse(Console.ReadLine(), out exercicio) ? exercicio : 0;

                switch (exercicio)
                {
                    case 1:
                        Console.Clear();
                        Exercicio1 ex1 = new Exercicio1();
                        Console.WriteLine("A lista contém os seguintes itens: ");
                        ex1.input.ForEach(item => Console.WriteLine(item));
                        Console.WriteLine();
                        Console.WriteLine("A lista com o método de filtro contém os seguintes itens: ");
                        ex1.MaiorQueNove(ex1.input).ForEach(item => Console.WriteLine(item));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Exercicio2 ex2 = new Exercicio2();
                        Console.WriteLine("Digite a expressão a ser verificada:");
                        string? expression = Console.ReadLine();
                        Console.WriteLine(ex2.IsBalanced(expression) ? "Expressão balanceada" : "Expressão não balanceada");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Exercicio3 ex3 = new Exercicio3();
                        Console.WriteLine("Digite a quantidade de jogadores:");
                        int jogadores = int.TryParse(Console.ReadLine(), out jogadores) ? jogadores : 0;
                        Console.Clear();
                        List<Jogador> resultado = ex3.BatataQuente(jogadores);
                        Console.WriteLine($"O campeao foi o jogador numero {resultado[jogadores-1].numero}");
                        Console.WriteLine();
                        Console.WriteLine("Ordem do primeiro eliminado ao campeao: ");
                        resultado.ForEach(item => Console.WriteLine(item.numero));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Exercicio4 ex4 = new Exercicio4();
                        Console.Clear();
                        Dictionary<string, int> lista = ex4.ContadorPalavras();
                        Console.WriteLine("O texto contém as seguintes palavras e suas respectivas quantidades:");
                        Console.WriteLine();
                        foreach (KeyValuePair<string, int> item in lista)
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Exercicio não encontrado");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (exercicio != 0);
        }
    }
}
