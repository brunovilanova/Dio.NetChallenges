using System;

class DIO {

  static void Main(string[] args) {

    double pi, raio, volume;
    pi = 3.14159;

  double R = double.Parse(Console.ReadLine());
  volume = (4.0/3.0) * pi * (Math.Pow(R, 3.0));
  Console.WriteLine("VOLUME = " + Math.Round(volume, 3));


  }

}

// Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).

// Entrada
// O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

// Saída
// A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade. O valor deverá ser apresentado com 3 casas após o ponto.

