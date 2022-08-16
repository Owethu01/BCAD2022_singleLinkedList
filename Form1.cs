using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2022_Single_link_list.C_link_lists;

namespace WinFormsApp2022_Single_link_list
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Single_linked_list slinkedList = new Single_linked_list();
           // slinkedList.appendNode("I am the head");


            slinkedList.prepend("I am the new head");
            slinkedList.prepend("I am the second head");
            slinkedList.prepend("I am the third head");

            slinkedList.deleteWithData("I am the third head");
            slinkedList.deleteWithData("Mwaaahahha I am the head now");
            slinkedList.deleteWithData("Look at me, I am the Captain");

            slinkedList.applyProfanityFilter("am");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
