using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuiz
{
    class Player
    {
        string PlayerName;        

        public void printPlayerName()
        {
            Console.WriteLine("Please insert your name");
            PlayerName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Ok " + PlayerName + " Let's Start the Quiz!!");
        }

    }

    class Soal
    {
        string Jawaban1;
        string Jawaban2;
        int skor;

        public void soal1()
        {
            Console.WriteLine("1. Fungi dari CSS adalah...");
            Console.WriteLine("\n a. menyimpan data");
            Console.WriteLine("\n b. mendesain tampilan website");
            Console.WriteLine("\n c. membuat code");
            Console.WriteLine("");
            Console.WriteLine("Jawab : ");
            Jawaban1 = Console.ReadLine();

            if (Jawaban1 == "b")
            {
                skor =+ 1;
                Console.WriteLine(skor);
            }
            else
            {
                Console.WriteLine(skor);
            }
        }

        public void soal2()
        {
            Console.WriteLine("1. Tes 2");
            Console.WriteLine("\n a. ");
            Console.WriteLine("\n b. ");
            Console.WriteLine("\n c. ");
            Console.WriteLine("");
            Console.WriteLine("Jawab : ");
            Jawaban2 = Console.ReadLine();

            if (Jawaban2 == "a")
            {
                skor = +1;
                Console.WriteLine(skor);
            }
            else
            {
                Console.WriteLine(skor);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO!!");
            Console.WriteLine("Welcome to Quizan!");
            Console.WriteLine("");

            Player player = new Player();
            player.printPlayerName();

            Console.WriteLine("");

            Soal soal = new Soal();
            soal.soal1();
            Console.WriteLine("");
            soal.soal2();
        }
    }
}
