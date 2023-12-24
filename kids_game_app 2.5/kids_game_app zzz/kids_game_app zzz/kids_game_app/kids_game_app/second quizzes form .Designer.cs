namespace kids_game_app
{
    partial class second_quizzes_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(second_quizzes_form));
            next_button = new Button();
            ans1_button = new Button();
            ans2_button = new Button();
            question_audio_button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // next_button
            // 
            next_button.Image = Properties.Resources.next_1;
            next_button.Location = new Point(908, 56);
            next_button.Name = "next_button";
            next_button.Size = new Size(94, 51);
            next_button.TabIndex = 4;
            next_button.UseVisualStyleBackColor = true;
            // 
            // ans1_button
            // 
            ans1_button.Location = new Point(282, 312);
            ans1_button.Name = "ans1_button";
            ans1_button.Size = new Size(150, 120);
            ans1_button.TabIndex = 6;
            ans1_button.UseVisualStyleBackColor = true;
            // 
            // ans2_button
            // 
            ans2_button.Location = new Point(615, 312);
            ans2_button.Name = "ans2_button";
            ans2_button.Size = new Size(150, 120);
            ans2_button.TabIndex = 7;
            ans2_button.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Image = Properties.Resources.بيت1;
            button1.Location = new Point(50, 50);
            button1.Name = "button1";
            button1.Size = new Size(74, 63);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            // 
            // second_quizzes_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1062, 673);
            Controls.Add(button1);
            Controls.Add(question_audio_button);
            Controls.Add(ans2_button);
            Controls.Add(ans1_button);
            Controls.Add(next_button);
            Name = "second_quizzes_form";
            Text = "second_quizzes_form";
            ResumeLayout(false);
        }

        #endregion

        private Button next_button;
        private Button ans1_button;
        private Button ans2_button;
        private Button question_audio_button;
        private Button button1;
    }
}