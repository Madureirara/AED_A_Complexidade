using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseComplexidade
{
    class Exemplos
    {

        public void MaximoVet1(int[] vetor, ref int maior, ref int menor)
        {
            maior = vetor[0];
            menor = vetor[0];

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                }
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                }
            }
        }
        public void MaximoVet2(int[] vetor, ref int maior, ref int menor)
        {
            maior = vetor[0];
            menor = vetor[0];
            int elementoAzul;
            int elementoVermelho;
            for (int i = 0; i < vetor.Length; i+=2)
            {
                if (vetor[i] <vetor[i+1]) 
                {
                    elementoAzul=vetor[i];
                    elementoVermelho = vetor[i + 1];

                }
                else
                {
                     elementoVermelho=vetor[i + 1];
                     elementoAzul=vetor[i];
                }
                if (elementoAzul<menor)
                {
                    menor = elementoAzul;
                }
                if (elementoVermelho > maior)
                {
                    maior = elementoVermelho;
                }
            }
        }
    }
}
