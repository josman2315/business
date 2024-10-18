namespace consumo_energetico_form
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            panel = new Panel();
            closed = new Button();
            picture = new PictureBox();
            password = new TextBox();
            user = new TextBox();
            checkBox = new CheckBox();
            login = new Button();
            register = new Button();
            label1 = new Label();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Gray;
            panel.Controls.Add(closed);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(618, 38);
            panel.TabIndex = 0;
            panel.Paint += panel1_Paint;
            // 
            // closed
            // 
            closed.FlatAppearance.BorderColor = Color.DarkGray;
            closed.FlatAppearance.BorderSize = 0;
            closed.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            closed.FlatAppearance.MouseOverBackColor = Color.DarkGray;
            closed.FlatStyle = FlatStyle.Flat;
            closed.Image = (Image)resources.GetObject("closed.Image");
            closed.Location = new Point(559, 3);
            closed.Name = "closed";
            closed.Size = new Size(56, 29);
            closed.TabIndex = 1;
            closed.UseVisualStyleBackColor = true;
            closed.Click += button1_Click;
            // 
            // picture
            // 
            picture.BackgroundImageLayout = ImageLayout.None;
            picture.Image = (Image)resources.GetObject("picture.Image");
            picture.Location = new Point(194, 67);
            picture.Name = "picture";
            picture.Size = new Size(226, 232);
            picture.TabIndex = 1;
            picture.TabStop = false;
            picture.Click += pictureBox1_Click;
            // 
            // password
            // 
            password.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(157, 419);
            password.Name = "password";
            password.Size = new Size(304, 35);
            password.TabIndex = 2;
            password.Text = "Ingrese su contraseña";
            password.TextAlign = HorizontalAlignment.Center;
            // 
            // user
            // 
            user.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            user.Location = new Point(157, 336);
            user.Name = "user";
            user.Size = new Size(304, 35);
            user.TabIndex = 3;
            user.Text = "Ingrese su usuario";
            user.TextAlign = HorizontalAlignment.Center;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox.Location = new Point(377, 481);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(94, 26);
            checkBox.TabIndex = 4;
            checkBox.Text = "Mostrar";
            checkBox.UseVisualStyleBackColor = true;
            checkBox.CheckedChanged += checkBox1_CheckedChanged;
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
            login.Location = new Point(236, 538);
            login.Name = "login";
            login.Size = new Size(159, 50);
            login.TabIndex = 5;
            login.Text = "Entrar";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // register
            // 
            register.BackColor = Color.Transparent;
            register.FlatAppearance.BorderColor = Color.White;
            register.FlatAppearance.BorderSize = 0;
            register.FlatAppearance.MouseDownBackColor = Color.White;
            register.FlatAppearance.MouseOverBackColor = Color.White;
            register.FlatStyle = FlatStyle.Flat;
            register.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register.ForeColor = Color.Gray;
            register.Location = new Point(236, 654);
            register.Name = "register";
            register.Size = new Size(159, 47);
            register.TabIndex = 6;
            register.Text = "Registrarme";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 619);
            label1.Name = "label1";
            label1.Size = new Size(186, 22);
            label1.TabIndex = 7;
            label1.Text = "¿No estás registrado?";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(618, 740);
            Controls.Add(label1);
            Controls.Add(register);
            Controls.Add(login);
            Controls.Add(checkBox);
            Controls.Add(user);
            Controls.Add(password);
            Controls.Add(panel);
            Controls.Add(picture);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            Text = "Form1";
            Load += form_Load;
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Button closed;
        private PictureBox picture;
        private TextBox password;
        private TextBox user;
        private CheckBox checkBox;
        private Button login;
        private Button register;
        private Label label1;
    }
}
