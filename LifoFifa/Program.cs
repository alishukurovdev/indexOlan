using System.Collections;

namespace LifoFifa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrrayListİnt ari= new ArrrayListİnt();
            ari.Add(44);
            ari.Add(42);
            ari.Add(1);
            ari.Add(4);
            ari.Add(3);
            ari.Add(4);
            ari.Add(44);
            ari.Add(42);
            Console.WriteLine(ari.ToString());

            ari.IndexOf(44);
            ari.LastIndexOf(4);


        }
    }
}
