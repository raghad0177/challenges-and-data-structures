using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Linked_List_Implementation_Test
{
    public class UnitTest1
    {
        [Fact]
        public void RemoveLastNodeTest()
        {
            //Arrange 
            LearnLinkedList.LinkedList linkedList = new LearnLinkedList.LinkedList();
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(4);
            int Actual = linkedList.GetLength();
            //Act
            linkedList.Remove(4);
            int Expected = linkedList.GetLength();
            //Assert
            Assert.Equal(Expected+1, Actual);
        }

        [Fact]
        public void PrintListTest()
        {
            //Arrange 
            LearnLinkedList.LinkedList linkedList = new LearnLinkedList.LinkedList();
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(4);
            string Expected = "1 2 3 4 ";
            //Act 
            var sw = new StringWriter();
            Console.SetOut(sw);
            linkedList.Print();
            string Actual = sw.ToString();
            //Assert 
            Assert.Equal(Expected, Actual);
        }
    }
}

