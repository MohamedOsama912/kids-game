using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace kids_game_app
{
    public partial class sign_up_frm : Form
    {
        SoundPlayer signup_command_effect = new SoundPlayer(@"commands_sound\new_start.wav");
        SoundPlayer back_effect = new SoundPlayer(@"back_effect.wav");
        SoundPlayer signup_click_effect = new SoundPlayer(@"maro-jump-sound-effect_1.wav");

        public sign_up_frm()
        {
            InitializeComponent();
        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void signup_spkr_btn_Click(object sender, EventArgs e)
        {
            signup_command_effect.Play();
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            signup_command_effect.Stop();
            signup_click_effect.Play();
            enter_the_game_frm entergame = new enter_the_game_frm();
            entergame.Show();
            this.Hide();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            signup_command_effect.Stop();
            back_effect.Play();
            welcome_frm welcomfrom = new welcome_frm();
            welcomfrom.Show();
            this.Hide();
        }
    }
}
