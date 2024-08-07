using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lerning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Queue<int> queue1 = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();
            Queue<string> queue3 = new Queue<string>();
            Queue<string> queue4 = new Queue<string>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue3.Enqueue("kj");
            queue3.Enqueue("shalom");
            queue3.Enqueue("nljn");


            queue1.Enqueue(1);
            queue2.Enqueue(3);
            queue1.Enqueue(4);
            queue2.Enqueue(5);
            queue1.Enqueue(6);
            queue2.Enqueue(7);
            queue1.Enqueue(8);
            //Queue.PrintQueue(queue);
            //Queue.QueuesReplace(queue3, queue4);
            Queue.bothQueues(queue1, queue2);

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


            //Dictionary
            Dictionary<string, int> agas = new Dictionary<string, int>();
            agas["Shalom"] = 24;
            if (agas.ContainsKey("Shalom"))
            {
                Console.WriteLine($"Shalom is {agas["Shalom"]} age");
            }
            else
            {
                Console.WriteLine($"not found age shalom in directory");
            }
            agas["Shalom"] = 34;
            Console.WriteLine(agas["Shalom"]);
            if (agas.ContainsKey("Shalom"))
            {
                Console.WriteLine("Shalom is in Dictionary");
            }


        }
        public static async Task<string> GetDataAsync()
        {
            await Task.Delay(2000);
            return "Recivde Data";


        }

        public static async Task<string> ReadFileAsync(string filePath)
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
   