using System;
using AulaPOO_Heranca.Classes;

namespace AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();

            pf.cpf = "000.000.000-00";

            pf.nome = "Alan";

            Console.WriteLine( pf.DarBoasVindas(pf.nome) );

            Console.WriteLine( pf.ValidarCpf(pf.cpf) );
        }
    }
}
