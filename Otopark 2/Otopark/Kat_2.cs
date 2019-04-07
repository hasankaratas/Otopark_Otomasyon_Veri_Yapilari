using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    public class Kat_2 : ListADT
    {
        public override void InsertFirst(string value)
        {
            Node tmpHead = new Node
            {
                Data = value,
                Next = Head
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;

                Head = tmpHead;
            }

            Size++;
        }


        public override void DeleteFirst()
        {
            Node oldLast = Head;
            if (Head != null)
            {
                Node tempHeadNext = this.Head.Next;
                if (tempHeadNext == Head)
                    Head = null;
                else
                {
                    Head = tempHeadNext;
                    while (oldLast != null)
                    {
                        if (oldLast.Next != Head)
                            oldLast = oldLast.Next;
                        else
                            break;
                    }
                    oldLast.Next = Head;
                }

                Size--;
            }
        }


        public override void DeletePos(int position)
        {
            if (position == 0)

                DeleteFirst();
            else
            {
                Node lastNode = Head;
                Node lastPrevNode = null;
                int count = 1;

                while (true)
                {

                    if (lastNode.Next != Head)
                    {
                        lastPrevNode = lastNode;
                        lastNode = lastNode.Next;
                    }
                    else
                        break;
                    if (count == position)
                    {
                        break;
                    }
                    count++;
                }
                Size--;
                if (lastPrevNode != null)
                    lastPrevNode.Next = lastNode.Next;
                else
                    Head = null;

                lastNode = null;

            }

        }

        public override Node GetElement(int position)
        {
            Node retNode = null;
            Node tempNode = Head;
            int count = 0;

            while (tempNode != null)
            {
                if (count == position)
                {
                    retNode = tempNode;
                    break;
                }
                if (tempNode.Next == Head)
                {
                    break;
                }
                tempNode = tempNode.Next;

                count++;
            }
            return retNode;
        }

    }
}
