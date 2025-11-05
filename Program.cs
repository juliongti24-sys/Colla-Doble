using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaDoble
{
    internal class Program
    {
        static int frente1 = -1, final1 = -1;
        static int frente2, final2;
        static int n, op;
        static int[] cola;
        static char resp = 's';

        static public void encolarDerecha()
        {
            int dato;
            if (final2 - 1 == final1)
            {
                Console.WriteLine("Cola llena por el lado derecho");
            }
            else
            {
                if (frente2 == n && final2 == n)
                {
                    frente2 = n - 1; 
                }
                Console.WriteLine("Ingresa el dato a encolar por la derecha: ");
                dato = Convert.ToInt32(Console.ReadLine());
                final2--;
                cola[final2] = dato;
                Console.WriteLine("Dato encolado por la derecha");
            }
        }

        static public void encolarIzquierda()
        {
            int dato;
            if (final1 + 1 == final2)
            {
                Console.WriteLine("Cola llena por el lado izquierdo");
            }
            else
            {
                if (frente1 == -1 && final1 == -1)
                {
                    frente1 = 0;
                }
                Console.WriteLine("Ingresa el dato a encolar por la izquierda: ");
                dato = Convert.ToInt32(Console.ReadLine());
                final1++;
                cola[final1] = dato;
                Console.WriteLine("Dato encolado por la izquierda");
            }
        }

        static public void desencolarIzquierda()
        {
            if (frente1 == -1 && final1 == -1)
            {
                Console.WriteLine("Cola vacía por el lado izquierdo");
            }
            else
            {
                if (frente1 == final1)
                {
                    frente1 = -1; 
                    final1 = -1;
                }
                frente1++;
                Console.WriteLine("Dato desencolado por la izquierda");
            }
        }

        static public void desencolarDerecha()
        {
            if (frente2 == n && final2 == n)
            {
                Console.WriteLine("Cola vacía por el lado derecho");
            }
            else
            {
                if (frente2 == final2)
                {
                    frente1 = n;
                    final1 = n;
                }
                frente2--;
                Console.WriteLine("Dato desencolado por la derecha");
            }
        }

        static public void mostrar()
        {
            if (frente1 == -1 && frente2 == n)
            {
                Console.WriteLine("Cola vacía");
            }
            else
            {
                if (frente1 == -1)
                {
                    Console.WriteLine("Cola vacia por la izquierda");
                }
                else
                {
                    Console.Write("Frente1 -> [");
                    for (int i = frente1; i <= final1; i++)
                    {
                        Console.Write(cola[i]+" ");
                    }
                    Console.WriteLine("] <- Fianl1");

                }

                if (frente2 == n)
                {
                    Console.WriteLine("Cola vacia por la derecha");
                }
                else
                {
                    Console.Write("Frente2 -> [");
                    for (int i = frente2; i >= final2; i--)
                    {
                        Console.Write(cola[i] + " ");
                    }
                    Console.WriteLine("] <- Fianl2");

                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el tamaño de la cola          ");
            n = Convert.ToInt32(Console.ReadLine());

            frente2 = n;
            final2 = n;
            cola = new int[n];

            //while (resp!= 'n')
            //{

            //}
            while (resp != 'n')
            {
                Console.WriteLine("Ingrese la opción");
                Console.WriteLine("1. Encolar por la derecha");
                Console.WriteLine("2. Encolar por la izquierda");
                Console.WriteLine("3. Dncolar por la derecha");
                Console.WriteLine("4. Dencolar por la izquierda");
                Console.WriteLine("5. Mostrar los datos de la cola");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        encolarDerecha();
                        break;
                    case 2:
                        encolarIzquierda();
                        break;
                    case 3:
                        desencolarDerecha();
                        break;
                    case 4:
                        desencolarIzquierda();
                        break;
                    case 5:
                        mostrar();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                Console.WriteLine(" \n Desea continuar s/n");
                resp = Convert.ToChar(Console.ReadLine());
            }
        }
    }
}
