using System;
using System.Globalization;

namespace Desafio_01
{
    class Program {

        byte[] compact(byte[] originalData)
        {
            byte[] vetorCompactado = new byte[originalData.Length / 2];
            int j = 0;

            for (int i = 0; i < originalData.Length; i += 2 )
            {
                vetorCompactado[j] = (byte)(originalData[i] & 240 | originalData[i + 1] >> 4);
                j++;
            }
            return vetorCompactado
        }
        byte[] decompact(byte[] compactedData)
        {
            byte[] descompactarVetor = new byte[compactedData.Length]
            int k = 0;

            for (int i = 0; i < compactedData.Length)
            {
                descompactarVetor[k] = (byte)(240 & compactedData[i];
                descompactarVetor[k+1] = (byte)(compactedData[i] << 4)
                k += 2;
            }
            return descompactarVetor
        }
    }
}

