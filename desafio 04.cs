using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class URI {
    static void Main(string[] args) {
        var c = int.Parse(Console.ReadLine());
        for (int i = 0; i < c; i++) {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(n - Math.Floor(Math.Sqrt(n)));
        }
    }
}

// Desafio 04 Xenlonguinho