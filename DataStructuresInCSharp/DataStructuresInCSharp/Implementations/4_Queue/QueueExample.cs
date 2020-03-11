using DataStructuresInCSharp.Implementations._CommonSteps;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructuresInCSharp.Implementations._4_Queue
{
    public class QueueExample
    {
        public void BaseExamples()
        {
            var queue = new Queue<string>();
            //Go to queue line
            queue.Enqueue("First");
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            //Returns first object in queue
            string firstInLine = queue.Peek();
            //Your turn
            string removedFromLine = queue.Dequeue();

            //Queue count
            int queueCount = queue.Count;

            //Queue initialization and filling
            var queue2 = new Queue<int>(new int[] { 1, 2, 3, 5, 4 });
        }

        public void RealExample()
        {
            var messagesQueue = new Queue<Message>();

            for (int i = 0; i < 5; i++)
            {
                messagesQueue.Enqueue(new Message($"{i}", $"Test messsage {i}"));
            }

            Console.WriteLine($"Inittial queue count {messagesQueue.Count}");

            Task taskA = new Task(() => ProcessQueue(messagesQueue));
            Task taskB = new Task(() => AddNewItemsToQueue(messagesQueue));

            taskA.Start();
            taskB.Start();
        }


        private void ProcessQueue(Queue<Message> messagesQueue) 
        {
            while (messagesQueue.Count != 0)
            {
                Message message = messagesQueue.Dequeue();
                Console.WriteLine("#######Messsage processing##########");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine($"MessageId: {message.MessageID}\n" +
                    $"MessageText: {message.MessageText}");
                Console.WriteLine("------------------------------------");
                Thread.Sleep(1000);
            }
        }

        private void AddNewItemsToQueue(Queue<Message> messagesQueue) 
        {
            Thread.Sleep(3000);
            for (int i = 5; i < 7; i++)
            {
                var newMessage = new Message($"{i}", $"Test messsage {i}");
                messagesQueue.Enqueue(newMessage);
                Console.WriteLine("############New message in queue###########");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine($"New message with Id={i} was added to queue");
                Console.WriteLine("-------------------------------------------");
                Thread.Sleep(1000);
            }
        }


        
    }
}
