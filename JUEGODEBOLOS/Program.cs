using System;

namespace Bolos
{
    class Program
    {
        static void Main(string[] args)
        {
            bowling prueba = new bowling();
            bowling JuegoPerfecto = new bowling();

            


            //JUEGO NORMAL
            prueba.tiro(new int[] { 1, 4, 4, 5, 6,4, 5, 5, 10,0, 0, 1, 7, 3, 6, 4, 10, 0, 2,8,6 });
            Console.WriteLine("--------------------");
            prueba.puntaje();
            prueba.mostrarcasillas();  Console.WriteLine("|");
            prueba.mostrarmarcador();

            Console.WriteLine("");
            //JUEGO PERFECTO
            JuegoPerfecto.tiro(new int[] { 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 10, 10 });
            Console.WriteLine("--------------------");
            JuegoPerfecto.puntaje();
            JuegoPerfecto.mostrarcasillas(); Console.WriteLine("|");
            JuegoPerfecto.mostrarmarcador();



        }
    }
}
