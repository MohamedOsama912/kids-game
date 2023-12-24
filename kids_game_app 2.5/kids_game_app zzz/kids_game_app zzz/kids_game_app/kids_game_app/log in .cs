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

    public partial class log_in_frm : Form
    {
        SoundPlayer login_click_effect = new SoundPlayer(@"maro-jump-sound-effect_1.wav");
        SoundPlayer login_command_sound = new SoundPlayer(@"commands_sound\load.wav");
        SoundPlayer back_arrow = new SoundPlayer(@"back_effect.wav");
        public log_in_frm()
        {
            InitializeComponent();

        }

        private void log_in__button_Click(object sender, EventArgs e)
        {
            login_command_sound.Stop();
            login_click_effect.Play();
            enter_the_game_frm entergame = new enter_the_game_frm();
            entergame.Show();
            this.Hide();
        }

        private void login_spkr_btn_Click(object sender, EventArgs e)
        {
            login_command_sound.Play();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            welcome_frm welcomform = new welcome_frm();
            login_command_sound.Stop();
            back_arrow.Play();
            welcomform.Show();
            this.Hide();
        }

        private void log_in_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
