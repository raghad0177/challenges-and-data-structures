using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Implementation_Test
{
    public class MergeSortedLinkedLists
    { 
        [Fact]
        public void MergeTwoLists()
        {
            // Arrange
            LearnLinkedList.LinkedList linkedList1 = new LearnLinkedList.LinkedList(); 
            LearnLinkedList.LinkedList linkedList2 = new LearnLinkedList.LinkedList();
            LearnLinkedList.LinkedList mergedList = new LearnLinkedList.LinkedList();

            linkedList1.InsertLast(5);
            linkedList1.InsertLast(10);
            linkedList1.InsertLast(15);

            linkedList2.InsertLast(2);
            linkedList2.InsertLast(3);
            linkedList2.InsertLast(20);

            string expectedOutput = "2 3 5 10 15 20 ";
            // Act
            try
            {  
                mergedList = LearnLinkedList.LinkedList.MergeTwoLists(linkedList1, linkedList2);
                var stringWriter = new StringWriter();
                TextWriter originalOutput = Console.Out;
                Console.SetOut(stringWriter);
                mergedList.Print();
                string actualOutput = stringWriter.ToString();

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
            finally
            {
                // Reset the output to the original
                Console.SetOut(Console.Out);
            }
        }
        [Fact]
        public void MergeTwoListsWithOneEmpty()
        {
            // Arrange
            LearnLinkedList.LinkedList linkedList1 = new LearnLinkedList.LinkedList();
            LearnLinkedList.LinkedList linkedList2 = new LearnLinkedList.LinkedList();
            LearnLinkedList.LinkedList linkedList3 = new LearnLinkedList.LinkedList();
            linkedList1.InsertLast(5);
            linkedList1.InsertLast(10);
            linkedList1.InsertLast(15);
            string expectedOutput = "5 10 15 ";
            // Act
            linkedList3 = LearnLinkedList.LinkedList.MergeTwoLists(linkedList1, linkedList2);
            var stringWriter = new StringWriter();
            TextWriter originalOutput = Console.Out;
            Console.SetOut(stringWriter);
            try
            {
                linkedList3.Print();
                string actualOutput = stringWriter.ToString();
                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
            finally
            {
                // Reset the output to the original
                Console.SetOut(originalOutput);
            }
        }
        [Fact]
        public void MergeTwoListsEmptys()
        {
            // Arrange
            LearnLinkedList.LinkedList linkedList1 = new LearnLinkedList.LinkedList();
            LearnLinkedList.LinkedList linkedList2 = new LearnLinkedList.LinkedList();
            LearnLinkedList.LinkedList linkedList3 = new LearnLinkedList.LinkedList();


            string expectedOutput = "";

            // Act
            linkedList3 = LearnLinkedList.LinkedList.MergeTwoLists(linkedList1, linkedList2);
            var stringWriter = new StringWriter();
            TextWriter originalOutput = Console.Out;
            Console.SetOut(stringWriter);
            try
            {
                linkedList3.Print();
                string actualOutput = stringWriter.ToString();

                // Assert
                Assert.Equal(expectedOutput, actualOutput);
            }
            finally
            {
                // Reset the output to the original
                Console.SetOut(originalOutput);
            }
        }

    }
}
