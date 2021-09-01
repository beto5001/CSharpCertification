using System;

namespace CertificacaoCSharp
{
    class Program
    {
        //AULA 1 - CRIAR TIPOS DE VALOR: 
        static void Main(string[] args)
        {
            int idade;
            idade = 30;

            System.Int32 copiaIdade = idade;

            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Cópia Idade: {copiaIdade}");

            idade = 23;

            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Cópia Idade: {copiaIdade}");

            //Tipos de valor não aceitam receber o valor "null", somente aceitam receceber valores de sua faixa de valor
            //int idade = null *****ERRO

            //Para utilizar o valor null:
            int? idadeNullable = null;
            //O mesmo que: 
            System.Nullable<int> idadeNullale2 = idadeNullable;

            //Tipos integrais porque armazenam internamente um valor inteiro;

            char caractere = 'a';
            System.Char caractere2 = caractere;

            byte nivelDeAzul = 0xFF;

            short passageirosVoo = 230;
            System.Int16 passageirosVoo2 = passageirosVoo;

            long numeroGiganteDosGuri = 129310923190;
            System.Int64 numeroGiganteDosGuri2 = numeroGiganteDosGuri;

            sbyte doisBitsComSinalNegativo = -123;
            System.SByte doisBitsComSinalNegativo2 = doisBitsComSinalNegativo;
            
            uint unsignedInt = 02132;
            System.UInt32 unsignedInt2 = unsignedInt;

            ulong unsignedLong = 021323712;
            System.UInt64 unsignedLong2 = unsignedLong;

            Console.ReadKey();
        }
    }
}
