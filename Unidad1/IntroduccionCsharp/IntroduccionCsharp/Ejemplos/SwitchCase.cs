﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCsharp.Ejemplos
{
    public class SwitchCase
    {
        public SwitchCase() 
        {
            int opc = 0;
            Console.WriteLine("Hola elija una opción:\n1. Iniciar\n2. Detener\n3. Reiniciar\n4. Estado\n (escriba una opción):");

            try
            {
                opc = int.Parse(Console.ReadLine() ?? "0");
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Iniciando proceso...");
                        break;
                    case 2:
                        Console.WriteLine("Deteniendo proceso...");
                        break;
                    case 3:
                        Console.WriteLine("Reiniciando el proceso...");
                        break;
                    case 4:
                        Console.WriteLine("Actualmente esta...");
                        break;
                    default:
                        Console.WriteLine("No existe la opción");
                        break;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
            }       
        }

        //public void SwitchCaseSinTryCatch() 
        //{
        //    int opc = 0;
        //    Console.WriteLine("Hola elija una opción:\n1. Iniciar\n2. Detener\n3. Reiniciar\n4. Estado\n (escriba una opción):");
        //    opc = int.Parse(Console.ReadLine() ?? "0");

        //    switch (opc)
        //    {
        //        case 1:
        //            Console.WriteLine("Iniciando proceso...");
        //            break;
        //        case 2:
        //            Console.WriteLine("Deteniendo proceso...");
        //            break;
        //        case 3:
        //            Console.WriteLine("Reiniciando el proceso...");
        //            break;
        //        case 4:
        //            Console.WriteLine("Actualmente esta...");
        //            break;
        //        default:
        //            Console.WriteLine("No existe la opción");
        //            break;
        //    }
        //}
    }
}
