using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.IO;

namespace attackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            //ex1
            //string result = await GetDataAsync();
            //Console.WriteLine(result);
            //Console.ReadLine();

            //ex2
            string filePathToRead = "C:\\kodcode2\\Core8\\attackServer\\Exempel.txt";
            string content = await ReadFileAsync(filePathToRead);
            Console.WriteLine(content);
            //Ex3
            Task<string> taskA = GetDataFromServiceAAsync();
            Task<string> taskB = GetDataFromServiceBAsync();
            //מחכה שכל הטאסקים יגמרו
            //2 פעולות אסינכרוניות ביחד 
            await Task.WhenAll(taskA, taskB);
            Console.WriteLine($" taskA Result :{taskA.Result}");
            Console.WriteLine($" taskB Result : {taskB.Result}");
        }
        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Recivde Data";


        }
        
        public static async Task<string> ReadFileAsync( string filePath)
        {
            
            string result = await Task.Run(
            () => File.ReadAllText(filePath)
            );
            return result;
        }
        //string result = await Exempel.ReadFileAsync(@"C:\kodcode2\Core8\attackServer\Exempel.txt");
        //string sdb = await task.run(result);
        public static async Task<string> GetDataFromServiceAAsync()
        {
            await Task.Delay(1000);
            return "DataFrom service a";
        }
        public static async Task<string> GetDataFromServiceBAsync()
        {
            await Task.Delay(2000);
            return "DataFrom service b";
        }
    }
}
