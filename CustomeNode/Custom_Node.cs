using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2022_Single_link_list
{
    class Custom_Node
    {

        public Custom_Node Next;
        public Custom_Node head;
        public  String data;
        public Custom_Node()
        {
            //good practice
        }

        public Custom_Node(string data)
        {
            this.data = data;
        }

       

    }
}
