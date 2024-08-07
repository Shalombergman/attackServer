using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace attackServer
{
    internal class Program
    {
        static  async Task Main(string[] args)
        {
            
            string a = await readingJson.ReadJsonFile();
            Console.WriteLine(a);
           
        }
        
        
        
    }
}
