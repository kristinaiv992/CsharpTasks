using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristicAgency
{
    public class Program
    {
        static void Main(string[] args)
        {
            int CHOOSE;

            Salter salter1 = new Salter(1);
            Salter salter2 = new Salter(2);
            Salter salter3 = new Salter(3);

            TouristicAgency World = new TouristicAgency("World");
            World.AddShalter(salter1);
            World.AddShalter(salter2);
            World.AddShalter(salter3);

            Console.WriteLine($"Herzlich Willkommen in unserem Reisebüro {World.getIme()}");

            while(true)
            {
                Console.WriteLine("Pritisnete 1 za kupuvanje karta");
                Console.WriteLine("Pritisnete 2 za prodadeni karti od izbran salter");
                Console.WriteLine("Pritisnete 3 za vkupen promet od izbran salter");
                Console.WriteLine("Pritisnete 4 za prodadeni karti od agencija");
                Console.WriteLine("Pritisnete 5 za vkupen promet od agencijata");
                Console.WriteLine("Pritisnete 6 za uspeh na agencija");
                Console.WriteLine("Pritisnete 7 za izlez");
                CHOOSE = int.Parse(Console.ReadLine());

                if (CHOOSE == 1)
                {
                    Console.WriteLine("Konnen Sie bitte deine vorname, name und jahre sagen?");
                    string klient = Console.ReadLine();
                    Console.WriteLine("Vneste ja destinacijata");
                    string dest = Console.ReadLine();
                    Console.WriteLine("Vnesete broj na salter (1, 2 ili 3)");
                    int brNaSalter = int.Parse(Console.ReadLine());
                    if (brNaSalter == 1)
                    {
                        Console.WriteLine(klient);
                        Console.WriteLine(salter1.KupiKarta(dest));
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else if (brNaSalter == 2)
                    {
                        Console.WriteLine(klient);
                        Console.WriteLine(salter2.KupiKarta(dest));
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else if (brNaSalter == 3)
                    {
                        Console.WriteLine(klient);
                        Console.WriteLine(salter3.KupiKarta(dest));
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Entschuldigung ein Fehler ist gemacht!");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }
                else if (CHOOSE == 2)
                {
                    Console.WriteLine("Vnesete broj na salter?");
                    int brSalter = int.Parse(Console.ReadLine());
                    if (brSalter == 1)
                    {
                        salter1.getKartiOdSalter();
                        Console.WriteLine("------------------------------------------");
                    }
                    else if (brSalter == 2)
                    {
                        salter2.getKartiOdSalter();
                        Console.WriteLine("------------------------------------------");
                    }
                    else if (brSalter == 1)
                    {
                        salter3.getKartiOdSalter();
                        Console.WriteLine("------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Gresen broj na salter");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                }

                else if (CHOOSE == 3)
                {
                    Console.WriteLine("Vnesete broj na salter?");
                    int brSalter = int.Parse(Console.ReadLine());
                    if (brSalter == 1)
                    {
                        salter1.getPrometOdProdadeniKartiPoSalter();
                        Console.WriteLine("------------------------------------------");
                    }
                    else if (brSalter == 2)
                    {
                        salter2.getPrometOdProdadeniKartiPoSalter();
                        Console.WriteLine("------------------------------------------");
                    }
                    else if (brSalter == 1)
                    {
                        salter3.getPrometOdProdadeniKartiPoSalter();
                        Console.WriteLine("------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Gresen broj na salter");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------");
                    }
                }
                else if (CHOOSE == 4)
                {
                    World.ProdadeniKartiOdAgencijata();
                    Console.WriteLine("------------------------------------------");
                }

                else if (CHOOSE == 5)
                {
                    World.VkupenPrometOdAgencijata();
                    Console.WriteLine("------------------------------------------");
                }
                else if(CHOOSE == 6)
                {
                    World.UspeshnostnaAgencijata();
                    Console.WriteLine("------------------------------------------");
                }
                else if (CHOOSE == 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Gresen Vlez");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }



            }
        }
    }
}
