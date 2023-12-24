namespace kids_game_app
{
    partial class sign_up_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sign_up_frm));
            back_button = new Button();
            sign_up_btn = new Button();
            user_name_label = new Label();
            sign_up_textBox = new TextBox();
            signup_spkr_btn = new Button();
            SuspendLayout();
            // 
            // back_button
            // 
            back_button.Image = Properties.Resources.باك_ياللي_;
            back_button.Location = new Point(50, 50);
            back_button.Margin = new Padding(4, 3, 4, 3);
            back_button.Name = "back_button";
            back_button.Size = new Size(141, 51);
            back_button.TabIndex = 0;
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // sign_up_btn
            // 
            sign_up_btn.BackColor = SystemColors.Info;
            sign_up_btn.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            sign_up_btn.Location = new Point(539, 351);
            sign_up_btn.Margin = new Padding(4, 3, 4, 3);
            sign_up_btn.Name = "sign_up_btn";
            sign_up_btn.Size = new Size(231, 55);
            sign_up_btn.TabIndex = 1;
            sign_up_btn.Text = "Sign Up";
            sign_up_btn.UseVisualStyleBackColor = false;
            sign_up_btn.Click += sign_up_btn_Click;
            // 
            // user_name_label
            // 
            user_name_label.AutoSize = true;
            user_name_label.BackColor = SystemColors.Info;
            user_name_label.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            user_name_label.Location = new Point(150, 250);
            user_name_label.Margin = new Padding(4, 0, 4, 0);
            user_name_label.Name = "user_name_label";
            user_name_label.Size = new Size(247, 46);
            user_name_label.TabIndex = 2;
            user_name_label.Text = "User Name :";
            // 
            // sign_up_textBox
            // 
            sign_up_textBox.Location = new Point(424, 267);
            sign_up_textBox.Margin = new Padding(4, 3, 4, 3);
            sign_up_textBox.Name = "sign_up_textBox";
            sign_up_textBox.Size = new Size(454, 29);
            sign_up_textBox.TabIndex = 3;
            // 
            // signup_spkr_btn
            // 
            signup_spkr_btn.BackgroundImage = Properties.Resources.photo_2023_12_23_09_30_15;
            signup_spkr_btn.Location = new Point(600, 100);
            signup_spkr_btn.Name = "signup_spkr_btn";
            signup_spkr_btn.Size = new Size(96, 94);
            signup_spkr_btn.TabIndex = 4;
            signup_spkr_btn.UseVisualStyleBackColor = true;
            signup_spkr_btn.Click += signup_spkr_btn_Click;
            // 
            // sign_up_frm
            // 
            AutoScaleDimensions = new SizeF(12F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(signup_spkr_btn);
            Controls.Add(sign_up_textBox);
            Controls.Add(user_name_label);
            Controls.Add(sign_up_btn);
            Controls.Add(back_button);
            Font = new Font("Showcard Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "sign_up_frm";
            Text = "sign_up";
            Load += sign_up_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_button;
        private Button sign_up_btn;
        private Label user_name_label;
        private TextBox sign_up_textBox;
        private Button signup_spkr_btn;
    }
}