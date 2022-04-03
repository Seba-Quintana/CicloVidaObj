//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            int count = 0;
            string option = Console.ReadLine();
            if (option == "1")
            {
                while (count != 100)
                {
                    var train = new Train(count, "train");
                    train.StartEngines();
                    count++;
                    Console.WriteLine(train.TrainCount);
                }
            }
            else if (option == "2")
            {
                while (count != 10000000)
                {
                    var train = new Train(count, "train");
                    train.StartEngines();
                    count++;
                    Console.WriteLine(train.TrainCount);
                }
            }
            else
            {
                var t1 = new Train(count, "Last Train To London");
                var t2 = new Train(count, "Last Train To London");
                var t3 = new Train(count, "Runaway Train");
                bool same1 = t1==t2;
                bool same2 = t3==t2;
                Console.WriteLine($"t1==t2: {same1} ||| t2==t3: {same2}\n");
            }
            Console.WriteLine("Hello World!");
        }
    }
}