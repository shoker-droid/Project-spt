using System.Security.Cryptography;
using System.Xml.Serialization;

namespace SPT_Kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.WhiteSmoke;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.WhiteSmoke;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.White;
        }


        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.WhiteSmoke;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.WhiteSmoke;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 spt962form = new Form2();
            spt962form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static int parentX, parentY;
        private void label4_Click(object sender, EventArgs e)
        {
            Form formModalBackground = new Form();
            using (FormModal modalFirstWindow = new FormModal())
            {
                formModalBackground.StartPosition = FormStartPosition.Manual;
                formModalBackground.FormBorderStyle = FormBorderStyle.None;
                formModalBackground.Opacity = 0.50d;
                //formModalBackground.BackColor = Color.Black;
                formModalBackground.Size = this.Size;
                formModalBackground.Location = this.Location;
                formModalBackground.ShowInTaskbar = false;
                formModalBackground.Show();
                modalFirstWindow.Owner = formModalBackground;

                //parentX = this.Location.X;
                //parentY = this.Location.Y;

                modalFirstWindow.ShowDialog();
                formModalBackground.Dispose();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 spt963form = new Form3();
            spt963form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void SpravkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создание и отображение модальной формы Form4
            using (Form4 spravkaForm = new Form4())
            {
                spravkaForm.StartPosition = FormStartPosition.CenterParent;
                spravkaForm.ShowDialog();
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {
            // Создаем диалоговое окно для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Xdb Files (*.xdb)|*.xdb";

            // Если пользователь выбрал файл и нажал "OK"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                string filePath = openFileDialog.FileName;

                // Отладочное сообщение для вывода пути к файлу
                MessageBox.Show($"Выбранный файл: {openFileDialog.FileName}");

                // Обрабатываем выбранный файл
                ProcessFile(filePath);
            }
        }

        private void ProcessFile(string filePath)
        {
            try
            {
                // Определение значения TargetDevice из файла
                string targetDevice;

                // Используем конструкцию using для автоматического закрытия потока файла
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(TagList));
                    TagList xmlModel = (TagList)serializer.Deserialize(fileStream);
                    targetDevice = xmlModel.TargetDevice;

                    // Создание нужной формы и передача объекта xmlModel
                    Form targetForm;
                    if (targetDevice == "TSPT962")
                    {
                        targetForm = new Form2();
                        targetForm.Show();
                        ((Form2)targetForm).LoadXdb(xmlModel);
                        this.Hide();
                    }
                    else if (targetDevice == "TSPT963")
                    {
                        targetForm = new Form3();
                        targetForm.Show();
                        // Добавьте здесь код для передачи xmlModel в Form3, если необходимо
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка при обработке файла:", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обработке файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}