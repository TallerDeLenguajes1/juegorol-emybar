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

            Console.WindowWidth = 120;
            Console.WriteLine("\n\n");
            foreach (string line in arr)
            {
                Console.WriteLine(line);
                Console.ReadKey();
            }


            Console.WriteLine("3 planetas, 2 peleas. El ganador gana un asteroide y avanza al proximo planeta ");

            player1 = Personaje.crearpersonaje();
            player2 = Personaje.crearpersonaje();
            player3 = Personaje.crearpersonaje();

            listapersonajes.Add(player1);
            listapersonajes.Add(player2);
            listapersonajes.Add(player3);

            foreach (Personaje per in listapersonajes)
            {
                Console.WriteLine($"\t\n Nombre: {per.Nombre}");
                Console.WriteLine($" Edad: {per.Edad}");
                Console.WriteLine($" Nivel: {per.Nivel}");
                Console.WriteLine($" Tipo: {per.Tipo}");
                Console.WriteLine($" Salud: {per.Salud}");
                Console.WriteLine($" Fuerza: {per.Fuerza}");
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

            Console.WindowWidth = 120;
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
                    Console.WriteLine($"\t\nPelea {i}");
                    while (prim == seg)
                    {
                        seg = rand.Next(listapersonajes.Count);
                    }

                    ataque1 = Convert.ToInt32(listapersonajes[prim].valordanio());
                    ataque2 = Convert.ToInt32(listapersonajes[seg].valordanio());

                    Console.WriteLine("\t\nDanio {0}= {1}", listapersonajes[prim].Nombre, ataque1);
                    Console.WriteLine("Danio {0}= {1}", listapersonajes[seg].Nombre, ataque2);
                    listapersonajes[prim].Salud -= ataque2;
                    listapersonajes[seg].Salud -= ataque1;
                    Console.WriteLine("Salud {0}= {1}", listapersonajes[prim].Nombre, listapersonajes[prim].Salud);
                    Console.WriteLine("Salud {0}= {1} \n", listapersonajes[seg].Nombre, listapersonajes[seg].Salud);


                }
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                if (listapersonajes[prim].Salud < listapersonajes[seg].Salud)
                {
                    Vencedor = listapersonajes[seg].Nombre;
                    Console.WriteLine("El ganador es {0}  ", Vencedor);
                    Console.WriteLine("Premio  el asteroide: :");
                     GetAsteroides();
                    listapersonajes[seg].Salud = 100;
                    listapersonajes[seg].Fuerza += 1;
                    listapersonajes[seg].Armadura += 1;
                    listapersonajes.RemoveAt(prim);

                }
                else
                {
                    Vencedor = listapersonajes[prim].Nombre;
                    Console.WriteLine("El ganador es {0}  ", Vencedor);
                    Console.WriteLine("Premio el asteroide:");
                    GetAsteroides();
                    listapersonajes[prim].Salud = 100;
                    listapersonajes[prim].Fuerza += 1;
                    listapersonajes[prim].Armadura += 1;
                    listapersonajes.RemoveAt(seg);


                }
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");

                guardarvencedor("Ganador ", ".csv", listapersonajes[0]);

                Console.WriteLine("\t\n Caracteristicas  ");
                foreach (Personaje per in listapersonajes)
                {
                    Console.WriteLine($"\t\n Nombre: {per.Nombre}");
                    Console.WriteLine($" Edad: {per.Edad}");
                    Console.WriteLine($" Nivel: {per.Nivel}");
                    Console.WriteLine($" Tipo: {per.Tipo}");
                    Console.WriteLine($" Salud: {per.Salud}");
                    Console.WriteLine($" Fuerza: {per.Fuerza}");
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

            Console.WindowWidth = 120;
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
                Console.WriteLine($"\t\n Nombre: {per.Nombre}");
                Console.WriteLine($" Edad: {per.Edad}");
                Console.WriteLine($" Nivel: {per.Nivel}");
                Console.WriteLine($" Tipo: {per.Tipo}");
                Console.WriteLine($" Salud: {per.Salud}");
                Console.WriteLine($" Fuerza: {per.Fuerza}");
            }

            Console.WriteLine("Comienza la PELEA!!!\n");
            while (listapersonajes.Count != 1)
            {
                prim = rand.Next(listapersonajes.Count);
                seg = rand.Next(listapersonajes.Count);


                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"\t\nPelea {i}");
                    while (prim == seg)
                    {
                        seg = rand.Next(listapersonajes.Count);
                    }
                    if (listapersonajes[prim].Salud > 0 || listapersonajes[seg].Salud > 0)
                    {

                        ataque1 = Convert.ToInt32(listapersonajes[prim].valordanio());
                        ataque2 = Convert.ToInt32(listapersonajes[seg].valordanio());

                        Console.WriteLine("\t\nDanio {0}= {1}", listapersonajes[prim].Nombre, ataque1);
                        Console.WriteLine("Danio {0}= {1}", listapersonajes[seg].Nombre, ataque2);
                        listapersonajes[prim].Salud -= ataque2;
                        listapersonajes[seg].Salud -= ataque1;
                        Console.WriteLine("Salud {0}= {1}", listapersonajes[prim].Nombre, listapersonajes[prim].Salud);
                        Console.WriteLine("Salud {0}= {1} \n", listapersonajes[seg].Nombre, listapersonajes[seg].Salud);

                    }
                }
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                if (listapersonajes[prim].Salud < listapersonajes[seg].Salud)
                {
                    Vencedor = listapersonajes[seg].Nombre;
                    Console.WriteLine("El ganador es {0}  ", Vencedor);
                    Console.WriteLine("Premio el asteroide: :");
                    GetAsteroides();
                    listapersonajes[seg].Salud = 100;
                    listapersonajes[seg].Fuerza += 2;
                    listapersonajes[seg].Armadura += 1;
                    listapersonajes.RemoveAt(prim);

                }
                else
                {
                    Vencedor = listapersonajes[prim].Nombre;
                    Console.WriteLine("El ganador es {0}  ", Vencedor);
                    Console.WriteLine("Premio  el asteroide: :");
                    GetAsteroides();
                    listapersonajes[prim].Salud = 100;
                    listapersonajes[prim].Fuerza += 2;
                    listapersonajes[prim].Armadura += 1;
                    listapersonajes.RemoveAt(seg);


                }
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                guardarvencedor("Ganador ", ".csv", listapersonajes[0]);
                Console.WriteLine("\t\nCaracteristicas");
                foreach (Personaje per in listapersonajes)
                {
                    Console.WriteLine($"\t\n Nombre: {per.Nombre}");
                    Console.WriteLine($" Edad: {per.Edad}");
                    Console.WriteLine($" Nivel: {per.Nivel}");
                    Console.WriteLine($" Tipo: {per.Tipo}");
                    Console.WriteLine($" Salud: {per.Salud}");
                    Console.WriteLine($" Fuerza: {per.Fuerza}");
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

            Console.WindowWidth = 120;
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
                Console.WriteLine($"\t\n Nombre: {per.Nombre}");
                Console.WriteLine($" Edad: {per.Edad}");
                Console.WriteLine($" Nivel: {per.Nivel}");
                Console.WriteLine($" Tipo: {per.Tipo}");
                Console.WriteLine($" Salud: {per.Salud}");
                Console.WriteLine($" Fuerza: {per.Fuerza}");



            }

            Console.WriteLine("Comienza la PELEA!!!\n");
            while (listapersonajes.Count != 1)
            {
                prim = rand.Next(listapersonajes.Count);
                seg = rand.Next(listapersonajes.Count);


                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"\t\nPelea {i}");
                    while (prim == seg)
                    {
                        seg = rand.Next(listapersonajes.Count);
                    }
                    

                    if (listapersonajes[prim].Salud > 0 || listapersonajes[seg].Salud > 0)
                    {

                        ataque1 = Convert.ToInt32(listapersonajes[prim].valordanio());
                        ataque2 = Convert.ToInt32(listapersonajes[seg].valordanio());

                        Console.WriteLine("\t\nDanio {0}= {1}", listapersonajes[prim].Nombre, ataque1);
                        Console.WriteLine("Danio {0}= {1}", listapersonajes[seg].Nombre, ataque2);
                        listapersonajes[prim].Salud -= ataque2;
                        listapersonajes[seg].Salud -= ataque1;
                        Console.WriteLine("Salud {0}= {1}", listapersonajes[prim].Nombre, listapersonajes[prim].Salud);
                        Console.WriteLine("Salud {0}= {1} \n", listapersonajes[seg].Nombre, listapersonajes[seg].Salud);

                    }
                }
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                if (listapersonajes[prim].Salud < listapersonajes[seg].Salud)
                {
                    Vencedor = listapersonajes[seg].Nombre;
                    Console.WriteLine("El ganador es {0}  ", Vencedor);
                    Console.WriteLine("Premio  el asteroide::");
                    GetAsteroides();
                    listapersonajes[seg].Salud = 100;
                    listapersonajes[seg].Fuerza += 2;
                    listapersonajes[seg].Armadura += 1;
                    listapersonajes.RemoveAt(prim);

                }
                else
                {
                    Vencedor = listapersonajes[prim].Nombre;
                    Console.WriteLine("El ganador es {0}  ", Vencedor);
                    Console.WriteLine("Premio es :");
                    GetAsteroides();
                    listapersonajes[prim].Salud = 100;
                    listapersonajes[prim].Fuerza += 2;
                    listapersonajes[prim].Armadura += 1;
                    listapersonajes.RemoveAt(seg);


                }
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
                guardarvencedor("Ganador ", ".csv", listapersonajes[0]);
                Console.WriteLine("\t \n Caracteristicas del Ganador");
                foreach (Personaje per in listapersonajes)
                {
                    Console.WriteLine($"\t\n Nombre: {per.Nombre}");
                    Console.WriteLine($" Edad: {per.Edad}");
                    Console.WriteLine($" Nivel: {per.Nivel}");
                    Console.WriteLine($" Tipo: {per.Tipo}");
                    Console.WriteLine($" Salud: {per.Salud}");
                    Console.WriteLine($" Fuerza: {per.Fuerza}");
                }
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");
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

        private static List<Asteroide> GetAsteroides()
        {
            var url = $"http://asterank.com/api/mpc";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "aplicattion/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream()) {

                        if (strReader != null)
                        {
                            using (StreamReader objReader = new StreamReader(strReader))
                            {
                                string responseBody = objReader.ReadToEnd();
                               List<Asteroide> aste = JsonSerializer.Deserialize<List<Asteroide>>(responseBody);
                                var rand = new Random();
                                int index = rand.Next(aste.Count);
                                Console.WriteLine(aste[index].ReadableDes);
                            }
                        }
                    }

                }
            }catch(WebException ex)
            {
                throw;
            }
            return null;
       }
    }
}

        
        
    

