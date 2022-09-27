using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public class MinuVorm : Form
    {
        RadioButton r1, r2, r3;
        Button button;
        Button random;
        public MinuVorm() { }
        public MinuVorm(string Pealkiri)
        {
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = Pealkiri;
            Label l = new Label();
            l.AutoSize = true;
            l.Location = new Point(176, 40);
            l.Text = "Select music:";
            l.Font = new Font("Berlin Sans FB", 12);

            this.Controls.Add(l);




            r1 = new RadioButton();
            r1.AutoSize = true;
            r1.Text = "Бутырка - Какая осень в Лагерях";
            r1.Location = new Point(286, 40);
            r1.Font = new Font("Berlin Sans FB", 12);
            this.Controls.Add(r1);

            r2 = new RadioButton();
            r2.AutoSize = true;
            r2.Text = "Кто пчелок уважает";
            r2.Location = new Point(286, 60);
            r2.Font = new Font("Berlin Sans FB", 12);
            this.Controls.Add(r2);

            r3 = new RadioButton();
            r3.AutoSize = true;
            r3.Text = "Coolio Feat. L.V. - Gangsta's Paradise";
            r3.Location = new Point(286, 80);
            r3.Font = new Font("Berlin Sans FB", 12);
            this.Controls.Add(r3);



            button = new Button();
            button.Text = "Start";
            button.Height = 30;
            button.Width = 100;
            button.Location = new Point(286, 120);
            button.Click += Button_Click;
            button.AutoSize = true;

            this.Controls.Add(button);

            random = new Button();
            random.Text = "Random";
            random.Height = 30;
            random.Width = 100;
            random.Location = new Point(386, 120);
            random.Click += Button_Click;
            random.AutoSize = true;

            this.Controls.Add(random);

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (r1.Checked == true)
            {
                Button fail_sender = (Button)sender;
                var vastus = MessageBox.Show("Kas sa tahad seda laulu kuulata Бутырка - Какая осень в Лагерях?", "Küsimus", MessageBoxButtons.YesNo);

                if (vastus == DialogResult.Yes)
                {
                    using (var muusika = new SoundPlayer(@"..\..\butirka.wav"))
                    {
                        muusika.Play();
                    }
                }
                else
                {
                    MessageBox.Show(":(");
                }
            }
            else if (r2.Checked == true)
            {
                Button fail_sender = (Button)sender;
                var vastus = MessageBox.Show("Kas sa tahad seda laulu kuulata Кто пчелок уважает?", "Küsimus", MessageBoxButtons.YesNo);

                if (vastus == DialogResult.Yes)
                {
                    using (var muusika = new SoundPlayer(@"..\..\pchelka.wav"))
                    {
                        muusika.Play();
                    }
                }
                else
                {
                    MessageBox.Show(":(");
                }
            }
            else if (r3.Checked == true)
            {
                Button fail_sender = (Button)sender;
                var vastus = MessageBox.Show("Kas sa tahad seda laulu kuulata Coolio Feat. L.V. - Gangsta's Paradise?", "Küsimus", MessageBoxButtons.YesNo);

                if (vastus == DialogResult.Yes)
                {
                    using (var muusika = new SoundPlayer(@"..\..\Coolio.wav"))
                    {
                        muusika.Play();
                    }
                }
                else
                {
                    MessageBox.Show(":(");
                }
            }
            else
            {
                MessageBox.Show("Sa ei valinud muusikat");
            }
        }
    }
}

        

