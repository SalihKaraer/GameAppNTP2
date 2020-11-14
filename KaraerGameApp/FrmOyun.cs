using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaraerGameApp
{
    public partial class FrmOyun : Form
    {

        static int tp = 0;
        static int sr = 3;
        Random rnd = new Random();

        public FrmOyun()
        {
            InitializeComponent();

        }


        private void FrmOyun_Load(object sender, EventArgs e)
        {
            tmrButton.Start();
            tmrSure.Start();

        }
        private void tmrButton_Tick(object sender, EventArgs e)
        {

            Button btn = new Button();
            btn.Size = new Size(70, 45);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width - pnlhud.Width - btn.Width), rnd.Next(this.ClientSize.Height - btn.Height));
            btn.Text = rnd.Next(100).ToString();
            //btn.BackgroundImage = Image.FromFile(@"D:\slh.jpg");
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Click += Btn_Click;
            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tp += int.Parse(btn.Text);
            lblsk.Text = $"Skor:{tp}";
            // btn.Visible = false; // burda butonlar bellekten silinnmiyor
            btn.Dispose();//nesnenin heap bölgesinden atılması --dispose

        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sr--;
            lblsr.Text = sr.ToString();
            if (sr == 0)
            {
                tmrSure.Stop();
                tmrButton.Stop();
                FileStream fs = new FileStream(@"C:\SkorKayit.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(DateTime.Now + ($" Skorunuz:{tp}\n\r"));
                fs.Flush();
                sw.Close();

                DialogResult secenek = MessageBox.Show($"Oyun Sona erdi...:\n " +
                    $"Skorunuz:{tp}\n " +
                    $"Yeniden Başla ???", "Skor Tabelası", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
