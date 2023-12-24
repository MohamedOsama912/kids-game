using System.Media;
using kids_game_app.data;
namespace kids_game_app
{
    public partial class welcome_frm : Form
    {
        SoundPlayer sound_effect = new SoundPlayer(@"backgroud_effect\01. Ground Theme.wav");
        SoundPlayer welcome_command = new SoundPlayer(@"commands_sound\welcom.wav");
        SoundPlayer clickeffect = new SoundPlayer(@"maro-jump-sound-effect_1.wav");
        public welcome_frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sound_effect.Play();
        }

        private void wlcom_spekr_btn_Click(object sender, EventArgs e)
        {
            welcome_command.Play();
        }

        private void new_start_button_Click(object sender, EventArgs e)
        {
            welcome_command.Stop();
            clickeffect.Play();
            sign_up_frm sigup_frm = new sign_up_frm();
            sigup_frm.Show();
            this.Hide();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            welcome_command.Stop();
            clickeffect.Play();
            log_in_frm login_frm = new log_in_frm();
            login_frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         dbconnection db = new dbconnection();
         if(db.Database.EnsureCreated())
            {
                MessageBox.Show("done");
            }
        }
    }
}
