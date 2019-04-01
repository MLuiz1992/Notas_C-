using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                double P1; double Ma1; double Mb1; double P2; double Ma2; double Mb2; String nome; double QtAula; double QtFalta; double media; double A1; double A2; double presenca;
                Console.WriteLine("Pograma top em C#\r");
                Console.WriteLine("------------------------\n");


                Console.WriteLine("Digite o nome do Aluno");
                nome = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Digite a P1 do aluno");
                P1 = Convert.ToDouble(Console.ReadLine());
          
                Console.WriteLine("Digite a Ma1 do aluno");
                Ma1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a Ma1 do aluno");
                Mb1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a P2 do aluno");
                P2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a Ma2 do aluno");
                Ma2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a Ma1 do aluno");
                Mb2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de aulas do aluno");
                QtAula = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de faltas do aluno");
                QtFalta = Convert.ToDouble(Console.ReadLine());

                A1 = P1 * 0.7 + Ma1 * 0.2 + Mb1 * 0.1;
                A2 = P2 * 0.7 + Ma2 * 0.2 + Mb2 * 0.1;
                media = (A1 + 2 * A2) / 3;
                presenca = (QtFalta / QtAula) * 100;

                if(media >= 5 && presenca <= 75)
                {
                    Console.WriteLine("O aluno " + nome.ToString() + " está APROVADO!");
                    Console.WriteLine("Nota " + media);
                    Console.WriteLine("Presença " + presenca + "%");
                }
                else if((media >= 3 && media <= 5) && presenca <= 75)
                {
                    Console.WriteLine("O aluno " + nome.ToString() + " está em RECUPERAÇÃO!");
                    Console.WriteLine("Nota " + media);
                    Console.WriteLine("Presença " + presenca + "%");
                }
                else if (media < 3 && presenca <= 75)
                {
                    Console.WriteLine("O aluno " + nome.ToString() + " está REPROVADO POR NOTA!");
                    Console.WriteLine("Nota " + media);
                    Console.WriteLine("Presença " + presenca + "%");
                }
                else
                {
                    Console.WriteLine("O aluno " + nome.ToString() + " está REPROVADO POR FALTA!");
                    Console.WriteLine("Nota " + media);
                    Console.WriteLine("Presença " + presenca + "%");
                }
            }
        }
    }
}
