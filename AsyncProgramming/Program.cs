using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://msdn.microsoft.com/en-us/";
            AsyncTask async = new AsyncTask();
            Task<int> result = async.GetContentLengthAsync(url);
            Console.WriteLine(result.Result);


            Console.ReadKey();

        }
    }
}
