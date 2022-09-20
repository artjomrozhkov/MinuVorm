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



            puu.AfterSelect += Puu_AfterSelect;

            puu.Nodes.Add(oksad);
            this.Controls.Add(puu);
        }

        private void Puu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Nupp-Button")
            {
                nupp = new Button();
                nupp.Text = "Vajuta siia";
                nupp.Height = 30;
                nupp.Width = 100;
                nupp.Location= new Point(250, 240);
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
            else
            {
                this.Close();
            }
        }
    }
}
