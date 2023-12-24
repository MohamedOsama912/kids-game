namespace kids_game_app
{
    partial class fourth_quizzes_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fourth_quizzes_form));
            back_home_button = new Button();
            next_button = new Button();
            question_audio_button = new Button();
            ans1_button = new Button();
            ans2_button = new Button();
            SuspendLayout();
            // 
            // back_home_button
            // 
            back_home_button.Image = Properties.Resources.بيت1;
            back_home_button.Location = new Point(50, 50);
            back_home_button.Name = "back_home_button";
            back_home_button.Size = new Size(74, 63);
            back_home_button.TabIndex = 5;
            back_home_button.UseVisualStyleBackColor = true;
            // 
            // next_button
            // 
            next_button.Image = (Image)resources.GetObject("next_button.Image");
            next_button.Location = new Point(916, 58);
            next_button.Name = "next_button";
            next_button.Size = new Size(94, 47);
            next_button.TabIndex = 6;
            next_button.UseVisualStyleBackColor = true;
            // 
            // question_audio_button
            // 
            question_audio_button.Image = Properties.Resources.مايك_1;
            question_audio_button.Location = new Point(435, 120);
            question_audio_button.Name = "question_audio_button";
            question_audio_button.Size = new Size(183, 151);
            question_audio_button.TabIndex = 8;
            question_audio_button.UseVisualStyleBackColor = true;
            // 
            // ans1_button
            // 
            ans1_button.Location = new Point(284, 312);
            ans1_button.Name = "ans1_button";
            ans1_button.Size = new Size(150, 120);
            ans1_button.TabIndex = 9;
            ans1_button.UseVisualStyleBackColor = true;
            // 
            // ans2_button
            // 
            ans2_button.Location = new Point(613, 312);
            ans2_button.Name = "ans2_button";
            ans2_button.Size = new Size(150, 120);
            ans2_button.TabIndex = 10;
            ans2_button.UseVisualStyleBackColor = true;
            // 
            // fourth_quizzes_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.سحابة_باك_جراوند;
            ClientSize = new Size(1062, 673);
            Controls.Add(ans2_button);
            Controls.Add(ans1_button);
            Controls.Add(question_audio_button);
            Controls.Add(next_button);
            Controls.Add(back_home_button);
            Name = "fourth_quizzes_form";
            Text = "fourth_quizzes_form";
            ResumeLayout(false);
        }

        #endregion

        private Button back_home_button;
        private Button next_button;
        private Button question_audio_button;
        private Button ans1_button;
        private Button ans2_button;
    }
}