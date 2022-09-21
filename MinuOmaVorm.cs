using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class MinuOmaVorm : Form
    {



        TreeView puu;
        Button nupp;
        Label label;
        CheckBox aruut1, aruut2;
        ProgressBar progress;
        Timer aeg;
        TextBox tekst;
        public MinuOmaVorm()
        {
            Height = 600;
            Width = 800;
            Text = "Minu oma vorm koos elementLiga";
            BackColor = Color.Aquamarine;
            puu = new TreeView();
            puu.Dock = DockStyle.Left;
            puu.Location = new Point(0, 0);
            TreeNode oksad =new TreeNode("Elemendid");
            oksad.Nodes.Add(new TreeNode("Nupp-Button"));
            oksad.Nodes.Add(new TreeNode("Label"));
            oksad.Nodes.Add(new TreeNode("Checkbox"));
            oksad.Nodes.Add(new TreeNode("Progressbar"));
            oksad.Nodes.Add(new TreeNode("Tekstkast-TextBox"));
            oksad.Nodes.Add(new TreeNode("Omavorm"));





            puu.AfterSelect += Puu_AfterSelect;

            puu.Nodes.Add(oksad);
            this.Controls.Add(puu);
        }

        private void Puu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Nupp-Button")
            {
                nupp = new Button();
                nupp.Text = "Vajuta siia";
                nupp.Height = 30;
                nupp.Width = 100;
                nupp.Location = new Point(250, 240);
                nupp.Click += Nupp_Click;
                nupp.AutoSize = true;



                this.Controls.Add(nupp);
            }
            else if (e.Node.Text == "Label")
            {
                label = new Label { Text = "Minu esimene vorm", Size = new Size(200, 50), Location = new Point(200, 0) };

                Label mylab = new Label();
                mylab.Text = "ArtjomRozhkov";
                mylab.Location = new Point(222, 90);
                mylab.AutoSize = true;
                mylab.Font = new Font("Calibri", 18);
                mylab.BorderStyle = BorderStyle.Fixed3D;
                mylab.ForeColor = Color.Green;
                mylab.Padding = new Padding(6);

                this.Controls.Add(mylab);

                Label mylab1 = new Label();
                mylab1.Text = "Welcome To ArtjomRozhkov";
                mylab1.Location = new Point(155, 170);
                mylab1.AutoSize = true;
                mylab1.BorderStyle = BorderStyle.Fixed3D;
                mylab1.Font = new Font("Calibri", 18);
                mylab1.Padding = new Padding(6);
                this.Controls.Add(mylab1);

            }
            else if (e.Node.Text == "Checkbox")
            {
                Label l = new Label();
                l.Text = "Select Gender:";
                l.Location = new Point(500, 111);

                this.Controls.Add(l);

                aruut1 = new CheckBox();
                aruut1.Height = 50;
                aruut1.Width = 100;
                aruut1.Location = new Point(500, 136);
                aruut1.Text = "Male";

                this.Controls.Add(aruut1);

                aruut2 = new CheckBox();
                aruut2.Height = 50;
                aruut2.Width = 100;
                aruut2.Location = new Point(500, 174);
                aruut2.Text = "Female";


                this.Controls.Add(aruut2);

                aruut1.CheckedChanged += new EventHandler(aruut_1_2_Changed);
                aruut2.CheckedChanged += new EventHandler(aruut_1_2_Changed);
            }
            else if (e.Node.Text == "Progressbar")
            {
                progress = new ProgressBar();
                progress.Location = new System.Drawing.Point(350, 500);
                progress.Name = "progressBar1";
                progress.Width = 200;
                progress.Height = 30;
                //progress.Dock = DockStyle.Bottom;
                progress.Step = 1;
                progress.Minimum = 0;
                progress.Maximum = 100;
                progress.Value = 0;


                this.Controls.Add(progress);
                aeg = new Timer();
                aeg.Enabled = true;
                aeg.Tick += Aeg_Tick;
            }
            else if (e.Node.Text == "Tekstkast-TextBox")
            {
                tekst = new TextBox
                {
                    Font = new Font("Arial", 34, FontStyle.Italic),
                    Location = new Point(350, 400),
                    Enabled = false
                };
                MouseDoubleClick += Tekst_MouseDoubleClick;
                this.Controls.Add(tekst);
            }
            else if (e.Node.Text == "Omavorm")
            {
                MinuVorm oma = new MinuVorm("Kuulame muusikat", "Vajuta siia","Lil Skies - I");
                oma.ShowDialog();
            }
        }

        private void Tekst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tekst.Enabled)
            {
                tekst.Enabled = false;
            }
            else
            {
                tekst.Enabled = true;
            }
        }

        private void Aeg_Tick(object sender, EventArgs e)
        {
            progress.PerformStep();
        }

        private void aruut_1_2_Changed(object sender, EventArgs e)
            {
            if (aruut1.Checked && !aruut2.Checked)
            {
                DialogResult dialogResult = MessageBox.Show(
            "Do you want to be male ?",
            "Male",
            MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                {
                    Process testing = Process.Start("https://en.wikipedia.org/wiki/Man");
                }

            }
            else if (!aruut1.Checked && aruut2.Checked)
            {
                DialogResult dialogResult = MessageBox.Show(
            "Do you want to be female ?",
            "Female",
            MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                {
                    Process testing = Process.Start("https://en.wikipedia.org/wiki/Woman");
                }
            }
            else if (aruut1.Checked && aruut2.Checked)
            {
                DialogResult dialogResult = MessageBox.Show(
            "Do you want to be male and female ?",
            "Website",
            MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
                {
                    Process testing1 = Process.Start("https://en.wikipedia.org/wiki/Man");
                    Process testing2 = Process.Start("https://en.wikipedia.org/wiki/Woman");
                }
            }
        }

        private void Nupp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(
            "Do you want to open my website ?",
            "Title",
            MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Process testing = Process.Start("https://rozkov21.thkit.ee/");
            }
        }
    }
}
