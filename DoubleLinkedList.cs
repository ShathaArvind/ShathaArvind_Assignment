using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class DNode
    {
        public int data;
        public DNode prevadd;
        public DNode nextadd;

        public DNode(int data)
        {
            this.prevadd = null;
            this.nextadd = null;
            this.data = data;
        }
        public void display()
        {
            Console.Write(data+"\t");
        }
        public override string ToString()
        {
            return ("\n The delete Node is " + data + "\n");
        }
    }
    class DoubleLinkedList
    {
        public DNode head = null;
        public int count = 0;

        public DNode createnode(int ele)
        {
            count++;
            return new DNode(ele);
        }
        public void insertbegin(int ele)
        {
            if (head == null)
                head = createnode(ele);
            else
            {
                DNode temp = createnode(ele);
                head.prevadd = temp;
                temp.nextadd = head;
                head = temp;
            }
        }
       public void insertend(int ele)
        {
            if (head == null)
                head = createnode(ele);
            else
            {
                DNode temp = head;
                while(temp.nextadd!=null)
                {
                    temp = temp.nextadd;
                }
                DNode newnode = createnode(ele);
                temp.nextadd = newnode;
                newnode.prevadd = temp;
            }
        }
        public void display()
        {
            DNode temp = head;
            Console.WriteLine();
            Console.WriteLine();
            if (head == null)
                Console.WriteLine("The List is empty");
            else
            {
                while(temp!=null)
                {
                    temp.display();
                    temp = temp.nextadd;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public void insertpos(int ele,int pos)
        {
            if (pos == 1)
                insertbegin(ele);
            else if (pos == count + 1)
                insertend(ele);
            else
            {
                DNode cn = head, pn = head;
                for(int i=1;i<pos;i++)
                {
                    pn = cn;
                    cn = cn.nextadd;
                }
                DNode newnode = createnode(ele);
                pn.nextadd = newnode;
                newnode.nextadd = cn;
                newnode.prevadd = pn;
                cn.prevadd = newnode;
            }
        }
        public void deletebegin()
        {
            if (head == null)
                Console.WriteLine("Deletion not Possible");
            else
            {
                DNode temp = head;
                head = head.nextadd;
                if (head != null)
                    head.prevadd = null;
                Console.WriteLine(temp);
                temp = null;
                count--;
            }
        }
        public void deleteend()
        {
            if (head == null)
                Console.WriteLine("Deletion Not Possible");
            else
            {
                DNode pn = head, cn = head;
                while(cn.nextadd!=null)
                {
                    pn = cn;
                    cn = cn.nextadd;
                }
                pn.nextadd = cn.nextadd;
                Console.WriteLine(cn);
                cn = null;
                count--;
            }
        }
        public void deletepos(int pos)
        {
            if (pos == 1)
                deletebegin();
            else
            {
                DNode pn = head, cn = head;
                for(int i=1;i<pos;i++)
                {
                    pn = cn;
                    cn = cn.nextadd;
                }
                pn.nextadd = cn.nextadd;
                if (pn.nextadd != null)
                    pn.nextadd.prevadd = pn;
                Console.WriteLine(cn);
                cn = null;
            }
        }
        internal void Traversereverse(int pos)
        {
            DNode temp = head;
            for (int i = 1; i < pos; i++)
                temp = temp.nextadd;
            while(temp!=null)
            {
                temp.display();
                temp = temp.prevadd;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        public int find(int ele)
        {
            int flag = -1;
            DNode temp = head;
            int pos = 0;
            while(temp!=null)
            {
                pos++;
                if (temp.data == ele)
                    return pos;
                temp = temp.nextadd;
            }
            return flag;
        }
        public int find(int ele,int occ)
        {
            int flag = -1, count = 0;
            DNode temp = head;
            int pos = 0;
            while(temp!=null)
            {
                pos++;
                if(temp.data==ele)
                {
                    count++;
                    if (count == occ)
                        return pos;
                }
                temp = temp.nextadd;
               
            }
            if (count == 0)
                return -1;
            else
            return -2;
        }
    }
}
