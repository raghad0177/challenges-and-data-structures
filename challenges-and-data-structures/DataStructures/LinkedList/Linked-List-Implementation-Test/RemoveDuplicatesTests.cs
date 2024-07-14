using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Implementation_Test
{
    public class RemoveDuplicatesTests
    {
        [Fact]
        public void RemoveDuplicatesOnlyCase()
        {
            //Arrange
            LearnLinkedList.LinkedList linkedList = new LearnLinkedList.LinkedList();
            linkedList.InsertLast(1);
            linkedList.InsertLast(1);
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(4);
            linkedList.InsertLast(4);
            linkedList.InsertLast(5);
            linkedList.InsertLast(5);
            string Expected = "1 2 3 4 5 ";
            //Act 
            linkedList.RemoveDuplicate();
            var sw = new StringWriter();
            Console.SetOut(sw);
            linkedList.Print();
            string Actual = sw.ToString();
            //Assert
            Assert.Equal(Expected, Actual);
        }

        [Fact]
        public void NoDuplicateCase()
        {
            //Arrange
            LearnLinkedList.LinkedList linkedList = new LearnLinkedList.LinkedList();
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(4);
            linkedList.InsertLast(5);
            string Expected = "1 2 3 4 5 ";
            //Act
            linkedList.RemoveDuplicate();
            var sw = new StringWriter();
            Console.SetOut(sw);
            linkedList.Print();
            string Actual = sw.ToString();
            //Assert
            Assert.Equal(Expected , Actual);
        }
        [Fact]
        public void AllNodsDuplicateCase()
        {
            //Arrange
            LearnLinkedList.LinkedList linkedList = new LearnLinkedList.LinkedList();
            linkedList.InsertLast(1);
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(3);
            linkedList.InsertLast(4);
            linkedList.InsertLast(4);
            string Expected = "1 2 3 4 ";
            //Act
            linkedList.RemoveDuplicate();
            var sw = new StringWriter();
            Console.SetOut(sw);
            linkedList.Print();
            string Actual = sw.ToString();
            //Assert
            Assert.Equal(Expected, Actual);
        }
    }
}
