using DataStructuresInCSharp.Implementations._CommonSteps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresInCSharp.Implementations._2_LinkedLists
{
    public class LinkedListExample
    {
        public static void LinkedListBase()
        {
            //Linked list instantiation
            LinkedList<string> pages = new LinkedList<string>();

            //Adding and removing nodes
            LinkedListNode<string> node1 = pages.AddLast("test1");
            LinkedListNode<string> node2 = pages.AddFirst("test2");
            LinkedListNode<string> node3 = pages.AddBefore(node1, "test3");
            LinkedListNode<string> node4 = pages.AddAfter(node3, "test4");

            LinkedListNode<string> currentEl = pages.First;
            Console.Write(currentEl.Value);
            while (currentEl.Next != null)
            {
                currentEl = currentEl.Next;
                Console.Write("-->" + currentEl.Value);
            }

            bool isContains = pages.Contains("test1");
            pages.RemoveFirst();
            pages.RemoveLast();
            pages.Remove("test3");

            //Operations with node
            LinkedListNode<string> searchNode = pages.Find("test4");
            string value = searchNode.Value;
            LinkedListNode<string> prevNode = searchNode.Next;
            LinkedListNode<string> nextNode = searchNode.Previous;

            //Instantiate and fill
            LinkedList<int> pages2 = new LinkedList<int>(new int[] { 2, 2, 5, 2 });
        }

        public static LinkedList<string> RealWorldExample1(IList<string> pagesToNavigate)
        {
            //Init
            var highScorePages = new LinkedList<string>();
            string baseUrl = "https://football.ua/";
            IWebDriver webDriver = WebDriverInitialization.Instance.Driver;
            

            //Act
            //Navigate pages and receive goals
            pagesToNavigate.ToList().ForEach(page => 
                { 
                    webDriver.Navigate().GoToUrl(baseUrl + page);
                    highScorePages.AddLast(baseUrl + page);
                }
            );

            Dictionary<string, int> scorePerPage = PagesDbEmulator.GetScorePerPage();
            LinkedListNode<string> node = highScorePages.First;

            while (!node.Equals(null))
            {
                int score = scorePerPage[node.Value];
                if (score < 11)
                    highScorePages.Remove(node);
                node = node.Next;
            }
            return highScorePages;
        }
    }
}
