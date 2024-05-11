namespace SPT_Kontrol
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            NewBDToolStripMenuItem = new ToolStripMenuItem();
            SPT963ToolStripMenuItem = new ToolStripMenuItem();
            SPT962ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            OpenProjectToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            SpravkaToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1206, 37);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewBDToolStripMenuItem, toolStripMenuItem1, OpenProjectToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            fileToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(64, 33);
            fileToolStripMenuItem.Text = "Фаил";
            // 
            // NewBDToolStripMenuItem
            // 
            NewBDToolStripMenuItem.BackColor = SystemColors.ControlLightLight;
            NewBDToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SPT963ToolStripMenuItem, SPT962ToolStripMenuItem });
            NewBDToolStripMenuItem.ForeColor = SystemColors.ControlText;
            NewBDToolStripMenuItem.Name = "NewBDToolStripMenuItem";
            NewBDToolStripMenuItem.Size = new Size(229, 26);
            NewBDToolStripMenuItem.Text = "Создать БД";
            // 
            // SPT963ToolStripMenuItem
            // 
            SPT963ToolStripMenuItem.BackColor = SystemColors.ControlLightLight;
            SPT963ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            SPT963ToolStripMenuItem.Name = "SPT963ToolStripMenuItem";
            SPT963ToolStripMenuItem.Size = new Size(156, 26);
            SPT963ToolStripMenuItem.Text = "СПТ 963";
            // 
            // SPT962ToolStripMenuItem
            // 
            SPT962ToolStripMenuItem.BackColor = SystemColors.ControlLightLight;
            SPT962ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            SPT962ToolStripMenuItem.Name = "SPT962ToolStripMenuItem";
            SPT962ToolStripMenuItem.Size = new Size(156, 26);
            SPT962ToolStripMenuItem.Text = "СПТ 962";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = SystemColors.ControlLightLight;
            toolStripMenuItem1.ForeColor = SystemColors.ControlText;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(229, 26);
            toolStripMenuItem1.Text = "Открыть проект";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // OpenProjectToolStripMenuItem
            // 
            OpenProjectToolStripMenuItem.BackColor = SystemColors.ControlLightLight;
            OpenProjectToolStripMenuItem.ForeColor = SystemColors.ControlText;
            OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem";
            OpenProjectToolStripMenuItem.Size = new Size(229, 26);
            OpenProjectToolStripMenuItem.Text = "Сохранить проект";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = SystemColors.ControlLightLight;
            exitToolStripMenuItem.ForeColor = SystemColors.ControlText;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(229, 26);
            exitToolStripMenuItem.Text = "Выход";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SpravkaToolStripMenuItem });
            helpToolStripMenuItem.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            helpToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(86, 33);
            helpToolStripMenuItem.Text = "Помощь";
            // 
            // SpravkaToolStripMenuItem
            // 
            SpravkaToolStripMenuItem.ForeColor = SystemColors.ControlText;
            SpravkaToolStripMenuItem.Name = "SpravkaToolStripMenuItem";
            SpravkaToolStripMenuItem.Size = new Size(156, 26);
            SpravkaToolStripMenuItem.Text = "Справка";
            SpravkaToolStripMenuItem.Click += SpravkaToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DeepSkyBlue;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(809, 539);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 52);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 1;
            label2.Text = "Проекты";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MintCream;
            panel3.Location = new Point(50, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(631, 1);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 178);
            label3.Name = "label3";
            label3.Size = new Size(219, 32);
            label3.TabIndex = 3;
            label3.Text = "Открыть проект";
            label3.Click += label3_Click;
            label3.MouseLeave += label3_MouseLeave;
            label3.MouseHover += label3_MouseHover;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MintCream;
            panel4.Location = new Point(49, 222);
            panel4.Name = "panel4";
            panel4.Size = new Size(341, 1);
            panel4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(49, 260);
            label4.Name = "label4";
            label4.Size = new Size(213, 32);
            label4.TabIndex = 5;
            label4.Text = "Создать проект";
            label4.Click += label4_Click;
            label4.MouseLeave += label4_MouseLeave;
            label4.MouseHover += label4_MouseHover;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MintCream;
            panel5.Location = new Point(49, 306);
            panel5.Name = "panel5";
            panel5.Size = new Size(341, 1);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DeepSkyBlue;
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(862, 68);
            panel6.Name = "panel6";
            panel6.Size = new Size(330, 538);
            panel6.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Location = new Point(37, 132);
            button3.Name = "button3";
            button3.Size = new Size(272, 52);
            button3.TabIndex = 12;
            button3.Text = "СПТ 963";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseHover += button3_MouseHover;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLightLight;
            button2.Location = new Point(37, 72);
            button2.Name = "button2";
            button2.Size = new Size(272, 52);
            button2.TabIndex = 11;
            button2.Text = "СПТ 962";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(55, 12);
            label5.Name = "label5";
            label5.Size = new Size(236, 32);
            label5.TabIndex = 8;
            label5.Text = "Список приборов";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(33, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 621);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1206, 745);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "SPT Kontroller";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem NewBDToolStripMenuItem;
        private ToolStripMenuItem SPT963ToolStripMenuItem;
        private ToolStripMenuItem SPT962ToolStripMenuItem;
        private ToolStripMenuItem OpenProjectToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem SpravkaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Panel panel6;
        private Button button3;
        private Button button2;
        private Label label5;
        private Panel panel1;
    }
}