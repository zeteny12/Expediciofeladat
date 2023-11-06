using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace radio
{
    internal class Program
    {
        public struct Adatok
        {
            public int napszam;
            public int radiosid;
            public string uzenet;
        }

        //6. feladat
        public static bool szame(string szo)
        {
            bool valasz = true;
            for (int i = 0; i < szo.Length; i++)
            {
                if (szo[i] < '0' || szo[i] > '9')
                {
                    valasz = false;
                }
            }

            return valasz;
        }
        static void Main(string[] args)
        {
            //1. feladat
            Adatok adatok;
            List<Adatok> lista = new List<Adatok>();
            string sor;
            StreamReader sr = new StreamReader("veetel.txt");
            while (!sr.EndOfStream)
            {
                sor = sr.ReadLine();
                adatok.napszam = int.Parse(sor.Split(' ')[0]);
                adatok.radiosid = int.Parse(sor.Split(' ')[1]);
                adatok.uzenet = sr.ReadLine();
                lista.Add(adatok);
            }
            sr.Close();

            //2. feladat
            Console.WriteLine("2. feladat:\nAz első üzenet rögzítője: " + lista[0].radiosid + "\nAz utolsó üzenet rögzítője: " + lista[lista.Count - 1].radiosid + "\n");

            //3. feladat
            Console.WriteLine("3. feladat:");
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].uzenet.Contains("farkas"))
                {
                    Console.WriteLine(lista[i].napszam + ". nap " + lista[i].radiosid + ". rádióamatőr");
                }
            }

            //4. feladat
            Console.WriteLine("\n4. feladat:");
            int[] radio_naponta = new int[11];
            for (int i = 0; i < lista.Count; i++)
            {
                radio_naponta[lista[i].napszam - 1]++;
            }
            for (int i = 0; i < radio_naponta.Length; i++)
            {
                Console.WriteLine(i + 1 + ". nap: " + radio_naponta[i] + " rádióamatőr");
            }

            //5. feladat
            StreamWriter sw = new StreamWriter("adaas.txt");

            //7. feladat
            Console.WriteLine("\n7. feladat:");
            Console.Write("Add meg a napnak a sorszámát:");
            int nap_sorszama = int.Parse(Console.ReadLine());
            Console.Write("Add meg a rádióamatőrnek is a sorszámát:");
            int radioamator_sorszam = int.Parse(Console.ReadLine());



            Console.ReadKey();
        }
    }
}
