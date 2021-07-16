using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Program
    {

        static void Main(string[] args)
        {
            DoubleLinkedList ob = new DoubleLinkedList();
             int ele=0, ch, pos;
            do
            {
                Console.WriteLine("1 Insert in the beginning");
                Console.WriteLine("2 Insert in the end");
                Console.WriteLine("3 Insert at the given position");
                Console.WriteLine("4 Delete at the begining");
                Console.WriteLine("5 Delete at the end");
                Console.WriteLine("6 Delete at the given position");
                Console.WriteLine("7 To Travers Reverse");
                Console.WriteLine("8 To Find the first occurance");
                Console.WriteLine("9 To Find nth Occurance");
                Console.WriteLine("10 Dispaly");
                Console.WriteLine("11 Exit");
                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the element ");
                        ele = int.Parse(Console.ReadLine());
                        ob.insertbegin(ele);
                        break;
                    case 2:
                        Console.WriteLine("Enter the element");
                        ele = int.Parse(Console.ReadLine());
                        ob.insertend(ele);
                        break;
                    case 3:
                        Console.WriteLine("Enter the element");
                        ele = int.Parse(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Enter position");
                            pos = int.Parse(Console.ReadLine());
                        } while (pos < 1 || pos > ob.count + 1);
                        ob.insertpos(ele, pos);
                        break;
                    case 4: ob.deletebegin(); break;
                    case 5: ob.deleteend(); break;
                    case 6:
                       do
                        {
                            Console.WriteLine("Enter position");
                            pos = int.Parse(Console.ReadLine());
                        } while (pos < 1 || pos > ob.count);
                        ob.deletepos(pos); break;

                    case 7:
                        do
                        {
                            Console.WriteLine("Enter position");
                            pos = int.Parse(Console.ReadLine());
                        } while (pos < 1 || pos > ob.count);
                        ob.Traversereverse(pos); break;

                    case 8: Console.WriteLine("Enter the element");
                        ele = int.Parse(Console.ReadLine());
                        pos = ob.find(ele);
                        if (pos == -1)
                            Console.WriteLine("Element not found");
                        else
                            Console.WriteLine("The Search key found at position = " + pos);
                        break;

                    case 9:
                        int occ;
                        Console.WriteLine("Enter Occurance");
                        occ = int.Parse(Console.ReadLine());
                        pos=ob.find(ele,occ);
                        if (pos == -1)
                            Console.WriteLine("Search key noy found");
                        else if (pos == -2)
                            Console.WriteLine("Found Search key but not occurance");
                        else
                            Console.WriteLine("Found Search key at {0} position " ,pos);
                        break;

                    case 10:
                        ob.display(); break;
                    case 11: break;
                    default: Console.WriteLine("Invalid Choice"); break;
                }
            } while (ch != 11);

        }
    }
}
