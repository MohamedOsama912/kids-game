namespace kids_game_app
{
    partial class log_in_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log_in_frm));
            user_name_label = new Label();
            log_in_btn = new Button();
            back_btn = new Button();
            log_in_textBox = new TextBox();
            login_spkr_btn = new Button();
            SuspendLayout();
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
            user_name_label.TabIndex = 3;
            user_name_label.Text = "User Name :";
            // 
            // log_in_btn
            // 
            log_in_btn.BackColor = SystemColors.Info;
            log_in_btn.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            log_in_btn.Location = new Point(539, 351);
            log_in_btn.Margin = new Padding(4, 3, 4, 3);
            log_in_btn.Name = "log_in_btn";
            log_in_btn.Size = new Size(231, 55);
            log_in_btn.TabIndex = 4;
            log_in_btn.Text = "Log in";
            log_in_btn.UseVisualStyleBackColor = false;
            log_in_btn.Click += log_in__button_Click;
            // 
            // back_btn
            // 
            back_btn.Image = Properties.Resources.باك_ياللي_;
            back_btn.Location = new Point(50, 50);
            back_btn.Margin = new Padding(4, 3, 4, 3);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(106, 46);
            back_btn.TabIndex = 5;
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // log_in_textBox
            // 
            log_in_textBox.Location = new Point(433, 269);
            log_in_textBox.Margin = new Padding(4, 3, 4, 3);
            log_in_textBox.Name = "log_in_textBox";
            log_in_textBox.Size = new Size(454, 27);
            log_in_textBox.TabIndex = 6;
            // 
            // login_spkr_btn
            // 
            login_spkr_btn.BackgroundImage = Properties.Resources.photo_2023_12_23_09_30_151;
            login_spkr_btn.Location = new Point(600, 100);
            login_spkr_btn.Name = "login_spkr_btn";
            login_spkr_btn.Size = new Size(96, 94);
            login_spkr_btn.TabIndex = 7;
            login_spkr_btn.UseVisualStyleBackColor = true;
            login_spkr_btn.Click += login_spkr_btn_Click;
            // 
            // log_in_frm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(login_spkr_btn);
            Controls.Add(log_in_textBox);
            Controls.Add(back_btn);
            Controls.Add(log_in_btn);
            Controls.Add(user_name_label);
            Name = "log_in_frm";
            Text = "log_in";
            Load += log_in_frm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label user_name_label;
        private Button log_in_btn;
        private Button back_btn;
        private TextBox log_in_textBox;
        private Button login_spkr_btn;
    }
}