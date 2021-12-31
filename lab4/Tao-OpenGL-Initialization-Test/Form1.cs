using System;
using Tao.FreeGlut;
using Tao.OpenGl;
using System.Windows.Forms;

namespace Tao_OpenGL_Initialization_Test
{

    public partial class Form1 : Form
    {
        double a = 0, b = 0, c = -5, d = 90, zoom = 1; // выбранные оси
        int os_x = 1, os_y = 0, os_z = 0;
        // режим сеточной визуализации
        bool Wire = false;

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
            // установка порта вывода
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            // установка перспективы
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            // начальная настройка параметров openGL (тест глубины, освещение и первый источник света)
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            //Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            // установка первых элементов в списках combobox
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 5;
            // активация таймера, вызывающего функцию для визуализации
            RenderTimer.Start();

        }

        private void RenderTimer_Tick(object sender, EventArgs e) => Draw();

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            a = (double)trackBar1.Value / 1000.0;
            label4.Text = a.ToString();
        }
        
        private void trackBar2_Scroll(object sender, EventArgs e)
        { 
            b = (double)trackBar2.Value / 1000.0;
            label5.Text = b.ToString();
        }


        private void trackBar3_Scroll(object sender, EventArgs e)
        {    
            c = (double)trackBar3.Value / 1000.0;
            label6.Text = c.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            d = (double)trackBar4.Value;
            label7.Text = d.ToString();
        }
        
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            zoom = (double)trackBar5.Value / 1000.0;
            label8.Text = zoom.ToString();
        }
        
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
                Wire = true;

            else 
                Wire = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {

                case 0:
                    {
                        os_x = 1; os_y = 0; os_z = 0; break;
                    }
                       
                case 1:
                    {
                       os_x = 0; os_y = 1; os_z = 0; break;
                    }
                        
                case 2:
                    {
                        os_x = 0; os_y = 0; os_z = 1; break;    
                    }
                        
            }
        }

        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glLoadIdentity();
            Gl.glPushMatrix();
            Gl.glTranslated(a, b, c);
            Gl.glRotated(d, os_x, os_y, os_z);
            Gl.glScaled(zoom, zoom, zoom);
            Gl.glColor3f(0.8f, 0.8f, 0.8f);
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        if (Wire)
                            Glut.glutWireSphere(2, 32, 32);
                        else
                            Glut.glutSolidSphere(2, 32, 32);
                        break;
                    }
                case 1:
                    {
                        if (Wire)
                            Glut.glutWireCylinder(1, 2, 32, 32);
                        else
                            Glut.glutSolidCylinder(1, 2, 32, 32);
                        break;
                    }
                case 2:
                    {
                        if (Wire)
                            Glut.glutWireCube(2);
                        else
                            Glut.glutSolidCube(2);
                        break;
                    }
                case 3:
                    {
                        if (Wire)
                            Glut.glutWireCone(2, 3, 32, 32);
                        else
                            Glut.glutSolidCone(2, 3, 32, 32);
                        break;
                    }
                case 4:
                    {
                        if (Wire)
                            Glut.glutWireTorus(0.2, 2.2, 32, 32);
                        else
                            Glut.glutSolidTorus(0.2, 2.2, 32, 32);
                        break;
                    }
                case 5:
                    if (Wire)
                    {
                        //3 шара
                        Gl.glColor3f(0.8f, 0.8f, 0.8f);
                        Glut.glutWireSphere(3, 32, 32);
                        Gl.glTranslated(0, 0, -5);
                        Glut.glutWireSphere(2, 32, 32);
                        Gl.glTranslated(0, 0, -3);
                        Glut.glutWireSphere(1, 32, 32);
                        //ведро
                        Gl.glColor3f(0.4f, 0.4f, 0.4f);
                        Gl.glTranslated(0, 0, -2.3f);
                        Glut.glutWireCylinder(0.8d, 1.7d, 32, 32);
                        Gl.glTranslated(0, 0.9f, 2.3f);
                        Gl.glRotated(-90, 1, 0, 0);
                        //морковка
                        Gl.glColor3f(1, 0, 0);
                        Glut.glutWireCone(0.2d, 1, 16, 16);
                        Gl.glTranslated(0.5f, 0.3f, -0.3f);
                        //глаза
                        Gl.glColor3f(0, 0, 0);
                        Glut.glutWireSphere(0.2f, 16, 16);
                        Gl.glTranslated(-1, 0, 0);
                        Glut.glutWireSphere(0.2f, 16, 16);

                        Gl.glTranslated(0.5f, -0.3f, -0.6f);
                        Gl.glRotated(90, 1, 0, 0);
                        //руки
                        Gl.glColor3f(0.6f, 0.3f, 0.17f);
                        Gl.glTranslated(2f, 0, 3);
                        Gl.glRotated(120, 0, 1, 0);
                        Glut.glutWireCylinder(0.1, 4, 16, 16);

                        Gl.glRotated(120, 0, -1, 0);

                        Gl.glTranslated(-4f, 0, 0);
                        Gl.glRotated(120, 0, -1, 0);
                        Glut.glutWireCylinder(0.1, 4, 16, 16);
                        //ноги
                        Gl.glColor3f(0.8f, 0.8f, 0.8f);
                        Gl.glRotated(120, 0, 1, 0);
                        Gl.glTranslated(0.5f, 1.0f, 7.5f);
                        Glut.glutWireSphere(0.5f, 16, 16);
                        Gl.glTranslated(3.0f, 0, 0);
                        Glut.glutWireSphere(0.5f, 16, 16);
                    }
                    else
                    {
                        //3 шара
                        Gl.glColor3f(0.8f, 0.8f, 0.8f);
                        Glut.glutSolidSphere(3, 32, 32);
                        Gl.glTranslated(0, 0, -5);
                        Glut.glutSolidSphere(2, 32, 32);
                        Gl.glTranslated(0, 0, -3);
                        Glut.glutSolidSphere(1, 32, 32);
                        //ведро
                        Gl.glColor3f(0.4f, 0.4f, 0.4f);
                        Gl.glTranslated(0, 0, -2.3f);
                        Glut.glutSolidCylinder(0.8d, 1.7d, 32, 32);
                        Gl.glTranslated(0, 0.9f, 2.3f);
                        Gl.glRotated(-90, 1, 0, 0);
                        //морковка
                        Gl.glColor3f(1, 0, 0);
                        Glut.glutSolidCone(0.2d, 1, 16, 16);
                        Gl.glTranslated(0.5f, 0.3f, -0.3f);
                        //глаза
                        Gl.glColor3f(0, 0, 0);
                        Glut.glutSolidSphere(0.2f, 16, 16);
                        Gl.glTranslated(-1, 0, 0);
                        Glut.glutSolidSphere(0.2f, 16, 16);

                        Gl.glTranslated(0.5f, -0.3f, -0.6f);
                        Gl.glRotated(90, 1, 0, 0);
                        //руки
                        Gl.glColor3f(0.6f, 0.3f, 0.17f);
                        Gl.glTranslated(2f, 0, 3);
                        Gl.glRotated(120, 0, 1, 0);
                        Glut.glutSolidCylinder(0.1, 4, 16, 16);

                        Gl.glRotated(120, 0, -1, 0);

                        Gl.glTranslated(-4f, 0, 0);
                        Gl.glRotated(120, 0, -1, 0);
                        Glut.glutSolidCylinder(0.1, 4, 16, 16);
                        //ноги
                        Gl.glColor3f(0.8f, 0.8f, 0.8f);
                        Gl.glRotated(120, 0, 1, 0);
                        Gl.glTranslated(0.5f, 1.0f, 7.5f);
                        Glut.glutSolidSphere(0.5f, 16, 16);
                        Gl.glTranslated(3.0f, 0, 0);
                        Glut.glutSolidSphere(0.5f, 16, 16);
                    }
                    

                    break;
                case 6:
                    if(Wire)
                    {
                        Gl.glColor3f(0.8f, 0.8f, 0.8f);
                        Glut.glutWireCylinder(1, 7, 16, 16);

                        Gl.glColor3f(0.8f, 0.0f, 0.0f);
                        Gl.glRotated(180, 0, 1, 0);
                        Glut.glutWireCone(1, 3, 16, 16);
                        Gl.glRotated(-180, 0, 1, 0);

                        Gl.glColor3f(0.0f, 0.6f, 0.8f);
                        Gl.glTranslated(0, 0.6f, 1.5f);
                        Glut.glutWireSphere(0.6f, 16, 16);
                        Gl.glTranslated(0, -1.2f, 0f);
                        Glut.glutWireSphere(0.6f, 16, 16);
                        Gl.glTranslated(0.6f, 0.6f, 0f);
                        Glut.glutWireSphere(0.6, 16, 16);
                        Gl.glTranslated(-1.2f, 0f, 0f);
                        Glut.glutWireSphere(0.6f, 16, 16);
                        Gl.glTranslated(0.6f, 0f, 0f);

                        Gl.glColor3f(0.8f, 0.0f, 0.0f);
                        Gl.glTranslated(1, 0f, 2f);
                        Glut.glutWireCylinder(0.5, 4, 8, 8);
                        Gl.glTranslated(-2, 0f, 0f);
                        Glut.glutWireCylinder(0.5, 4, 8, 8);
                        Gl.glTranslated(1, 1f, 0f);
                        Glut.glutWireCylinder(0.5, 4, 8, 8);
                        Gl.glTranslated(0, -2f, 0f);
                        Glut.glutWireCylinder(0.5, 4, 8, 8);

                    }
                    else
                    {
                        Gl.glColor3f(0.8f, 0.8f, 0.8f);
                        Glut.glutSolidCylinder(1, 7, 16, 16);

                        Gl.glColor3f(0.8f, 0.0f, 0.0f);
                        Gl.glRotated(180, 0, 1, 0);
                        Glut.glutSolidCone(1, 3, 16, 16);
                        Gl.glRotated(-180, 0, 1, 0);

                        Gl.glColor3f(0.0f, 0.6f, 0.8f);
                        Gl.glTranslated(0, 0.6f, 1.5f);
                        Glut.glutSolidSphere(0.6f, 16, 16);
                        Gl.glTranslated(0, -1.2f, 0f);
                        Glut.glutSolidSphere(0.6f, 16, 16);
                        Gl.glTranslated(0.6f, 0.6f, 0f);
                        Glut.glutSolidSphere(0.6, 16, 16);
                        Gl.glTranslated(-1.2f, 0f, 0f);
                        Glut.glutSolidSphere(0.6f, 16, 16);
                        Gl.glTranslated(0.6f, 0f, 0f);

                        Gl.glColor3f(0.8f, 0.0f, 0.0f);
                        Gl.glTranslated(1, 0f, 2f);
                        Glut.glutSolidCylinder(0.5, 4, 8, 8);
                        Gl.glTranslated(-2, 0f, 0f);
                        Glut.glutSolidCylinder(0.5, 4, 8, 8);
                        Gl.glTranslated(1, 1f, 0f);
                        Glut.glutSolidCylinder(0.5, 4, 8, 8);
                        Gl.glTranslated(0, -2f, 0f);
                        Glut.glutSolidCylinder(0.5, 4, 8, 8);
                    }
                    break;

            }
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }
    }
}
