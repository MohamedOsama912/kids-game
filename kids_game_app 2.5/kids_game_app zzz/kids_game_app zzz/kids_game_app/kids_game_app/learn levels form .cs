using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kids_game_app
{
    public partial class learn_levels_form : Form
    {
        bool chickExit = true;
        public learn_levels_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            chickExit = false;
            Application.OpenForms[2].Show();
            this.Close();
        }

        private void level1_button_Click(object sender, EventArgs e)
        {
            first_learning_form f1 = new first_learning_form();
            f1.Show();
            this.Hide();
        }

        private void level2_button_Click(object sender, EventArgs e)
        {
            second_learning_form f2 = new second_learning_form();
            f2.Show();
            this.Hide();
        }

        private void level3_button_Click(object sender, EventArgs e)
        {
            third_learning_form_cs f3 = new third_learning_form_cs();
            f3.Show();
            this.Hide();
        }

        private void level4_button_Click(object sender, EventArgs e)
        {
            fourth_learning_form f4 = new fourth_learning_form();
            f4.Show();
            this.Hide();
        }

        private void level5_button_Click(object sender, EventArgs e)
        {
            fifth_learning_form f5 = new fifth_learning_form();
            f5.Show();
            this.Hide();
        }

        private void level6_button_Click(object sender, EventArgs e)
        {
            sixth_learning_form f6 = new sixth_learning_form();
            f6.Show();
            this.Hide();
        }

        private void learn_levels_form_Load(object sender, EventArgs e)
        {

        }

        private void learn_levels_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(chickExit) Application.Exit();
        }
    }
}
