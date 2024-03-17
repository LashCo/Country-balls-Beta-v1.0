//ChatGPT ve Copilot yardımıyla yazılmıştır

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contrty_ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form yeniForm = new Form();
            yeniForm.Text = "Beta Sürümünde Oyun Geliştiriliyor";
            yeniForm.FormBorderStyle = FormBorderStyle.None;
            yeniForm.WindowState = FormWindowState.Maximized;

            Font büyükFont = new Font("Arial", 48, FontStyle.Bold);

            Label label = new Label();
            label.Text = "Beta Sürümünde Oyun Geliştiriliyor";
            label.Font = büyükFont;
            label.AutoSize = true;
            label.Location = new Point((yeniForm.ClientSize.Width - label.Width) / 2, (yeniForm.ClientSize.Height - label.Height) / 2);

            yeniForm.Controls.Add(label);

            yeniForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form yeniForm = new Form();
            yeniForm.Text = "Grafikler";
            yeniForm.Size = new Size(300, 300);
            yeniForm.StartPosition = FormStartPosition.CenterParent;

            ListBox listBox1 = new ListBox();
            listBox1.Items.Add("Mouse Hızı: 100");
            listBox1.Items.Add("Full Graphics");
            listBox1.Location = new Point(10, 10);
            listBox1.Size = new Size(120, 100);

            ListBox listBox2 = new ListBox();
            listBox2.Items.Add("Auto");
            listBox2.Items.Add("Low Graphics");
            listBox2.Location = new Point(listBox1.Right + 10, 10);
            listBox2.Size = new Size(120, 100);

            Button geriButonu = new Button();
            geriButonu.Text = "Geri Dön";
            geriButonu.Location = new Point(10, listBox2.Bottom + 10);
            geriButonu.Size = new Size(120, 30);
            geriButonu.Click += (s, args) => yeniForm.Close();

            yeniForm.Controls.Add(listBox1);
            yeniForm.Controls.Add(listBox2);
            yeniForm.Controls.Add(geriButonu);

            yeniForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form yeniForm = new Form();
            yeniForm.Text = "Grafikler";
            yeniForm.Size = new Size(300, 300);
            yeniForm.StartPosition = FormStartPosition.CenterParent;

            ListBox listBox1 = new ListBox();
            listBox1.Items.Add("Full Graphics");
            listBox1.Items.Add("Low Graphics");
            listBox1.Location = new Point(10, 10);
            listBox1.Size = new Size(120, 100);

            Button geriButonu = new Button();
            geriButonu.Text = "Geri Dön";
            geriButonu.Location = new Point(10, listBox1.Bottom + 10);
            geriButonu.Size = new Size(120, 30);
            geriButonu.Click += (s, args) => yeniForm.Close();

            yeniForm.Controls.Add(listBox1);
            yeniForm.Controls.Add(geriButonu);

            yeniForm.ShowDialog();
        }
    }
}
