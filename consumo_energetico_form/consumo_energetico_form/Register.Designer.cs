namespace consumo_energetico_form
{
    partial class formRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegister));
            panel1 = new Panel();
            panel2 = new Panel();
            closed2 = new Button();
            label1 = new Label();
            login = new Button();
            label2 = new Label();
            user1 = new TextBox();
            password2 = new TextBox();
            picture2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 39);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(closed2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(533, 38);
            panel2.TabIndex = 1;
            // 
            // closed2
            // 
            closed2.FlatAppearance.BorderColor = Color.DarkGray;
            closed2.FlatAppearance.BorderSize = 0;
            closed2.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            closed2.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            closed2.FlatStyle = FlatStyle.Flat;
            closed2.Image = (Image)resources.GetObject("closed2.Image");
            closed2.Location = new Point(479, 6);
            closed2.Name = "closed2";
            closed2.Size = new Size(56, 29);
            closed2.TabIndex = 2;
            closed2.UseVisualStyleBackColor = true;
            closed2.Click += closed2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 355);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 8;
            label1.Text = "Usuario";
            // 
            // login
            // 
            login.BackColor = Color.DarkGray;
            login.FlatAppearance.BorderColor = Color.Silver;
            login.FlatAppearance.BorderSize = 0;
            login.FlatAppearance.MouseDownBackColor = Color.Silver;
            login.FlatAppearance.MouseOverBackColor = Color.Silver;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.Location = new Point(203, 538);
            login.Name = "login";
            login.Size = new Size(159, 50);
            login.TabIndex = 9;
            login.Text = "Guardar";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 450);
            label2.Name = "label2";
            label2.Size = new Size(104, 23);
            label2.TabIndex = 10;
            label2.Text = "Contraseña";
            // 
            // user1
            // 
            user1.Location = new Point(191, 355);
            user1.Name = "user1";
            user1.Size = new Size(294, 27);
            user1.TabIndex = 11;
            // 
            // password2
            // 
            password2.Location = new Point(191, 446);
            password2.Name = "password2";
            password2.Size = new Size(294, 27);
            password2.TabIndex = 12;
            // 
            // picture2
            // 
            picture2.BackgroundImageLayout = ImageLayout.None;
            picture2.Image = (Image)resources.GetObject("picture2.Image");
            picture2.Location = new Point(168, 57);
            picture2.Name = "picture2";
            picture2.Size = new Size(226, 232);
            picture2.TabIndex = 13;
            picture2.TabStop = false;
            // 
            // formRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(533, 648);
            Controls.Add(picture2);
            Controls.Add(password2);
            Controls.Add(user1);
            Controls.Add(label2);
            Controls.Add(login);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formRegister";
            Text = "Form2";
            Load += formRegister_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button closed2;
        private Label label1;
        private Button login;
        private Label label2;
        private TextBox user1;
        private TextBox password2;
        private PictureBox picture2;
    }
}