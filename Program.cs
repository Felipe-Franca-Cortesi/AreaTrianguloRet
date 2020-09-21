using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("-----Calcule a área de um triângulo retângulo-----");

            Console.Write("Informe o valor base(b) do triângulo: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe a altura(h) do triângulo: ");
            decimal h = Convert.ToDecimal(Console.ReadLine());

            decimal mult = b * h;
            decimal area = mult / 2;

            Console.WriteLine($"\n Base: {b} \n Altura: {h} \n Área: {area} ");
            Console.Write("Pressione qualquer tecla para sair");
            Console.ReadKey();


        }
    }
}
