using System;
using Tao.FreeGlut;
using Tao.OpenGl;
using System.Windows.Forms;

namespace Tao_OpenGL_Initialization_Test
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0, z = -5;
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            x = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            y = (int)numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            z = (int)numericUpDown3.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0.5f);//выбор цвета(r,g,b)

            Gl.glPushMatrix();
           
           

            // рисуем сферу с помощью библиотеки FreeGLUT 
            Gl.glTranslated(x, y, z);
            Gl.glRotated(90, 0, 1, 0);//первый параметр отвечает на сколько градусов будем поворачивать, остальные по какой оси(y,x,z)
            Glut.glutWireSphere(2, 16, 16);

            Gl.glFlush();
            AnT.Invalidate();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // отчитка окна 
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);


            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(115, (float)AnT.Width / (float)AnT.Height, 0.1, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);

        }
    }
}
