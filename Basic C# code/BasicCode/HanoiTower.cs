﻿namespace OnlineApp
{
    internal class HanoiTower
    {
        static void Main(string[] args)
        {

            string kostka0 = "          ";
            string kostka1 = "    ██    ";
            string kostka2 = "   ████   ";
            string kostka3 = "  ██████  ";
            string kostka4 = " ████████ ";
            string kostka5 = "██████████";

            Stack<int> prvni = new Stack<int>();
            Stack<int> druha = new Stack<int>();
            Stack<int> treti = new Stack<int>();

            prvni.Push(5);
            prvni.Push(4);
            prvni.Push(3);
            prvni.Push(2);
            prvni.Push(1);

            Queue<int> copyPrvni = new Queue<int>();
            Queue<int> copyDruha = new Queue<int>();
            Queue<int> copyTreti = new Queue<int>();


            while (true)
            {
                copyPrvni.Clear();
                copyDruha.Clear();
                copyTreti.Clear();

                NaplnKopie(ref copyPrvni, prvni);
                NaplnKopie(ref copyDruha, druha);
                NaplnKopie(ref copyTreti, treti);

                Vykresli();

                if (druha.Count == 5) break;

                Console.Write("Přesunout kotouč z věže: ");
                int zVeze = Convert.ToInt32(Console.ReadLine());
                Console.Write("Přesunout kotouč na věž: ");
                int naVez = Convert.ToInt32(Console.ReadLine());
                
                Prendej(zVeze, naVez);

            }
            Console.WriteLine("Vyhrál jsi!");


            void NaplnKopie(ref Queue<int> a, Stack<int> b)
            {
                for (int i = 0; i < (5 - b.Count); i++)
                {
                    a.Enqueue(0);
                }
                foreach (var item in b)
                {
                    a.Enqueue(item);
                }
            }

            void Vykresli()
            {
                Console.Clear();
                Console.WriteLine("1         " + "2" + "         3");

                for (int i = 0; i < 5; i++)
                {
                    VykresliRadek(copyPrvni);
                    VykresliRadek(copyDruha);
                    VykresliRadek(copyTreti);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            void VykresliRadek(Queue<int> vykreslenaQueve)
            {
                switch (vykreslenaQueve.Dequeue())
                {
                    case 0:
                        Console.Write(kostka0);
                        break;
                    case 1:
                        Console.Write(kostka1);
                        break;
                    case 2:
                        Console.Write(kostka2);
                        break;
                    case 3:
                        Console.Write(kostka3);
                        break;
                    case 4:
                        Console.Write(kostka4);
                        break;
                    case 5:
                        Console.Write(kostka5);
                        break;
                    default:
                        break;
                }
            }
        

            void Prendej(int z, int na)
            {
                Stack<int> vezZ = z== 1 ? prvni : (z == 2) ? druha : treti;
                Stack<int> vezNa = na == 1 ? prvni : (na == 2) ? druha : treti;

                if (vezZ.Count > 0)
                {
                    if (vezNa.Count == 0)
                    {
                        vezNa.Push(vezZ.Pop());
                    }
                    else
                    {
                        if (vezZ.Peek() < vezNa.Peek())
                        {
                            vezNa.Push(vezZ.Pop());
                        }
                    }
                }
            }




        }
    }
}