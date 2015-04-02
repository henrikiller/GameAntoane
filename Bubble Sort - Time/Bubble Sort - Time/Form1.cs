using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Sort___Time
{
    public partial class BubleSorteTime : Form
    {
        TimeSpan poha;

        public BubleSorteTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start;
            TimeSpan time;
            start = DateTime.Now;

            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {                
                Bubble bubble = new Bubble(i);
                time = DateTime.Now - start;
                Console.WriteLine(time + ";" + i);

                poha +=  time;
            }

            textBox2.Text = poha.ToString();
        }
    }
}
