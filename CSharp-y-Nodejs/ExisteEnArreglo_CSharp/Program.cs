using System;

namespace ExisteEnArreglo_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verificar si existe "Amarillo" en el arreglo
            string[] cadArray= new string[]{"Blanco","Negro","Verde","Azul"};
            bool existe=Array.Exists(cadArray, item=>item=="Amarillo");
            Console.WriteLine(existe);
        }
    }
}
