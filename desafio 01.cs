using System;

namespace DIO {
    class Program {
        static void Main(string[] args) {
           
            int N = int.Parse(Console.ReadLine());

            //Exibir "Ho" do papai noel
            for (int i = 0; i < N; i++) {
                if (i < (N-1)) {
                    Console.Write("Ho ");                  //Complete o código no espaço em branco
                }
                else{
                    Console.WriteLine("Ho!");
                }
            }
        }
    }
}

// Entrada
// A entrada é composta por um único inteiro N (0 < N ≤ 106) representando quantos "Ho" serão falados por Noel.

// Saída
// A saída é composta por todos "Ho" que Papai Noel deve falar separados por um espaço. Após o último "Ho" deve ser apresentado um "!" encerrando o programa.

// Seu trabalho é ajudar o Papai Noel montando um problema que mostre todos os "Ho" que ele deve falar dado o número sorteado