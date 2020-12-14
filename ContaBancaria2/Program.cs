using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria2
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta = SistemaBanco.CriarConta();
            Console.WriteLine(conta.ToString()); 
            Console.ReadLine();

            SistemaBanco.Depositar(conta);
            Console.WriteLine(conta.ToString());
            Console.ReadLine();

            SistemaBanco.Sacar(conta);
            Console.WriteLine(conta.ToString());
            Console.ReadLine();

        }
    }
}
