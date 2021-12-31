using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.FreeGlut;
using Tao.OpenGl;
using System.Windows.Forms;

namespace Tao_OpenGL_Initialization_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }
        private void button2_Click(object sender, EventArgs e) => Application.Exit();
        
        static private void rect(double X0, double Y0, double W, double H)
        {
            //рисуем границы
            Gl.glColor3f(0, 255, 255);
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2d(X0, Y0);
            Gl.glVertex2d(X0, Y0 + H);
            Gl.glVertex2d(X0 + W, Y0 + H);
            Gl.glVertex2d(X0 + W, Y0);
            Gl.glEnd();
        }
        static private void Ts(double X0, double Y0, double W, double H)
        {
            //буква Ц
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2d(X0, Y0);
            Gl.glVertex2d(X0, Y0 + H);
            Gl.glVertex2d(X0 + W / 7, Y0 + H);
            Gl.glVertex2d(X0 + W / 7, Y0 + H / 7);
            Gl.glVertex2d(X0 + 5 * W / 7, Y0 + H / 7);
            Gl.glVertex2d(X0 + 5 * W / 7, Y0 + H);
            Gl.glVertex2d(X0 + 6 * W / 7, Y0 + H);
            Gl.glVertex2d(X0 + 6 * W / 7, Y0 + H / 7);
            Gl.glVertex2d(X0 + 7 * W / 7, Y0 + H / 7);
            Gl.glVertex2d(X0 + 7 * W / 7, Y0 - H / 7);
            Gl.glVertex2d(X0 + 6 * W / 7, Y0 - H / 7);
            Gl.glVertex2d(X0 + 6 * W / 7, Y0);
            Gl.glEnd();
        }

        static private void You(double X0, double Y0, double W, double H)
        {
            //буква Ю
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2d(X0, Y0);
            Gl.glVertex2d(X0, Y0 + H);
            Gl.glVertex2d(X0 + W / 7, Y0 + H);
            Gl.glVertex2d(X0 + W / 7, Y0 + 4 * H / 7);
            Gl.glVertex2d(X0 + 3 * W / 7, Y0 + 4 * H / 7);
            Gl.glVertex2d(X0 + 3 * W / 7, Y0 + H);
            Gl.glVertex2d(X0 + 7 * W / 7, Y0 + H);
            Gl.glVertex2d(X0 + 7 * W / 7, Y0);
            Gl.glVertex2d(X0 + 3 * W / 7, Y0);
            Gl.glVertex2d(X0 + 3 * W / 7, Y0 + 3 * H / 7);
            Gl.glVertex2d(X0 + W / 7, Y0 + 3 * H / 7);
            Gl.glVertex2d(X0 + W / 7, Y0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2d(X0 + 4 * W / 7, Y0 + H / 7);
            Gl.glVertex2d(X0 + 4 * W / 7, Y0 + 6 * H / 7);
            Gl.glVertex2d(X0 + 6 * W / 7, Y0 + 6 * H / 7);
            Gl.glVertex2d(X0 + 6 * W / 7, Y0 + H / 7);
            Gl.glEnd();
        }
        static private void A(double X0, double Y0, double W, double H)
        {
            //буква A
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2d(X0, Y0);
            Gl.glVertex2d(X0 + 3 * W / 7, Y0 + H);
            Gl.glVertex2d(X0 + 4 * W / 7, Y0 + H);
            Gl.glVertex2d(X0 + 7 * W / 7, Y0);
            Gl.glVertex2d(X0 + 6 * W / 7, Y0);
            Gl.glVertex2d(X0 + 5 * W / 7, Y0 + 2 * H / 7);
            Gl.glVertex2d(X0 + 2 * W / 7, Y0 + 2 * H / 7);
            Gl.glVertex2d(X0 + W / 7, Y0);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2d(X0 + 2.3 * W / 7, Y0 + 3 * H / 7);
            Gl.glVertex2d(X0 + W / 2, Y0 + 6 * H / 7);
            Gl.glVertex2d(X0 + 4.7 * W / 7, Y0 + 3 * H / 7);
            Gl.glEnd();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();// очищаем текущую матрицу
            Gl.glColor3f(255, 0, 0); // устанавливаем текущий цвет - красный
            Gl.glTranslated(7, 0, 0);
            const double W = 5, H = 10, d = 2, X0 = 1, Y0 = 5;

            //функции букв
            Ts(X0, Y0, W, H);
            You(X0 + W + d, Y0, W, H);
            A(X0 + 2 * W + 2 * d, Y0, W, H);

            //проверка границ
            /* rect(X0, Y0, W, H);
             rect(X0 + W + d, Y0, W, H);
             rect(X0 + 2 * W + 2 * d, Y0, W, H);*/

           /* Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2d(8, 7);
            Gl.glVertex2d(15, 27);
            Gl.glVertex2d(17, 27);
            Gl.glVertex2d(23, 7);
            Gl.glVertex2d(21, 7);
            Gl.glVertex2d(19, 14);
            Gl.glVertex2d(12.5, 14);
            Gl.glVertex2d(10, 7);
            // завершаем режим рисования 
            Gl.glEnd();
            // вторая линия 
            Gl.glBegin(Gl.GL_LINE_LOOP);
            Gl.glVertex2d(18.5, 16);
            Gl.glVertex2d(16, 25);
            Gl.glVertex2d(13.2, 16);
            Gl.glEnd();*/
            // завершаем режим рисования 

            // дожидаемся конца визуализации кадра
            Gl.glFlush();
            // посылаем сигнал перерисовки элемента AnT.
            AnT.Invalidate();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_SINGLE);

            // отчитка окна 
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);


            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            if ((float)AnT.Width <= (float)AnT.Height)
                Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Height / (float)AnT.Width, 0.0, 30.0);


            else
                Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Width / (float)AnT.Height, 0.0, 30.0);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            Gl.glLoadIdentity();
        }
    }
}
