using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Peaople
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ts = new TabStat();// статистика игр
            mkt = new TabStat();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
        private TabStat ts,mkt;
        private void Button1_Click(object sender, EventArgs e)
        {
            ts.pravka((int)numH.Value, (int)numG.Value, (int)timeToEnd.Value);
            textBoxOut.Text =ts.printResult((int)interval_start.Value, (int)interval_stop.Value);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            mkt.monteKarlo((int)numH.Value, (int)numG.Value,(int)timeToEnd.Value, (int)numericUpDownIterac.Value);
            textBoxTest.Text = mkt.printResult((int)interval_start.Value, (int)interval_stop.Value);
            //textBoxTest.Text = ts.printTab();

            textBoxTest.Text += Environment.NewLine + "сумма отклонений состовляет " + mkt.get_results().sumDiff(ts.get_results());
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            ts = new TabStat();
            textBoxOut.Text = Environment.NewLine + ts.printResult((int)interval_start.Value, (int)interval_stop.Value);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
