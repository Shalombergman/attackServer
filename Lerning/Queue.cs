using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Lerning
{
    internal class Queue
    {
        //1
        public static void PrintQueue(Queue<int> queue)
        {
           

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

        }
        //3
        public static void QueuesReplace(Queue<string> queue1, Queue<string> queue2)
        {
            
            queue1.Enqueue("kj");
            queue1.Enqueue("shalom");
            queue1.Enqueue("nljn");
            while (queue1.Count > 0)
            {
                queue2.Enqueue(queue1.Dequeue());
            }
            //PrintQueue(queue2);



                //foreach (var item in queue1)
                //{
                //    queue2.Enqueue(item);

                //}
                
                //foreach(var item in queue1)
                //{
                //    queue1.Dequeue();
                //}
                //foreach (var item in queue1)
                //{
                //    if(item == null)
                //    {
                //        Console.WriteLine(true);
                //    }

            
            foreach (var item in queue2)
            {
                Console.WriteLine(item);
            }

        }//4
        public static Queue<int> printEven(Queue<int> queue)
        {
      
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                int a = queue.Dequeue();
                if (a % 2 == 0)
                {                   
                    queue.Enqueue(a);
                }
                
            }return queue;
        }

        //6
        public static void GetAge30(Dictionary<string,int> agas)
        {
            
            List<string> list = new List<string>();
            foreach(var item in agas)
            {
                if(item.Value < 30)
                {
                    list.Add(item.Key);
                }
            }

            foreach(var item in list)
            {
                agas.Remove(item);
            }
        }
        public static Queue<int> bothQueues(Queue<int> queue1, Queue<int> queue2)
        {
            Queue<int> result = new Queue<int>();
            //queue1.Enqueue(1);
            //queue2.Enqueue(3);
            //queue1.Enqueue(4);
            //queue2.Enqueue(5);
            //queue1.Enqueue(6);
            //queue2.Enqueue(7);
            //queue1.Enqueue(8);

            

            


            return result;
            
        }


    }
}
