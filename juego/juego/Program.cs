using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net;

namespace juego
{
    class Program
    {
        static void Main(string[] args)
        {

            Get(); 

            List<Personaje> listapersonajes = new List<Personaje>();
            Random rand = new Random();

            Personaje player1;
            Personaje player2;
            Personaje player3;
            Personaje player4;
            Personaje player5;
            Personaje player6;
            Personaje player7;

            int prim;
            int seg;
            int ataque1;
            int ataque2;
            string Vencedor;

            var arr = new[]
            {
                @"___.   .__                                 .__    .___ ",
                @"\_ |__ |__| ____   _______  __ ____   ____ |__| __| _/_",
                @" | __ \|  |/ __ \ /    \  \/ // __ \ /    \|  |/ __ |/  _ \ ",
                @" | \_\ \  \  ___/|   |  \   /\  ___/|   |  \  / /_/ (  <_> )",
                @" |_ __ /__|\___  >___|  /\_/  \___  >___|  /__\____ |\____/",
                @"     \/        \/     \/          \/     \/        \/   ",
            };

            Console.WindowWidth = 169;
            Console.WriteLine("\n\n");
            foreach (string line in arr)
            {
                Console.WriteLine(line);
                Console.ReadKey();
            }


            Console.WriteLine("3 planetas, 2 peleas. El ganador avanza al proximo planeta ");

            player1 = Personaje.crearpersonaje();
            player2 = Personaje.crearpersonaje();
            player3 = Personaje.crearpersonaje();

            listapersonajes.Add(player1);
            listapersonajes.Add(player2);
            listapersonajes.Add(player3);

            foreach (Personaje per in listapersonajes)
            {
                Console.WriteLine("\t\nNombre:");
                Console.WriteLine(per.Nombre);
                Console.WriteLine("Edad:");
                Console.WriteLine(per.Edad);
                Console.WriteLine("Nivel:");
                Console.WriteLine(per.Nivel);
                Console.WriteLine("Salud:");
                Console.WriteLine(per.Salud);
                Console.WriteLine("Fuerza");
                Console.WriteLine(per.Fuerza);
            }

            var arr1 = new[]
            {
                  @"                                 _      ",
                  @"  /\/\   ___ _ __ ___ _   _ _ __(_) ___ ",
                  @" /    \ / _ \ '__/ __| | | | '__| |/ _ \",
                  @"/ /\/\ \  __/ | | (__| |_| | |  | | (_) |",
                  @"\/    \/\___|_|  \___|\__,_|_|  |_|\___/",
                  @"                                        ",
            };

            Console.WindowWidth = 169;
            Console.WriteLine("\n\n");
            foreach (string lin in arr1)
            {
                Console.WriteLine(lin);
                Console.ReadKey();
            }

            Console.WriteLine("Comienza la PELEA!!!\n");

            while (listapersonajes.Count != 1)
            {
                prim = rand.Next(listapersonajes.Count);
                seg = rand.Next(listapersonajes.Count);


                for (int i = 0; i < 2; i++)
                {
                    while (prim == seg)
                    {
                        seg = rand.Next(listapersonajes.Count);
                    }

                    ataque1 = Convert.ToInt32(listapersonajes[prim].valordanio());
                    ataque2 = Convert.ToInt32(listapersonajes[seg].valordanio());

                    Console.WriteLine("Danio {0}= {1}", listapersonajes[prim].Nombre, ataque1);
                    Console.WriteLine("Danio {0}= {1}", listapersonajes[seg].Nombre, ataque2);
                    listapersonajes[prim].Salud -= ataque2;
                    listapersonajes[seg].Salud -= ataque1;
                    Console.WriteLine("Salud {0}= {1}", listapersonajes[prim].Nombre, listapersonajes[prim].Salud);
                    Console.WriteLine("Salud {0}= {1} \n", listapersonajes[seg].Nombre, listapersonajes[seg].Salud);


                }
                if (listapersonajes[prim].Salud < listapersonajes[seg].Salud)
                {
                    Vencedor = listapersonajes[seg].Nombre;
                    Console.WriteLine("El ganador es{0}  ", Vencedor);
                    listapersonajes[seg].Salud = 100;
                    listapersonajes[seg].Fuerza += 1;
                    listapersonajes[seg].Armadura += 1;
                    listapersonajes.RemoveAt(prim);

                }
                else
                {
                    Vencedor = listapersonajes[prim].Nombre;
                    Console.WriteLine("El ganador es {0}  ", Vencedor);
                    listapersonajes[prim].Salud = 100;
                    listapersonajes[prim].Fuerza += 1;
                    listapersonajes[prim].Armadura += 1;
                    listapersonajes.RemoveAt(seg);


                }

              

                guardarvencedor("Ganador ", ".csv", listapersonajes[0]);


                foreach (Personaje per in listapersonajes)
                {
                    Console.WriteLine("\t\nNombre:");
                    Console.WriteLine(per.Nombre);
                    Console.WriteLine("Edad:");
                    Console.WriteLine(per.Edad);
                    Console.WriteLine("Nivel:");
                    Console.WriteLine(per.Nivel);
                    Console.WriteLine("Salud:");
                    Console.WriteLine(per.Salud);
                    Console.WriteLine("Fuerza");
                    Console.WriteLine(per.Fuerza);
                }

            }

            var arr2 = new[]
           {
                  @"___  ___           _     ",
                  @"|  \/  |          | |      ",
                  @"| .  . | __ _ _ __| |_ ___",
                  @"| |\/| |/ _` | '__| __/ _ \",
                  @"| |  | | (_| | |  | ||  __/",
                  @"\_|  |_/\__,_|_|   \__\___|",
                  @"                           ",
            };

            Console.WindowWidth = 169;
            Console.WriteLine("\n\n");
            foreach (string li in arr2)
            {
                Console.WriteLine(li);
                Console.ReadKey();
            }
            player4 = Personaje.crearpersonaje();
            player5 = Personaje.crearpersonaje();
            listapersonajes.Add(player4);
            listapersonajes.Add(player5);

            foreach (Personaje per in listapersonajes)
            {
                Console.WriteLine("\t\nNombre:");
                Console.WriteLine(per.Nombre);
                Console.WriteLine("Edad:");
                Console.WriteLine(per.Edad);
                Console.WriteLine("Nivel:");
                Console.WriteLine(per.Nivel);
                Console.WriteLine("Salud:");
                Console.WriteLine(per.Salud);
                Console.WriteLine("Fuerza");
                Console.WriteLine(per.Fuerza);
            }

            Console.WriteLine("Comienza la PELEA!!!\n");
            while (listapersonajes.Count != 1)
            {
                prim = rand.Next(listapersonajes.Count);
                seg = rand.Next(listapersonajes.Count);


                for (int i = 0; i < 2; i++)
                {
                    while (prim == seg)
                    {
                        seg = rand.Next(listapersonajes.Count);
                    }
                    if (listapersonajes[prim].Salud > 0 || listapersonajes[seg].Salud > 0)
                    {

                        ataque1 = Convert.ToInt32(listapersonajes[prim].valordanio());
                        ataque2 = Convert.ToInt32(listapersonajes[seg].valordanio());

                        Console.WriteLine("Danio {0}= {1}", listapersonajes[prim].Nombre, ataque1);
                        Console.WriteLine("Danio {0}= {1}", listapersonajes[seg].Nombre, ataque2);
                        listapersonajes[prim].Salud -= ataque2;
                        listapersonajes[seg].Salud -= ataque1;
                        Console.WriteLine("Salud {0}= {1}", listapersonajes[prim].Nombre, listapersonajes[prim].Salud);
                        Console.WriteLine("Salud {0}= {1} \n", listapersonajes[seg].Nombre, listapersonajes[seg].Salud);

                    }
                }
                if (listapersonajes[prim].Salud < listapersonajes[seg].Salud)
                {
                    Vencedor = listapersonajes[seg].Nombre;
                    Console.WriteLine("El ganador es{0}  ", Vencedor);
                    listapersonajes[seg].Salud = 100;
                    listapersonajes[seg].Fuerza += 2;
                    listapersonajes[seg].Armadura += 1;
                    listapersonajes.RemoveAt(prim);

                }
                else
                {
                    Vencedor = listapersonajes[prim].Nombre;
                    Console.WriteLine("El ganador es {0}  ", Vencedor);
                    listapersonajes[prim].Salud = 100;
                    listapersonajes[prim].Fuerza += 2;
                    listapersonajes[prim].Armadura += 1;
                    listapersonajes.RemoveAt(seg);


                }

                guardarvencedor("Ganador ", ".csv", listapersonajes[0]);
                foreach (Personaje per in listapersonajes)
                {
                    Console.WriteLine("\t\nNombre:");
                    Console.WriteLine(per.Nombre);
                    Console.WriteLine("Edad:");
                    Console.WriteLine(per.Edad);
                    Console.WriteLine("Nivel:");
                    Console.WriteLine(per.Nivel);
                    Console.WriteLine("Salud:");
                    Console.WriteLine(per.Salud);
                    Console.WriteLine("Fuerza");
                    Console.WriteLine(per.Fuerza);
                }

            }


            var arr3 = new[]
          {
                 @"   __              _ _            ",
                 @"   \ \ _   _ _ __ (_) |_ ___ _ __",
                 @"    \ \ | | | '_ \| | __/ _ \ '__|",
                 @" /\_/ / |_| | |_) | | ||  __/ |  ",
                 @" \___/ \__,_| .__/|_|\__\___|_|  ",
                 @"            |_|                 ",
               
            };

            Console.WindowWidth = 169;
            Console.WriteLine("\n\n");
            foreach (string li2 in arr3)
            {
                Console.WriteLine(li2);
                Console.ReadKey();
            }
            player6 = Personaje.crearpersonaje();
            player7 = Personaje.crearpersonaje();
            listapersonajes.Add(player6);
            listapersonajes.Add(player7);

            foreach (Personaje per in listapersonajes)
            {
                Console.WriteLine("\t\nNombre:");
                Console.WriteLine(per.Nombre);
                Console.WriteLine("Edad:");
                Console.WriteLine(per.Edad);
                Console.WriteLine("Nivel:");
                Console.WriteLine(per.Nivel);
                Console.WriteLine("Salud:");
                Console.WriteLine(per.Salud);
                Console.WriteLine("Fuerza");
                Console.WriteLine(per.Fuerza);
            }

            Console.WriteLine("Comienza la PELEA!!!\n");
            while (listapersonajes.Count != 1)
            {
                prim = rand.Next(listapersonajes.Count);
                seg = rand.Next(listapersonajes.Count);


                for (int i = 0; i < 2; i++)
                {
                    while (prim == seg)
                    {
                        seg = rand.Next(listapersonajes.Count);
                    }
                    if (listapersonajes[prim].Salud > 0 || listapersonajes[seg].Salud > 0)
                    {

                        ataque1 = Convert.ToInt32(listapersonajes[prim].valordanio());
                        ataque2 = Convert.ToInt32(listapersonajes[seg].valordanio());

                        Console.WriteLine("Danio {0}= {1}", listapersonajes[prim].Nombre, ataque1);
                        Console.WriteLine("Danio {0}= {1}", listapersonajes[seg].Nombre, ataque2);
                        listapersonajes[prim].Salud -= ataque2;
                        listapersonajes[seg].Salud -= ataque1;
                        Console.WriteLine("Salud {0}= {1}", listapersonajes[prim].Nombre, listapersonajes[prim].Salud);
                        Console.WriteLine("Salud {0}= {1} \n", listapersonajes[seg].Nombre, listapersonajes[seg].Salud);

                    }
                }
                if (listapersonajes[prim].Salud < listapersonajes[seg].Salud)
                {
                    Vencedor = listapersonajes[seg].Nombre;
                    Console.WriteLine("El ganador es{0}  ", Vencedor);
                    listapersonajes[seg].Salud = 100;
                    listapersonajes[seg].Fuerza += 2;
                    listapersonajes[seg].Armadura += 1;
                    listapersonajes.RemoveAt(prim);

                }
                else
                {
                    Vencedor = listapersonajes[prim].Nombre;
                    Console.WriteLine("El ganador es {0}  ", Vencedor);
                    listapersonajes[prim].Salud = 100;
                    listapersonajes[prim].Fuerza += 2;
                    listapersonajes[prim].Armadura += 1;
                    listapersonajes.RemoveAt(seg);


                }
                guardarvencedor("Ganador ", ".csv", listapersonajes[0]);
                foreach (Personaje per in listapersonajes)
                {
                    Console.WriteLine("\t\nNombre:");
                    Console.WriteLine(per.Nombre);
                    Console.WriteLine("Edad:");
                    Console.WriteLine(per.Edad);
                    Console.WriteLine("Nivel:");
                    Console.WriteLine(per.Nivel);
                    Console.WriteLine("Salud:");
                    Console.WriteLine(per.Salud);
                    Console.WriteLine("Fuerza");
                    Console.WriteLine(per.Fuerza);
                }

                }
            void guardarvencedor(string nombArchivo, string formato, Personaje vencedor)
            {
                FileStream Archivo = new FileStream(nombArchivo + formato, FileMode.Create);
                using (StreamWriter strWrite = new StreamWriter(Archivo))
                {
                    foreach (Personaje personaje in listapersonajes)
                    {
                        strWrite.WriteLine("{0};{1};{2}", vencedor.Nombre, vencedor.Tipo, vencedor.Edad);

                    }
                    strWrite.Close();
                }
            }
        }

        private static void Get()
        {
            var url= $"https://binaryjazz.us/wp-json/genrenator/v1/story/";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "aplicattion/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream()) {

                        if (strReader == null) return;
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                                List<> ListHistorias = JsonSerializer.Deserialize<List<story>>(responseBody);
                     
                            }
                        }
                    }

                }
            }
        }
    }
}

        
        
    

