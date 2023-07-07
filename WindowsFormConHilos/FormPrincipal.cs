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
            Task.Run(new Action(DoWork1));
            Task.Run(new Action(DoWork2));
            Task.Run(new Action(DoWork3));
            Task.Run(new Action(DoWork4));
            Task.Run(new Action(DoWork5));
            Task.Run(new Action(DoWork6));
        }

        public void DoWork1()
        {
            for (long i = 0; i < 500000000 && cancelar == false; i++)
            {
                a = "Hilo secundario 1: " + i;
                
            }
        }
        public void DoWork2()
        {
            for (long i = 0; i < 500000000 && cancelar == false; i++)
            {
                b = "Hilo secundario 2: " + i;
            }
        }
        public void DoWork3()
        {
            for (long i = 0; i < 500000000 && cancelar == false; i++)
            {
                c = "Hilo secundario 3: " + i;
            }
        }
        public void DoWork4()
        {
            for (long i = 0; i < 500000000 && cancelar == false; i++)
            {
                d = "Hilo secundario 4: " + i;
            }
        }
        public void DoWork5()
        {
            for (long i = 0; i < 500000000 && cancelar == false; i++)
            {
                e = "Hilo secundario 5: " + i;
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

            while ( cancelar == false)
            {
                listBox1.Items[0] = a;
                listBox1.Items[1] = b;
                listBox1.Items[2] = c;
                listBox1.Items[3] = d;
                listBox1.Items[4] = e;

                await Task.Delay(1000);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
