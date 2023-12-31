// ����������� ����������� ����������
//���������� ������� ������ � ������������ ���� .NET
using System;
//���������� ������������ ���� ��� ������ � ���������� ���������� � ������ ���������� Windows Forms
using System.Windows.Forms;
// ������� ������������ ���� ��� ������ ����������
namespace Paint
{
    // ���������� ����� ������� �����
    public partial class Form1 : Form
    {
        // ����������� �����
        public Form1()
        {   //�������� ������������
            InitializeComponent();
            // ������������� ������� �����������
            SetSize();
        }
        // ��������������� ����� ��� �������� �����
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;
            // ����������� ������
            public ArrayPoints(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];

            }
            // ����������� ������
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            // ����������� ������
            public void ResetPoints()
            {
                index = 0;
            }

            // �������� ���������� �����
            public int GetCountPoints()
            {
                return index;
            }
            // �������� ������ �����
            public Point[] GetPoints()
            {
                return points;
            }
        }
        // ���� ��� ������������ ������� ����
        private bool isMouse = false;
        // ������� ������ ������ ArrayPoints
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        // ������� ������ Bitmap
        Bitmap map = new Bitmap(1080, 1080);
        Graphics graphics;
        // ������� ������ Pen
        Pen pen = new Pen(Color.Black, 3f);
        // ������������� ������� �����������
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        // ���������� ������� �� ������ "���������"
        private void button1_Click(object sender, EventArgs e)
        {
            //������ ��� ���������� � ������� png
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
        // ���������� ������� "������� �� ������ ����"
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // ������������� ���� � true
            isMouse = true;
        }
        // ���������� ������� "���������� ������ ����"
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // ������������� ���� � false
            isMouse = false;
            // ���������� �����
            arrayPoints.ResetPoints();
        }
        // ���������� ������� "�������� ����"
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // ���� ������ ���� �� ������, �� ������� �� ������
            if (!isMouse) { return; }
            // ������������� ���������� �����
            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.GetCountPoints() >= 2)
            {
                // ������ ����� ����� �������
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                // ������������� ����������� � PictureBox
                pictureBox1.Image = map;
                // ������������� ���������� �����
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }
        // ���������� ������� �� ������ ������ �����
        private void button3_Click(object sender, EventArgs e)
        {
            // ������������� ���� ���� �� ����� ������
            pen.Color = ((Button)sender).BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ���������� ������� �� ������ ������ �����
        private void button10_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // ������������� ���� ���� �� ����������� ���� ������ �����
                pen.Color = colorDialog1.Color;
                // ������������� ���� ������ �� ����������� ���� ������ �����
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }
        // ���������� ������� �� ������ "��������"
        private void button2_Click(object sender, EventArgs e)
        {
            // ������� �����������
            graphics.Clear(pictureBox1.BackColor);
            // ������������� ����������� � PictureBox
            pictureBox1.Image = map;
        }
        // ���������� ��������� �������� trackbar'�
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // ������������� ������� ���� �� �������� trackbar'�
            pen.Width = trackBar1.Value;
        }
        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        // ���������� ������� �� ������ "�������� ����"
        private void AddPhoto_Click(object sender, EventArgs e)
        {
            // �������� ����� LoadImage()
            LoadImage();
        }
        // ����� ��� �������� �����������
        private void LoadImage()
        {
            // ����� ��� �������� �����������
            openFileDialog1.Filter = "Image Files(*.PNG;*.JPG;*.JPEG)|*.PNG;*.JPG;*.JPEG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // ��������� ����������� � PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                // ������� ������ Bitmap �� �����������
                map = new Bitmap(pictureBox1.Image);
                // ������� ������ Graphics �� Bitmap
                graphics = Graphics.FromImage(map);
            }
        }
        // ���������� ������� �� ������ "������"
        private void eraser_Click(object sender, EventArgs e)
        {
            // ������������� ���� ���� ����� ��, ��� � ���� ���� PictureBox
            pen.Color = pictureBox1.BackColor;
        }
    }
}