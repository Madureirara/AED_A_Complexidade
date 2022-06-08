using System;

namespace AnaliseComplexidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MaxValue;
            int menor = int.MinValue;
            Exemplos exemplo = new Exemplos();      
            int[] vetor = new int[] {2,3,4,5,6,17,22,55 };
            exemplo.MaximoVet2(vetor,ref maior,ref menor);            

        }
    }
}
