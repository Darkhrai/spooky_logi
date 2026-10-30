namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            username = new TextBox();
            user_password = new TextBox();
            button = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(322, 170);
            username.Name = "username";
            username.PlaceholderText = "User Name";
            username.Size = new Size(125, 27);
            username.TabIndex = 0;
            // 
            // user_password
            // 
            user_password.Location = new Point(322, 221);
            user_password.Name = "user_password";
            user_password.PlaceholderText = "Enter Password";
            user_password.Size = new Size(125, 27);
            user_password.TabIndex = 1;
            user_password.UseSystemPasswordChar = true;
            // 
            // button
            // 
            button.Location = new Point(332, 279);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 2;
            button.Text = "check";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button);
            Controls.Add(user_password);
            Controls.Add(username);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "..-Corrupted-..";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox user_password;
        private Button button;
        private PictureBox pictureBox1;
    }
}
