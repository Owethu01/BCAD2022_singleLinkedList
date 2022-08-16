using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2022_Single_link_list.C_link_lists
{
    class Single_linked_list
    {

        public Custom_Node head;
        public Custom_Node current;
        public String data;
        public int nodeCount;

        public void appendNode(string data)
        {
            //
            if (head == null)
            {
                head = new Custom_Node(data);
                nodeCount++;
                return;
            }

            current = head;

            while (true)
            {
                if (current.Next != null)//if there is an existomg list walk through
                {
                    current = current.Next;
                }


            }

            current.Next = new Custom_Node(data);
        }

        public void prepend(string data)
        {
            if (head != null)
            {
                head = new Custom_Node(data);
                nodeCount++;

            }
            else
            {
                Custom_Node newHead = new Custom_Node(data);
                nodeCount++;
                newHead.Next = head;
                head = newHead;
            }
        }
        public void deleteWithData(string deleteMe) 
        {
            if (head == null)
            {
                MessageBox.Show("Cannot delete a value from an empty list");
                return;  
            }

            if (head.data.Equals(data))
            {
                head = head.Next;
            }

            current = head;
            while (current.Next != null)
            {
                if (current.Next.data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    MessageBox.Show("Node with data" + data + " deleted");
                }


                current = current.Next;
            }

           
            MessageBox.Show("Could not delete data not presented in list");
        }

        public void applyProfanityFilter(string data)
        {
            if (head == null)
            {
                MessageBox.Show("No list to clean");

            }
           if (head.data.Contains(data))
            {
                string replacestring = data.Replace(data, "*****");
                    head.data = replacestring;
                MessageBox.Show(head.data);
               // return;
            }
            current = head;
           // head = current;
            while (current.Next != null)
            {
                current = current.Next;
                if (current.data.Contains(data))
                {
                    string replacestring = current.data.Replace(data, "*****");
                    current.data = replacestring;
                    MessageBox.Show(current.data);
                   
                }
            }

            MessageBox.Show("No swearwords in here");   
        }

        public void insertAfter (string data)
        {
            if (head == null)
            {
                MessageBox.Show("No list here");
            }
            if (head.data.Contains(data))
            {
                Custom_Node insertNode = new Custom_Node(data);

                insertNode.Next = head.Next;
                head.Next = insertNode;
            }
        }
       
    }  
}
