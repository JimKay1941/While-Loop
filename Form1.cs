using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dataArray = new int[3] {6,7,8};

            doThisBefore();

            int Index = 0;

            while (Index < 3)
            {
                doSomething(dataArray[Index]);

                Index += 1;   // this instruction is the same as: Index = Index + 1; Remember, this is NOT a mathematical equation, it is an 'assignment statement.' 
            }

            doThisAfter();
        }

        private void doThisBefore()
        {
            return;
        }

        private void doSomething(int oneElement)
        {
            return;
        }

        private void doThisAfter()
        {
            return;
        }
    }
}
