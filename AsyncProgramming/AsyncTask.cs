using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming
{
    public  class AsyncTask
    {
        public  async Task<int> GetContentLengthAsync(string url)
        {
            HttpClient httpClient = new HttpClient();

            Task<String> getStringTask = httpClient.GetStringAsync(url);

            DoIndepenceWork();

            string content = await getStringTask;

            return  content.Length;
        }

        private void DoIndepenceWork()
        {
            Console.WriteLine("Continue other work in async");
        }
    }
}
