using System.Media;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

         
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SendToBack();
           
            string gifPath = Path.Combine(Application.StartupPath, "1657119793-1657119793-free-zombie-invasion-3-live-wallpaper (1).gif");
            string soundPath = Path.Combine(Application.StartupPath, "C:\\Users\\wajid\\source\\repos\\spooky_logi\\WinFormsApp1\\background_sound.wav");
            if (File.Exists(gifPath))
            {
               
                pictureBox1.Image = Image.FromFile(gifPath);
            }
            if (File.Exists(soundPath))
            {
                SoundPlayer audio = new SoundPlayer(soundPath);
                audio.Play();
            }


        }
        String user = "ubaid";
        String pass = "T00742600";



        private async void button_Click(object sender, EventArgs e)
        {
            String temp1 = username.Text;
            String temp2 = user_password.Text;
            if (temp1.IsWhiteSpace() || temp2.IsWhiteSpace())
            {
                MessageBox.Show("Please populate the fields above");
            }
            else if (temp1.Equals(user) && temp2.Equals(pass))
            {
                MessageBox.Show("You have entered correct details!");

            }
            else
            {
                await DoJumpscare();
                MessageBox.Show("Wrong details... you shouldn't have done that!");
            }

        }

        private async Task DoJumpscare()
        {

            string gifPath = Path.Combine(Application.StartupPath, "C:\\Users\\wajid\\source\\repos\\spooky_logi\\WinFormsApp1\\1657119793-1657119793-free-zombie-invasion-3-live-wallpaper (1).gif");
            string scarePic = Path.Combine(Application.StartupPath, "C:\\Users\\wajid\\source\\repos\\spooky_logi\\WinFormsApp1\\monster-scared.gif");
            string soundPath = Path.Combine(Application.StartupPath, "C:\\Users\\wajid\\source\\repos\\spooky_logi\\WinFormsApp1\\jusatti890-scream-horror-sfx-490909.wav");
            if (File.Exists(scarePic))
            {
                if (File.Exists(soundPath))
                {
                    SoundPlayer audio = new SoundPlayer(soundPath);
                    audio.Play(); 
                }
                pictureBox1.Image = Image.FromFile(scarePic);
                pictureBox1.BringToFront();
                await Task.Delay(2000);

                
                if (File.Exists(gifPath))
                {
                    pictureBox1.Image = Image.FromFile(gifPath);
                    pictureBox1.SendToBack();

                }
            }
            else
            {
              
                MessageBox.Show("Could not find jumpscare image at:\n" + scarePic);
            }
        }




    }
}
