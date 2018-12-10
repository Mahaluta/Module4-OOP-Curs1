using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectCycleLinkedList
{
    public class SingleLinkedList
    {
        private Node First;

        private List<Node> Nodes { get; set; }

        public Node AddFirst(int value)
        {
            Node node = new Node();
            node.value = value;
            node.next = null;

            First = node;
            return node;
        }


        public Node AddAfter(Node node1, int value)
        {
            Node newNode = new Node();
            newNode.value = value;
            node1.next = newNode;

            return newNode;
        }

        public void DisplayList()
        {
            Node currentNode = First;

            while (currentNode != null)
            {

                Console.Write(First.value + " ");
                currentNode = currentNode.next;
            }
        }

        public bool DetectCycle(Node First)
        {
            if (First.next == null)
                return false;

            Node Din1In1 = First;
            Node Din2In2 = Din1In1.next;

            while(Din2In2 != null)
            {
                if (Din2In2.next == null)
                    return false;
                Din2In2 = Din2In2.next.next;
                Din1In1 = Din1In1.next;

                if (Din1In1 == Din2In2)
                    return true;
            }
            return false;
        }

        /*
           First -> 1 -> 2 -> 3 -> 4 -> 5
                              ^         |
                              |         V
                              8 <- 7 <- 6    <-- Din1In1 si Din2In2 se intalnesc in nodul 6
        */

    }
}
