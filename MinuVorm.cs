using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class MinuVorm : Form
    {
        public MinuVorm() { }
        public MinuVorm(string Pealkiri,string Nupp,string Fail)
        {
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = Pealkiri;
            Button nupp = new Button
            {
                Text = Nupp,
                Location = new System.Drawing.Point(50, 50),
                Size=new System.Drawing.Size(100,50),
                BackColor = System.Drawing.Color.White,

            };
            nupp.Click += Nupp_Click;
            Label failinimi = new Label
            {
                Text = Fail,
                Location = new System.Drawing.Point(50, 120),
                Size = new System.Drawing.Size(100, 20),
                BackColor = System.Drawing.Color.White,
            };
            failinimi.Click += Failinimi_Click;

            Label failinimi1 = new Label
            {
                Text = Fail,
                Location = new System.Drawing.Point(50, 150),
                Size = new System.Drawing.Size(100, 20),
                BackColor = System.Drawing.Color.White,
            };
            failinimi1.Click += Failinimi1_Click;
            
            Label failinimi2 = new Label
            {
                Text = Fail,
                Location = new System.Drawing.Point(50, 180),
                Size = new System.Drawing.Size(100, 20),
                BackColor = System.Drawing.Color.White,
            };
            failinimi2.Click += Failinimi2_Click;


            this.Controls.Add(nupp);
            this.Controls.Add(failinimi);
            this.Controls.Add(failinimi1);
            this.Controls.Add(failinimi2);
        }
        
        private void Failinimi2_Click(object sender, EventArgs e)
        {
            Label fail_sender = (Label)sender;
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "küsimus", MessageBoxButtons.YesNo);

            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\abv.wav"))
                {
                    muusika.Play();
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
        }
        
     

        private void Failinimi1_Click(object sender, EventArgs e)
        {
            Label fail_sender = (Label)sender;
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "küsimus", MessageBoxButtons.YesNo);

            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\abv.wav"))
                {
                    muusika.Play();
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
        }

        private void Failinimi_Click(object sender, EventArgs e)
        {
            Label fail_sender = (Label)sender;
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "küsimus", MessageBoxButtons.YesNo);

            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\abd.wav"))
                {
                    muusika.Play();
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
        }

        private void Nupp_Click(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            var vastus = MessageBox.Show("Kas tahad muusikat kuulata?", "küsimus", MessageBoxButtons.YesNo);

            if (vastus == DialogResult.Yes)
            {
                using (var muusika = new SoundPlayer(@"..\..\abc.wav"))
                {
                    muusika.Play();
                }
            }
            else
            {
                MessageBox.Show(":(");
            }
        }
    }
}
