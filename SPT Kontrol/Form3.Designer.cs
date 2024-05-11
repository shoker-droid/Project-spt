namespace SPT_Kontrol
{
    partial class Form3
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
            TreeNode treeNode1 = new TreeNode("001");
            TreeNode treeNode2 = new TreeNode("003");
            TreeNode treeNode3 = new TreeNode("004");
            TreeNode treeNode4 = new TreeNode("005");
            TreeNode treeNode5 = new TreeNode("006н00");
            TreeNode treeNode6 = new TreeNode("006н01");
            TreeNode treeNode7 = new TreeNode("006н02");
            TreeNode treeNode8 = new TreeNode("006н03");
            TreeNode treeNode9 = new TreeNode("006н04");
            TreeNode treeNode10 = new TreeNode("006н05");
            TreeNode treeNode11 = new TreeNode("006н06");
            TreeNode treeNode12 = new TreeNode("006н07");
            TreeNode treeNode13 = new TreeNode("006n08");
            TreeNode treeNode14 = new TreeNode("006н09");
            TreeNode treeNode15 = new TreeNode("006н10");
            TreeNode treeNode16 = new TreeNode("006", new TreeNode[] { treeNode5, treeNode6, treeNode7, treeNode8, treeNode9, treeNode10, treeNode11, treeNode12, treeNode13, treeNode14, treeNode15 });
            TreeNode treeNode17 = new TreeNode("Параметр 0", new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode16 });
            TreeNode treeNode18 = new TreeNode("100");
            TreeNode treeNode19 = new TreeNode("101");
            TreeNode treeNode20 = new TreeNode("102");
            TreeNode treeNode21 = new TreeNode("Параметр т1", new TreeNode[] { treeNode18, treeNode19, treeNode20 });
            TreeNode treeNode22 = new TreeNode("СПТ963", new TreeNode[] { treeNode17, treeNode21 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            createBDToolStripMenuItem = new ToolStripMenuItem();
            SPT963ToolStripMenuItem = new ToolStripMenuItem();
            SPT962ToolStripMenuItem = new ToolStripMenuItem();
            OpenProjectToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            SpravkaToolStripMenuItem = new ToolStripMenuItem();
            BackMainToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            treeView1 = new TreeView();
            button1 = new Button();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel6 = new Panel();
            label2 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabPage2 = new TabPage();
            panel3 = new Panel();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            label7 = new Label();
            menuStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem, BackMainToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1206, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createBDToolStripMenuItem, OpenProjectToolStripMenuItem, ExitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // createBDToolStripMenuItem
            // 
            createBDToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SPT963ToolStripMenuItem, SPT962ToolStripMenuItem });
            createBDToolStripMenuItem.Name = "createBDToolStripMenuItem";
            createBDToolStripMenuItem.Size = new Size(202, 26);
            createBDToolStripMenuItem.Text = "Создать БД";
            // 
            // SPT963ToolStripMenuItem
            // 
            SPT963ToolStripMenuItem.Name = "SPT963ToolStripMenuItem";
            SPT963ToolStripMenuItem.Size = new Size(148, 26);
            SPT963ToolStripMenuItem.Text = "СПТ 963";
            SPT963ToolStripMenuItem.Click += SPT963ToolStripMenuItem_Click;
            // 
            // SPT962ToolStripMenuItem
            // 
            SPT962ToolStripMenuItem.Name = "SPT962ToolStripMenuItem";
            SPT962ToolStripMenuItem.Size = new Size(148, 26);
            SPT962ToolStripMenuItem.Text = "СПТ 962";
            SPT962ToolStripMenuItem.Click += SPT962ToolStripMenuItem_Click;
            // 
            // OpenProjectToolStripMenuItem
            // 
            OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem";
            OpenProjectToolStripMenuItem.Size = new Size(202, 26);
            OpenProjectToolStripMenuItem.Text = "Открыть проект";
            OpenProjectToolStripMenuItem.Click += OpenProjectToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(202, 26);
            ExitToolStripMenuItem.Text = "Выход";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SpravkaToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(83, 24);
            helpToolStripMenuItem.Text = "Помощь";
            // 
            // SpravkaToolStripMenuItem
            // 
            SpravkaToolStripMenuItem.Name = "SpravkaToolStripMenuItem";
            SpravkaToolStripMenuItem.Size = new Size(150, 26);
            SpravkaToolStripMenuItem.Text = "Справка";
            SpravkaToolStripMenuItem.Click += SpravkaToolStripMenuItem_Click;
            // 
            // BackMainToolStripMenuItem
            // 
            BackMainToolStripMenuItem.Name = "BackMainToolStripMenuItem";
            BackMainToolStripMenuItem.Size = new Size(123, 24);
            BackMainToolStripMenuItem.Text = "Выход в меню";
            BackMainToolStripMenuItem.Click += BackMainToolStripMenuItem_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.BackColor = Color.DeepSkyBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Location = new Point(0, 29);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(278, 717);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 43);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 8);
            label1.Name = "label1";
            label1.Size = new Size(135, 26);
            label1.TabIndex = 2;
            label1.Text = "Параметры";
            // 
            // panel2
            // 
            panel2.Controls.Add(treeView1);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 653);
            panel2.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(10, 23);
            treeView1.Name = "treeView1";
            treeNode1.Name = "parametr-001";
            treeNode1.Text = "001";
            treeNode2.Name = "parametr-003";
            treeNode2.Text = "003";
            treeNode3.Name = "parametr-004";
            treeNode3.Text = "004";
            treeNode4.Name = "parametr-005";
            treeNode4.Text = "005";
            treeNode5.Name = "parametr-006n00";
            treeNode5.Text = "006н00";
            treeNode6.Name = "parametr-006n01";
            treeNode6.Text = "006н01";
            treeNode7.Name = "parametr-006n02";
            treeNode7.Text = "006н02";
            treeNode8.Name = "parametr-006n03";
            treeNode8.Text = "006н03";
            treeNode9.Name = "parametr-006n04";
            treeNode9.Text = "006н04";
            treeNode10.Name = "parametr-006n05";
            treeNode10.Text = "006н05";
            treeNode11.Name = "parametr-006n06";
            treeNode11.Text = "006н06";
            treeNode12.Name = "parametr-006n07";
            treeNode12.Text = "006н07";
            treeNode13.Name = "parametr-006n08";
            treeNode13.Text = "006n08";
            treeNode14.Name = "parametr-006n09";
            treeNode14.Text = "006н09";
            treeNode15.Name = "parametr-006n10";
            treeNode15.Text = "006н10";
            treeNode16.Name = "parametr-006";
            treeNode16.Text = "006";
            treeNode17.Name = "parametr-0";
            treeNode17.Text = "Параметр 0";
            treeNode18.Name = "parametr-100";
            treeNode18.Text = "100";
            treeNode19.Name = "parametr-101";
            treeNode19.Text = "101";
            treeNode20.Name = "parametr-102";
            treeNode20.Text = "102";
            treeNode21.Name = "parametr-t1";
            treeNode21.Text = "Параметр т1";
            treeNode22.Name = "SPT963";
            treeNode22.Text = "СПТ963";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode22 });
            treeView1.Size = new Size(228, 583);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // button1
            // 
            button1.Location = new Point(11, 611);
            button1.Name = "button1";
            button1.Size = new Size(229, 41);
            button1.TabIndex = 8;
            button1.Text = "Вывод БД";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(280, 28);
            panel4.Name = "panel4";
            panel4.Size = new Size(448, 367);
            panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(446, 320);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DeepSkyBlue;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(280, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(446, 37);
            panel5.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(122, 5);
            label3.Name = "label3";
            label3.Size = new Size(196, 23);
            label3.TabIndex = 7;
            label3.Text = "Настройки элемента";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel6);
            flowLayoutPanel2.Controls.Add(tabControl1);
            flowLayoutPanel2.Location = new Point(280, 401);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(449, 340);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DeepSkyBlue;
            panel6.Controls.Add(label2);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(445, 35);
            panel6.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(151, 5);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 7;
            label2.Text = "Конфигурация";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 44);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(443, 308);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(435, 275);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Информация";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 71);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 7;
            label6.Text = "Описание:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 108);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 152);
            textBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 28);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 1;
            label5.Text = "значения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 0;
            label4.Text = "Единицы измерения:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(435, 275);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Лист 2 (В разработке)";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel7);
            panel3.Location = new Point(731, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(475, 715);
            panel3.TabIndex = 9;
            // 
            // button9
            // 
            button9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(64, 553);
            button9.Name = "button9";
            button9.Size = new Size(349, 59);
            button9.TabIndex = 9;
            button9.Text = "Схема подключения прибора";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button2_Click;
            // 
            // button8
            // 
            button8.Location = new Point(359, 452);
            button8.Name = "button8";
            button8.Size = new Size(43, 43);
            button8.TabIndex = 8;
            button8.Text = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button2_Click;
            // 
            // button7
            // 
            button7.Location = new Point(308, 452);
            button7.Name = "button7";
            button7.Size = new Size(43, 43);
            button7.TabIndex = 7;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button2_Click;
            // 
            // button6
            // 
            button6.Location = new Point(258, 452);
            button6.Name = "button6";
            button6.Size = new Size(43, 43);
            button6.TabIndex = 6;
            button6.Text = "5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(208, 452);
            button5.Name = "button5";
            button5.Size = new Size(43, 43);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(157, 452);
            button4.Name = "button4";
            button4.Size = new Size(43, 43);
            button4.TabIndex = 4;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(108, 452);
            button3.Name = "button3";
            button3.Size = new Size(43, 43);
            button3.TabIndex = 3;
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(64, 451);
            button2.Name = "button2";
            button2.Size = new Size(43, 43);
            button2.TabIndex = 2;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 379);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DeepSkyBlue;
            panel7.Controls.Add(label7);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(475, 35);
            panel7.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(90, 5);
            label7.Name = "label7";
            label7.Size = new Size(313, 23);
            label7.TabIndex = 1;
            label7.Text = "Графический интерфейс прибора";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 745);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Location = new Point(280, 28);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Настройка СПТ963";
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem createBDToolStripMenuItem;
        private ToolStripMenuItem OpenProjectToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem SPT963ToolStripMenuItem;
        private ToolStripMenuItem SPT962ToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem SpravkaToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TreeView treeView1;
        private Panel panel4;
        private Panel panel5;
        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel6;
        private Label label2;
        private Label label3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private TextBox textBox1;
        private Label label6;
        private Button button1;
        private Panel panel3;
        private Panel panel7;
        private Label label7;
        private PictureBox pictureBox1;
        private Button button2;
        private ToolStripMenuItem BackMainToolStripMenuItem;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
    }
}