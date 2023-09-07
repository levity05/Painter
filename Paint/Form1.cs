// Импортируем необходимые библиотеки
//подключает базовые классы и пространства имен .NET
using System;
//подключает пространство имен для работы с элементами управления и окнами приложения Windows Forms
using System.Windows.Forms;
// Создаем пространство имен для нашего приложения
namespace Paint
{
    // Определяем класс главной формы
    public partial class Form1 : Form
    {
        // Конструктор формы
        public Form1()
        {   //проводим иницилизацию
            InitializeComponent();
            // Устанавливаем размеры изображения
            SetSize();
        }
        // Вспомогательный класс для хранения точек
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;
            // Конструктор класса
            public ArrayPoints(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];

            }
            // Конструктор класса
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            // Конструктор класса
            public void ResetPoints()
            {
                index = 0;
            }

            // Получаем количество точек
            public int GetCountPoints()
            {
                return index;
            }
            // Получаем массив точек
            public Point[] GetPoints()
            {
                return points;
            }
        }
        // Флаг для отслеживания нажатия мыши
        private bool isMouse = false;
        // Создаем объект класса ArrayPoints
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        // Создаем объект Bitmap
        Bitmap map = new Bitmap(1080, 1080);
        Graphics graphics;
        // Создаем объект Pen
        Pen pen = new Pen(Color.Black, 3f);
        // Устанавливаем размеры изображения
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        // Обработчик нажатия на кнопку "Сохранить"
        private void button1_Click(object sender, EventArgs e)
        {
            //фильтр для сохранения в формате png
            saveFileDialog1.Filter = "PNG(*.PNG)|*.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        // Обработчик события "Нажатие на кнопку мыши"
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Устанавливаем флаг в true
            isMouse = true;
        }
        // Обработчик события "Отпускание кнопки мыши"
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // Устанавливаем флаг в false
            isMouse = false;
            // Сбрасываем точки
            arrayPoints.ResetPoints();
        }
        // Обработчик события "Движение мыши"
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Если кнопка мыши не нажата, то выходим из метода
            if (!isMouse) { return; }
            // Устанавливаем координаты точки
            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.GetCountPoints() >= 2)
            {
                // Рисуем линии между точками
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                // Устанавливаем изображение в PictureBox
                pictureBox1.Image = map;
                // Устанавливаем координаты точки
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }
        // Обработчик нажатия на кнопку выбора цвета
        private void button3_Click(object sender, EventArgs e)
        {
            // Устанавливаем цвет пера из цвета кнопки
            pen.Color = ((Button)sender).BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Обработчик нажатия на кнопку выбора цвета
        private void button10_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Устанавливаем цвет пера из диалогового окна выбора цвета
                pen.Color = colorDialog1.Color;
                // Устанавливаем цвет кнопки из диалогового окна выбора цвета
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }
        // Обработчик нажатия на кнопку "Очистить"
        private void button2_Click(object sender, EventArgs e)
        {
            // Очищаем изображение
            graphics.Clear(pictureBox1.BackColor);
            // Устанавливаем изображение в PictureBox
            pictureBox1.Image = map;
        }
        // Обработчик изменения значения trackbar'а
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // Устанавливаем толщину пера из значения trackbar'а
            pen.Width = trackBar1.Value;
        }
        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        // Обработчик нажатия на кнопку "Добавить фото"
        private void AddPhoto_Click(object sender, EventArgs e)
        {
            // Вызываем метод LoadImage()
            LoadImage();
        }
        // Метод для загрузки изображения
        private void LoadImage()
        {
            // фильт для загрузки изображения
            openFileDialog1.Filter = "Image Files(*.PNG;*.JPG;*.JPEG)|*.PNG;*.JPG;*.JPEG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Загружаем изображение в PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                // Создаем объект Bitmap из изображения
                map = new Bitmap(pictureBox1.Image);
                // Создаем объект Graphics из Bitmap
                graphics = Graphics.FromImage(map);
            }
        }
        // Обработчик нажатия на кнопку "Ластик"
        private void eraser_Click(object sender, EventArgs e)
        {
            // Устанавливаем цвет пера такой же, как и цвет фона PictureBox
            pen.Color = pictureBox1.BackColor;
        }
    }
}