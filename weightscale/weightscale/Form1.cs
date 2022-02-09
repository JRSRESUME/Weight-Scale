using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace weightscale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        double shit;
        double shit2;
        double cum;
        double TOTAL;
        double GrandTotal;
        double poop;

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            shit = Convert.ToDouble(bw10.Text) - Convert.ToDouble(emptybox.Text);
            shit2 = shit / 10;
            cum = Convert.ToDouble(howmany.Text) * Convert.ToDouble(emptybox.Text);
            TOTAL = Convert.ToDouble(boxandpcs.Text) - cum;
            GrandTotal = TOTAL / shit2;
            poop = Math.Round(GrandTotal);
            total.Text = poop.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            
            emptybox.Clear();
            bw10.Clear();
            howmany.Clear();
            boxandpcs.Clear();
            total.Clear();
        }

        
    }
}
