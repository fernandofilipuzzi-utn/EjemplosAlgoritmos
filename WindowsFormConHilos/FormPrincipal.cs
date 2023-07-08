using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormConHilos
{
    public partial class FormPrincipal : Form
    {
        string a = "", b = "", c = "", d = "", e = "";
        long m, n, o, p, q;
        bool cancelar = true;

        public FormPrincipal()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;

            button1.BackColor = Color.Green;
            button1.Text = "Empezar";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            cancelar = !cancelar;
            if (cancelar == true)
            {
                button1.BackColor = Color.Green;
                button1.Text = "Empezar";

            }
            else
            {
                listBox1.Items.Clear();
                button1.BackColor = Color.Red;
                button1.Text = "Parar";

            }
            /*
            Task.Run(new Action(DoWork1));
            Task.Run(new Action(DoWork2));
            Task.Run(new Action(DoWork3));
            Task.Run(new Action(DoWork4));
            Task.Run(new Action(DoWork5));
            Task.Run(new Action(DoWork6));
            */
            Task.Run(DoWork1);
            Task.Run(DoWork2);
            Task.Run(DoWork3);
            Task.Run(DoWork4);
            Task.Run(DoWork5);
            Task.Run(DoWork6);
        }

        public void DoWork1()
        {
            for ( m = 0; m < 500000000 && cancelar == false; m++)
            {
                a = "Hilo secundario 1: " + m;
                
            }
        }
        public void DoWork2()
        {
            for (n = 0; n < 500000000 && cancelar == false; n++)
            {
                b = "Hilo secundario 2: " + n;
            }
        }
        public void DoWork3()
        {
            for (o = 0; o < 500000000 && cancelar == false;o++)
            {
                c = "Hilo secundario 3: " + o;
            }
        }
        public void DoWork4()
        {
            for (p = 0; p < 500000000 && cancelar == false;p++)
            {
                d = "Hilo secundario 4: " + p;
            }
        }
        public void DoWork5()
        {
            for (q = 0; q < 500000000 && cancelar == false; q++)
            {
                e = "Hilo secundario 5: " + q;
            }
        }

        public async void DoWork6()
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");

            progressBar1.Maximum = 100;
            progressBar2.Maximum = 100;
            progressBar3.Maximum = 100;
            progressBar4.Maximum = 100;
            progressBar5.Maximum = 100;
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;
            progressBar5.Value = 0;

            while ( cancelar == false)
            {
                progressBar1.Value = (int)(100.0 * m / 500000000);
                progressBar2.Value = (int)(100.0 * n / 500000000);
                progressBar3.Value = (int)(100.0 * o / 500000000);
                progressBar4.Value = (int)(100.0 * p / 500000000);
                progressBar5.Value = (int)(100.0 * q / 500000000);

                listBox1.Items[0] = a;
                listBox1.Items[1] = b;
                listBox1.Items[2] = c;
                listBox1.Items[3] = d;
                listBox1.Items[4] = e;

                await Task.Delay(1000);
                this.Update();
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
