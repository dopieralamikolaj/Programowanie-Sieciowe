using System;

namespace PSlab1
{
    class HelloWorld 
    {
        static void Main()
        {
            
            
            string zmienna = "tekst";
            int m, n, v;
            int suma = 0;
            
            for (int i = 0; i < zmienna.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                 {
                    m = (1<<j);
                    v = zmienna[i];
                    n = (v & m) >> j;

                    suma ^= n;
                    
                }
            }
        }
    }
}