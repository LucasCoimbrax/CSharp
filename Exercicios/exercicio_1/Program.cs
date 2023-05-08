// Exercicio 1

using System;
using static System.Console;

string InverterString(string str)
{
    int tamanho = str.Length;
    
    char[] caracteres = new char[tamanho];
    
    for (int i = 0; i < tamanho; i++)
    {
        caracteres[i] = str[tamanho - 1 - i];
    }
    
    return new string(caracteres);
}

string valor = "";
dynamic valores = "";

int numberInput = int.Parse(ReadLine());

int numero = Convert.ToInt32(numberInput);

if( numero == 0 || numero == 1 ){
    return valores = Convert.ToString(numero);
}else{
    while (numero > 0){
        valor += Convert.ToString(numero % 2);
        numero = numero / 2;
    }
    return InverterString(valor);
};
