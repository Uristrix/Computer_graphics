using System;
using Tao.FreeGlut;
using Tao.OpenGl;
using System.Windows.Forms;

struct color
{
   public int red, green, blue;
   public void reset() => red = green = blue = 0;
};
namespace Tao_OpenGL_Initialization_Test
{
    public partial class Form1 : Form
    {
        int graf_index; //функция для отрисовки
        int item_index;
        private color[] color_item = new color[3];
        private int x, y, z = -10;
        int Xmin = -23, Xmax = 23;
        int Ymin = -15, Ymax = 15;
        double ScreenW, ScreenH;// отношения сторон окна визуализации для корректного перевода координат мыши в координаты,принятые в программе
        
        private float devX;
        private float devY; 

        private int elements_count = 0; // количество элементов в массиве
        private double[,] GrapValuesArray;// массив, который будет хранить значения x,y точек графика
       
        private bool not_calculate = true;// флаг, означающий, что массив с значениями координат графика пока еще не заполнен
        private int pointPosition = 0; // номер ячейки массива, из которой будут взяты координаты для красной точки для визуализации текущего кадра
     
        float Mcoord_X = 0, Mcoord_Y = 0;// текущение координаты курсора мыши
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height); 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            /*if ((float)AnT.Width <= (float)AnT.Height)
            {
                ScreenW = 30.0;
                ScreenH = 30.0 * (float)AnT.Height / (float)AnT.Width;
            }
            else
            {
                ScreenW = 30.0 * (float)AnT.Width / (float)AnT.Height;
                ScreenH = 30.0;
            }
            devX = (float)ScreenW / (float)AnT.Width;
            devY = (float)ScreenH / (float)AnT.Height;*/
            //Xmax = 10; Xmin = -5; Ymin = -2; Ymax = 4;
            //ScreenW = Xmax - Xmin;
            //ScreenH = Ymax - Ymin;
            Glu.gluPerspective(115, (float)AnT.Width / (float)AnT.Height, 0.2, 100);
            //Glu.gluOrtho2D(0.0, ScreenW, 0.0, ScreenH);
            Gl.glMatrixMode(Gl.GL_MODELVIEW); 
            PointInGrap.Start();
        }

        private void PointInGrap_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("sadfsdfsdfsfsf");
            if (pointPosition == elements_count - 1)
                pointPosition = 0; // переходим к начальному элементу
            if(func.SelectedIndex >= 0)
                Draw(); // функция визуализации
            pointPosition++;// переход к следующему элементу массива       
        }
        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {
            Mcoord_X = (e.X - (float)AnT.Width / 2) / ((float)AnT.Width / (Xmax * 2 + 3)) - x;
            Mcoord_Y = -(e.Y - (float)AnT.Height / 2) / ((float)AnT.Height / (Ymax * 2 + 2)) - y;
        }
        private void PrintText2D(float x, float y, string text) // печать по заданным координатам
        {
            Gl.glRasterPos2f(x, y); 
            foreach (char char_for_draw in text)
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_9_BY_15, char_for_draw);
        }
        

        private void numericX_ValueChanged(object sender, EventArgs e)
        {
            x = (int)numericX.Value;
            not_calculate = true;
            pointPosition = 0;
        }

        private void numericY_ValueChanged(object sender, EventArgs e)
        {
            y = (int)numericY.Value;
            not_calculate = true;
            pointPosition = 0;
        }

        private void numericZ_ValueChanged(object sender, EventArgs e)
        {
            z = (int)numericZ.Value;
            not_calculate = true;
            pointPosition = 0;
        }
        private void AnT_MouseHover(object sender, EventArgs e)
        {
            not_calculate = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            graf_index = func.SelectedIndex;               
            pointPosition = 0;
            not_calculate = true;
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_index = element.SelectedIndex;
            not_calculate = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (color.SelectedIndex)
            {
                case 0:
                    color_item[item_index].reset();
                    color_item[item_index].red = 255;
                    break;
                case 1:
                    color_item[item_index].reset();
                    color_item[item_index].green = 255;
                    break;
                case 2:
                    color_item[item_index].reset();
                    color_item[item_index].blue = 255;
                    break;
                case 3:
                    color_item[item_index].reset();
                    break;
                default:
                    color_item[item_index].reset();
                    break;
            }
        }
        private void SetValue()
        {
            x_min.Text = Xmin.ToString();
            x_max.Text = Xmax.ToString();
            y_min.Text = Ymin.ToString();
            y_max.Text = Ymax.ToString();
        }
        private void functionCalculation()
        {
            int x_count = (int)(Math.Abs(z * 4.72f));
            Xmin = -(x_count / 2) - x;
            Xmax = (x_count / 2) - x;

            int y_count = (int)(Math.Abs(z * 3.15f));
            Ymin = -(y_count / 2) - y;
            Ymax = (y_count / 2) - y;
            //Xmax = 10; Xmin = - 5; Ymin = -2; Ymax = 4;
            elements_count = (Xmax + Math.Abs(Xmin)) * 10;
            GrapValuesArray = new double[elements_count, 2];
            for (double x = Xmin, num = 0; x < Xmax; x += 0.1f, num++)
            {
                GrapValuesArray[(int)num, 0] = x;

                if (graf_index == 0)
                    GrapValuesArray[(int)num, 1] = (float)Math.Sin(x)*3 + 1;

                else if (graf_index == 1)
                    GrapValuesArray[(int)num, 1] = x * x / 15 - 5;
            }
            not_calculate = false;// изменяем флаг, сигнализировавший о том, что координаты графика не вычислены
        }
        private void DrawPoint()
        {
            Gl.glPointSize(5);// устанавливаем размер точек, равный 5 пикселям
            Gl.glBegin(Gl.GL_POINTS);// активируем режим вывода точек (GL_POINTS)
            Gl.glColor3f(color_item[2].red, color_item[2].green, color_item[2].blue);
            Gl.glVertex2d(GrapValuesArray[pointPosition, 0], GrapValuesArray[pointPosition, 1]);// выводим точку, используя ту ячейку массива, до которой мы дошли
            Gl.glEnd();
        }
        private void DrawGrid()
        {
            Gl.glPointSize(2);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glColor3f(0, 0, 0);

            for (int ax = Xmin; ax < Xmax + 1; ax++)// с помощью прохода вдумя циклами, создаем сетку из точек
                for (int bx = Ymin; bx < Ymax + 1; bx++)
                    Gl.glVertex2d(ax, bx);// вывод точки
            Gl.glEnd();
        }
        private void DrawDiagram()
        {
            // проверка флага, сигнализирующего о том, что координаты графика вычислены
            if (not_calculate)
                functionCalculation();
            
            //отрисовка графика
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3f(color_item[0].red, color_item[0].green, color_item[0].blue);
           
            for (int ax = 0; ax < elements_count; ax++)
                Gl.glVertex2d(GrapValuesArray[ax, 0], GrapValuesArray[ax, 1]);
            
            Gl.glEnd();
        }

        private void DrawAxes()
        {
            // далее мы рисуем координатные оси и стрелки на их концах
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3f(color_item[1].red, color_item[1].green, color_item[1].blue);
            Gl.glVertex2d(0, Ymin);
            Gl.glVertex2d(0, Ymax);
            Gl.glEnd();
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2d(Xmin, 0);
            Gl.glVertex2d(Xmax, 0);

            // вертикальная стрелка
            if (Ymax > 0)
            {
                Gl.glVertex2d(0, Ymax);
                Gl.glVertex2d(0.2, Ymax - 0.85);
                Gl.glVertex2d(0, Ymax);
                Gl.glVertex2d(-0.2, Ymax - 0.85);
            }

            // горизонтальная cтрелка
            if (Xmax > 0)
            {
                Gl.glVertex2d(Xmax, 0);
                Gl.glVertex2d(Xmax - 0.85, 0.2);
                Gl.glVertex2d(Xmax, 0);
                Gl.glVertex2d(Xmax - 0.85, -0.2);
            }

            // завершаем режим рисования
            Gl.glEnd();

            // выводим подписи осей "x" и "y"
            PrintText2D(Xmax, -1f, "x");
            PrintText2D(0.5f, Ymax - 0.5f, "y");
        }
        private void DrawMouseinfo()
        {
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3f(color_item[2].red, color_item[2].green, color_item[2].blue);
            Gl.glVertex2d(x-x, Mcoord_Y);
            Gl.glVertex2d(Mcoord_X, Mcoord_Y);
            Gl.glVertex2d(Mcoord_X, y - y);
            Gl.glVertex2d(Mcoord_X, Mcoord_Y);
            Gl.glEnd();

            // выводим текст со значением координат возле курсора
            PrintText2D(
                Mcoord_X + 0.2f,
                Mcoord_Y + 0.4f,
                "[ x: " + (Mcoord_X).ToString() + " ; y: " + (Mcoord_Y).ToString() + "]");
        }

        private void Draw()
        {
            
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);
            Gl.glPushMatrix();
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Gl.glTranslated(x, y, z); // выполняем перемещение в пространстве по осям X и Y и Z
            DrawGrid();      // вызываем функцию рисования сетки
            DrawAxes();     // вызываем функцию рисования осей
            DrawDiagram(); // вызываем функцию рисования графика
            DrawPoint();  // вызываем функцию рисования точки
            DrawMouseinfo(); // вызываем функцию рисования точки
            SetValue();  // вызываем функцию изменеия мин. и макс. значений
            Gl.glPopMatrix();// возвращаем матрицу из стека
            Gl.glFlush();    
            AnT.Invalidate();
        }
    }
}
