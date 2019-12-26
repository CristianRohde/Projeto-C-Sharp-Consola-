using System;
using System.Collections;
using System.Collections.Generic;

namespace Projeto_C_Sharp_Consola_Cristian
{
    class Program
    {
        static void Main(string[] args)
        {
            Gestante gestante = new Gestante();
            Idoso idoso = new Idoso();

            ArrayList listaGestante = new ArrayList();
            ArrayList listaIdoso = new ArrayList();

            int a, cont;
            string s, h = null;
            do
            {
                cont = 0;
                Console.WriteLine("\n---Usuario--- " +
                    "\n -Digite 1 para Cadastrar Gestante" +
                    "\n -Digite 2 para Cadastrar Idoso" +
                    "\n -Digite 3 para Marcar Consulta de Gestante" +
                    "\n -Digite 4 para Marcar Consulta de Idoso" +
                    "\n -Digite 5 para Ver lista de Gestante" +
                    "\n -Digite 6 para Ver lista de Idoso" +
                    "\n -Digite 7 para Sair");
                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine("\n ---Usuario digite o nome do Paciente:");
                        s = Console.ReadLine();
                        listaGestante.Add(s);
                        break;
                    case 2:
                        Console.WriteLine("\n ---Usuario digite o nome do Paciente:");
                        s = Console.ReadLine();
                        listaIdoso.Add(s);
                        break;
                    case 3:
                        Console.WriteLine("\n ---Usuario digite o nome do Paciente:");
                        s = Console.ReadLine();

                        for (int l = 0; l < listaGestante.Count; l++)
                        {
                            string x = Convert.ToString(listaGestante[l]);
                            if (x == s)
                            {
                                cont ++;
                                Console.WriteLine("\n ---Digite o horario da Consulta:");
                                h = Console.ReadLine();
                                gestante.MarcaConsulta(listaGestante[l], h);
                                gestante.SendoAtendida(h, listaGestante[l]);
                            }
                        }
                        if (cont == 0) 
                        { 
                            Console.WriteLine("\n ¡¡¡Paciente nao achado!!!");                                                   
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n ---Usuario digite o nome do Paciente:");
                        s = Console.ReadLine();

                        for (int l = 0; l < listaIdoso.Count; l++)
                        {
                            string x = Convert.ToString(listaIdoso[l]);
                            if (x == s)
                            {
                                cont++;
                                Console.WriteLine("\n ---Digite o horario da Consulta:");
                                h = Console.ReadLine();
                                idoso.MarcaConsulta(listaIdoso[l], h);
                                idoso.SendoAtendida(h, listaIdoso[l]);
                            }
                        }
                        if (cont == 0)
                        {
                            Console.WriteLine("\n ¡¡¡Paciente nao achado!!!");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\n ---Lista de Gestante:");
                        for (int i = 0; i < listaGestante.Count; i++)
                        {
                            Console.WriteLine("--->   " + listaGestante[i]);
                        }
                        break;
                    case 6:
                        Console.WriteLine("\n ---Lista de Gestante:");
                        for (int i = 0; i < listaIdoso.Count; i++)
                        {
                            Console.WriteLine("--->   " + listaIdoso[i]);
                        }
                        break;
                }
            } while (a != 7);            
        }
    }
    abstract class Paciente
    {
        public abstract void MarcaConsulta(object nome, string hora);
        public abstract void SendoAtendida(string hora, object nome);
    }

    class Gestante : Paciente
    {
        public override void MarcaConsulta(object nome, string hora)
        {
            Console.WriteLine("Gestante "+ nome +" com consulta marcada as " + hora + " horas.");
        }

        public override void SendoAtendida(string hora, object nome)
        {
            Console.WriteLine("Horario actual "+ hora +" horas. Gestante " + nome + " sendo atendida.");
        }
    }

    class Idoso : Paciente
    {
        public override void MarcaConsulta(object nome, string hora)
        {
            Console.WriteLine("Idoso " + nome + " com consulta marcada as " + hora + " horas.");
        }

        public override void SendoAtendida(string hora, object nome)
        {
            Console.WriteLine("Horario actual " + hora + " horas. Idoso " + nome + " sendo atendido/a.");
        }
    }

}
