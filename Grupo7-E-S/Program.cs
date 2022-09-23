using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo7_E_S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] tanques = new double[] { 5000, 3000, 1000 };
            double precio_premium = 200, precio_super = 300, precio_gasoil = 500, vendido_premium= 50, vendido_super=76, vendido_gasoil=22;

            Ingresos(tanques, precio_premium, precio_super, precio_gasoil, vendido_premium, vendido_super, vendido_gasoil);
            
            Console.ReadKey();
        }

        static void Ingresos(double[] tanques, double precio_premium, double precio_super, double precio_gasoil, double vendido_premium, double vendido_super, double vendido_gasoil)
        {
            /*
            2022| Developed by Lucas Gonzalez and Cristian Lugo  |Todos los derechos reservados
            */


            ///////  Metodo para ver iformacion de combustibles  ////

            //Llama el metodo 
            /*Ingresos(tanques, precio_premium, precio_super, precio_gasoil, vendido_premium, vendido_super, vendido_gasoil);*/


            //variables
            double tolalPremium, totalSuper, totalGasoil, totalRecaudado, totalTanques, totalLitrosV;
            int opcion;

            //operaciones matematicas
            tolalPremium = vendido_premium * precio_premium;
            totalSuper = vendido_super * precio_super;
            totalGasoil = vendido_gasoil * precio_gasoil;
            totalRecaudado = tolalPremium + totalSuper + totalGasoil;
            totalTanques = tanques[0] + tanques[1] + tanques[2];
            totalLitrosV = vendido_premium + vendido_super + vendido_gasoil;


            while (true)
            {
                Console.Clear();
                /********* MARCO *********/

                Console.CursorVisible = false;

                for (int V = 10; V <= 100; V++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(V, 4);
                    Console.Write("#");
                    Console.SetCursorPosition(V, 30);
                    Console.Write("#");

                    for (int H = 4; H < 31; H++)
                    {
                        Console.SetCursorPosition(10, H);
                        Console.WriteLine("$");
                        Console.SetCursorPosition(100, H);
                        Console.WriteLine("$");

                    }
                }//fin marco

                //menu
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("**********************************");
                Console.SetCursorPosition(40, 11);
                Console.WriteLine("############ Ingresos ############");
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("**********************************");
                Console.SetCursorPosition(40, 14);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(">>>>>>>>>>>>>> MENÚ <<<<<<<<<<<<<<");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("[1]> Informacion de Nafta Premium");
                Console.SetCursorPosition(40, 17);
                Console.WriteLine("[2]> Informacion de Nafta Super");
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("[3]> Informacion de Gasoil");
                Console.SetCursorPosition(40, 19);
                Console.WriteLine("[4]> Suma Total");
                Console.SetCursorPosition(40, 20);
                Console.WriteLine("[5]> Salir");
                Console.SetCursorPosition(40, 22);
                Console.ForegroundColor = ConsoleColor.Green;

                try
                {
                   
                    Console.Write("> Ingrese una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            {
                                Console.Clear();
                                /********* MARCO *********/

                                Console.CursorVisible = false;

                                for (int V = 10; V <= 100; V++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.SetCursorPosition(V, 4);
                                    Console.Write("#");
                                    Console.SetCursorPosition(V, 30);
                                    Console.Write("#");

                                    for (int H = 4; H < 31; H++)
                                    {
                                        Console.SetCursorPosition(10, H);
                                        Console.WriteLine("$");
                                        Console.SetCursorPosition(100, H);
                                        Console.WriteLine("$");

                                    }
                                }//fin marco
                                Console.SetCursorPosition(34, 13);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(">>>>>>>>>>>>>>> NAFTA PREMIUM <<<<<<<<<<<<<<<<<");
                                Console.SetCursorPosition(34, 16);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"> Cantidad de litros en el tanque: {tanques[0]} litros");
                                Console.SetCursorPosition(34, 17);
                                Console.WriteLine($"> Cantidad de litros vendido:      {vendido_premium} litros");
                                Console.SetCursorPosition(34, 18);
                                Console.WriteLine($"> Precio por litro:                ${precio_premium}");
                                Console.SetCursorPosition(34, 19);
                                Console.WriteLine($"> Monto recaudado:                 ${tolalPremium}");
                                Console.SetCursorPosition(34, 21);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Enter para volver al MENÚ...");

                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                /********* MARCO *********/

                                Console.CursorVisible = false;

                                for (int V = 10; V <= 100; V++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.SetCursorPosition(V, 4);
                                    Console.Write("#");
                                    Console.SetCursorPosition(V, 30);
                                    Console.Write("#");

                                    for (int H = 4; H < 31; H++)
                                    {
                                        Console.SetCursorPosition(10, H);
                                        Console.WriteLine("$");
                                        Console.SetCursorPosition(100, H);
                                        Console.WriteLine("$");

                                    }
                                }//fin marco
                                Console.SetCursorPosition(34, 13);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(">>>>>>>>>>>>>>> NAFTA SUPER <<<<<<<<<<<<<<<<<");
                                Console.SetCursorPosition(34, 16);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"> Cantidad de litros en el tanque: {tanques[1]} litros");
                                Console.SetCursorPosition(34, 17);
                                Console.WriteLine($"> Cantidad de litros vendido:      {vendido_super} litros");
                                Console.SetCursorPosition(34, 18);
                                Console.WriteLine($"> Precio por litro:                ${precio_super}");
                                Console.SetCursorPosition(34, 19);
                                Console.WriteLine($"> Monto recaudado:                 ${tolalPremium}");
                                Console.SetCursorPosition(34, 21);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Enter para volver al MENÚ...");

                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                /********* MARCO *********/

                                Console.CursorVisible = false;

                                for (int V = 10; V <= 100; V++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.SetCursorPosition(V, 4);
                                    Console.Write("#");
                                    Console.SetCursorPosition(V, 30);
                                    Console.Write("#");

                                    for (int H = 4; H < 31; H++)
                                    {
                                        Console.SetCursorPosition(10, H);
                                        Console.WriteLine("$");
                                        Console.SetCursorPosition(100, H);
                                        Console.WriteLine("$");

                                    }
                                }//fin marco
                                Console.SetCursorPosition(34, 13);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(">>>>>>>>>>>>>>>>>> GASOIL <<<<<<<<<<<<<<<<<<<");
                                Console.SetCursorPosition(34, 16);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"> Cantidad de litros en el tanque: {tanques[2]} litros");
                                Console.SetCursorPosition(34, 17);
                                Console.WriteLine($"> Cantidad de litros vendido:      {vendido_gasoil} litros");
                                Console.SetCursorPosition(34, 18);
                                Console.WriteLine($"> Precio por litro:                ${precio_gasoil}");
                                Console.SetCursorPosition(34, 19);
                                Console.WriteLine($"> Monto recaudado:                 ${totalGasoil}");
                                Console.SetCursorPosition(34, 21);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Enter para volver al MENÚ...");

                                Console.ReadKey();
                                break;
                            }
                        case 4:
                            {

                                Console.Clear();
                                /********* MARCO *********/

                                Console.CursorVisible = false;

                                for (int V = 10; V <= 100; V++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.SetCursorPosition(V, 4);
                                    Console.Write("#");
                                    Console.SetCursorPosition(V, 30);
                                    Console.Write("#");

                                    for (int H = 4; H < 31; H++)
                                    {
                                        Console.SetCursorPosition(10, H);
                                        Console.WriteLine("$");
                                        Console.SetCursorPosition(100, H);
                                        Console.WriteLine("$");

                                    }
                                }//fin marco
                                Console.SetCursorPosition(30, 13);
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>> TOTAL <<<<<<<<<<<<<<<<<<<<<<<");
                                Console.SetCursorPosition(30, 16);
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"> Cantidad TOTAL de litros en los tanques: {totalTanques} litros");
                                Console.SetCursorPosition(30, 17);
                                Console.WriteLine($"> Cantidad TOTAL de litros vendido:        {totalLitrosV} litros");
                                Console.SetCursorPosition(30, 18);
                                Console.WriteLine($"> Monto TOTAL recaudado:                   ${totalRecaudado}");

                                Console.SetCursorPosition(30, 20);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Enter para volver al MENÚ...");


                                Console.ReadKey();
                                break;
                            }
                        case 5:
                            {
                                Console.Clear();
                                return;
                            }
                        default:
                            {
                                Console.SetCursorPosition(40, 24);
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Debes ingresar un numero >> 1, 2, 3, 4 o 5");
                                Console.SetCursorPosition(40, 25);
                                Console.WriteLine($"Enter para vorlver a intentar....");

                                Console.ReadKey();
                                break;
                            }
                    }
                }
                catch (Exception)
                {
                    Console.SetCursorPosition(40, 24);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Debes ingresar un numero >> 1, 2, 3, 4 o 5");
                    Console.SetCursorPosition(40, 25);
                    Console.WriteLine($"Enter para vorlver a intentar....");

                    Console.ReadKey();
                }
                             
            }
        }//fin metod ingresos
    }
}
