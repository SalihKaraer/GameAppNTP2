using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static int tp= 0;
        public Form1()
        {
            InitializeComponent();
            
            Random rnd = new Random();

            button1.Text = rnd.Next(100).ToString();


            button2.Text = rnd.Next(100).ToString();
            button3.Text = rnd.Next(100).ToString();
            button2.Click += NumberClick;
            button3.Click += NumberClick;
          //constructor değer ataması   
        }
        void  NumberClick(object sender,EventArgs e)
        {
            //butonu pasifize etmek için enabled eventini kullanıyoruz
            Button btn = (Button)sender;
            btn.Enabled = false;
            tp += int.Parse(btn.Text);
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sayıların toplamı:{tp}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         // timer çalışıyor
            tmrButton.Start();
        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {

           MessageBox.Show("Test");
        }
    }
}
