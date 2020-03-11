using DataStructuresInCSharp.Implementations._6_Tree.OrganizationTree;
using System;
using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._6_Tree
{
    public class TreeExample
    {
        public static void BinaryTree()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(10);
            binaryTree.Add(5);
            binaryTree.Add(8);

            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();

            Console.WriteLine("PreOrder Traversal:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal:");
            binaryTree.TraverseInOrder(binaryTree.Root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal:");
            binaryTree.TraversePostOrder(binaryTree.Root);
            Console.WriteLine();

            binaryTree.Remove(7);
            binaryTree.Remove(8);

            Console.WriteLine("PreOrder Traversal After Removing Operation:");
            binaryTree.TraversePreOrder(binaryTree.Root);
            Console.WriteLine();
        }


        public static void OrganizationTree()
        {
            var cheatInvest = new OrganizationHierarchy("CEO");

            //Directors
            Employee devDirector =
                cheatInvest.AddEmployee("DEV Director", JobTitle.DIRECTOR, cheatInvest.CEO);
            
            Employee qaDirector = 
                cheatInvest.AddEmployee("QA Director", JobTitle.DIRECTOR, cheatInvest.CEO);

            //Managers
            Employee funcTestManager =
                cheatInvest.AddEmployee("Functional Test Manager", JobTitle.MANAGER, qaDirector);

            Employee perfTestManager =
                cheatInvest.AddEmployee("Performance Test Manager", JobTitle.MANAGER, qaDirector);

            //Employees
            Employee seniorQA =
                cheatInvest.AddEmployee("Senior QA", JobTitle.EMPLOYEE, funcTestManager);

            Employee juniorQA =
                cheatInvest.AddEmployee("Junior QA", JobTitle.EMPLOYEE, funcTestManager);

            //Print subordinates
            //cheatInvest.CEO.PrintSubordinateDetails();
            //funcTestManager.PrintSubordinateDetails();

            //Find Employee
            List<Employee> findSeniorQA = cheatInvest.FindEmployee("Senior QA");

            cheatInvest.PrintChiefsHierarchy(seniorQA);
            cheatInvest.PrintChiefsHierarchy(cheatInvest.CEO);
        }
    }
}
