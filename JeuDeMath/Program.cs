using System;

namespace JeuDeMath
{
    class Program
    {
        enum e_Operateur
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SOUSTRACTION = 3

        }
        static void Main(string[] args)
        {
            
            const int NUMBER_MIN = 1;
            const int NUMBER_MAX = 10;
            const int NB_QUESTION = 4;
           
            int point = 0;

                for(int i = 0; i < NB_QUESTION ; i++)
                {
              
                    Console.WriteLine("Question n° "+ (i+1) +" / "+ NB_QUESTION);
                    bool responseGood = PoserQuestion(NUMBER_MIN,NUMBER_MAX);
                    if (responseGood)
                    {
                    Console.WriteLine("Bonne réponse");
                    point++;
                    }
                    else
                    {
                    Console.WriteLine("Mauvaise réponse");
                    }
              
                    Console.WriteLine();

                }
            Console.WriteLine("Nombre de points : "+point+" / "+ NB_QUESTION);

            int moyenne = NB_QUESTION / 2;
            if(point == NB_QUESTION)
            {
                Console.WriteLine("100% de réussite excellent");
            } 
            else if(point == 0)
            {
                Console.WriteLine("Révisez vos math !");
            }
            else if(point <= moyenne)
            {
                Console.WriteLine("Peut mieux faire");
            }
            else
            {
                Console.WriteLine("Pas mal");
            }
          
            


          
        }

        static bool PoserQuestion(int min ,int max)
        {
            

            Random rand = new Random();
            int a = rand.Next(min, max + 1);
            int b = rand.Next(min, max + 1);
            e_Operateur o = (e_Operateur)rand.Next(1, 3);
            int resultAttendu;

            int intResponse = 0;
           
            while(true)
            {
                switch(o)
                {
                    case e_Operateur.ADDITION:
                        Console.WriteLine(a + " + " + b + " = ");
                        resultAttendu = a + b;
                        break;

                    case e_Operateur.MULTIPLICATION:
                        Console.WriteLine(a + " x " + b + " = ");
                        resultAttendu = a * b;
                        break;

                    case e_Operateur.SOUSTRACTION:
                        Console.WriteLine(a + " - " + b + " = ");
                        resultAttendu = a - b;
                        break;
                    default:
                        // Cas incconu
                        Console.WriteLine("ERROR : operateur incconu");
                        return false;



                }

                string response = Console.ReadLine();

                try
                {
                    intResponse = int.Parse(response);
                    if(intResponse == resultAttendu)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                Console.WriteLine("Vous devez entrer un nombre correct");
                }
            }
        }
    }
}
