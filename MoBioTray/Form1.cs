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

namespace MoBioTray
{
    public partial class Form1 : Form
    {
        NotifyIcon icon = new NotifyIcon();

        public Form1()
        {
            InitializeComponent();
            icon.Icon = new System.Drawing.Icon("./Microscope-red.ico");
            icon.Visible = true;
            icon.BalloonTipText = "Biomedicina";
            icon.BalloonTipTitle = "Dr. Mônica Anjos";
            icon.BalloonTipIcon = ToolTipIcon.Warning;
            icon.ShowBalloonTip(1000);
            icon.MouseUp += Icon_MouseUp;
            icon.DoubleClick += Icon_DoubleClick;
            icon.MouseClick += Icon_MouseClick;
            icon.BalloonTipClicked += Icon_BalloonTipClicked;
            icon.Text = "Eu sou biomédica top!";


            timer1.Enabled = true;
            timer1.Interval = 3600000;
        }

        private void Icon_BalloonTipClicked(object sender, EventArgs e)
        {
            Process.Start("https://cfbm.gov.br/");
        }

        private void Icon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();

            if (e.Button == MouseButtons.Right)
            {
                icon.BalloonTipText = "Já estudou tudo hoje?";
                icon.BalloonTipTitle = "O futuro é agora";
                icon.BalloonTipIcon = ToolTipIcon.Error;
                icon.ShowBalloonTip(1000);
            }
            else//left or middle click
            {
                icon.BalloonTipText = "Go study!";
                icon.BalloonTipTitle = "Biomedicina";
                icon.BalloonTipIcon = ToolTipIcon.Info;
                icon.ShowBalloonTip(1000);
            }
        }

        private void Icon_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Icon_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour > 6 && DateTime.Now.Hour < 7)
            {
                icon.BalloonTipText = "Bom dia";
                icon.BalloonTipTitle = "Biomedicina";
                icon.BalloonTipIcon = ToolTipIcon.Error;
            }
            else if (DateTime.Now.Hour > 7 && DateTime.Now.Hour < 8)
            {
                icon.BalloonTipText = "Acooorda";
                icon.BalloonTipTitle = "Biomedicina";
                icon.BalloonTipIcon = ToolTipIcon.Error;
            }
            else if (DateTime.Now.Hour > 8 && DateTime.Now.Hour < 9)
            {
                icon.BalloonTipText = "Bom dia, partiu estudar";
                icon.BalloonTipTitle = "Bio";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 9 && DateTime.Now.Hour < 10)
            {
                icon.BalloonTipText = "Zzzz, one more day of study";
                icon.BalloonTipTitle = "Biomedicina";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 10 && DateTime.Now.Hour < 11)
            {
                icon.BalloonTipText = "Já está com fome?";
                icon.BalloonTipTitle = "Bio";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 13)
            {
                icon.BalloonTipText = "Hora do almoço hein";
                icon.BalloonTipTitle = "Work";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 13 && DateTime.Now.Hour < 14)
            {
                icon.BalloonTipText = "Já almoçou?";
                icon.BalloonTipTitle = "Biomedicina";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 15 && DateTime.Now.Hour < 16)
            {
                icon.BalloonTipText = "Estudar mais um poquinho";
                icon.BalloonTipTitle = "Perícia";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 16 && DateTime.Now.Hour < 17)
            {
                icon.BalloonTipText = "Um lanche da tarde cai bem";
                icon.BalloonTipTitle = "Biomédica";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 17 && DateTime.Now.Hour < 18)
            {
                icon.BalloonTipText = "Um pouco de diversão e pausa nos estudos";
                icon.BalloonTipTitle = "Investigadora perita";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 18 && DateTime.Now.Hour < 19)
            {
                icon.BalloonTipText = "Assistir algum vídeo?";
                icon.BalloonTipTitle = "Perita";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 20 && DateTime.Now.Hour < 21)
            {
                icon.BalloonTipText = "Escrever um texto sobre biomedicina";
                icon.BalloonTipTitle = "Biomedicina";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 21 && DateTime.Now.Hour < 22)
            {
                icon.BalloonTipText = "Você é mais inteligente do que imagina";
                icon.BalloonTipTitle = "Biomédica";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (DateTime.Now.Hour > 23 && DateTime.Now.Hour < 24)
            {
                icon.BalloonTipText = "Hora de dormir";
                icon.BalloonTipTitle = "Bio";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else
            {
                icon.BalloonTipText = "ZzzzzzzzZzZ";
                icon.BalloonTipTitle = "Biomedical";
                icon.BalloonTipIcon = ToolTipIcon.Warning;
            }


            icon.ShowBalloonTip(1000);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start("https://cfbm.gov.br/");
        }
    }
}
