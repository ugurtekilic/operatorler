using System;
namespace operatorler
{
    class program
    {
        static void Main(string[] args) 
        {
            //Atama işlemleri
            int x = 2;
            int y = 3;
            y = y+2;
            y += 2;
            y /= 2;
            x *= 2;

            //mantıksal operatorler
            // && || !

            bool isSuccesful = true;
            bool isCompalted = false;

            if (isSuccesful && isCompalted)
            {
                Console.WriteLine("Perfect");
            }

            if (isSuccesful || isCompalted)
            {
                Console.WriteLine("Great");
            }

            if (isSuccesful && !isCompalted)
            {
                Console.WriteLine("Fine");
            }


            // iliskisel operatoprler
            // <  >  <=  =>  ==  !=
            int a = 3;
            int b = 4;
            bool sonuc = a<b;

            Console.WriteLine("a < b " + sonuc);
            sonuc = a>b;
            Console.WriteLine("a > b " + sonuc);
            sonuc = a == b;
            Console.WriteLine("a = b " + sonuc);
            sonuc = a != b ;
            Console.WriteLine("a != b " + sonuc);

            // Aritmatiksel operatorler
            //+ - * / 
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine("10 / 5 = " + sonuc1);
            int sonuc2 = sayi1++;
            Console.WriteLine("10 + 1 = " + sonuc2);

            // % mod alır (böldükten sonra kalanı getiren ifade)
            int sonuc3 = 20%3;
            Console.WriteLine(sonuc3); 


        }
    }
}

