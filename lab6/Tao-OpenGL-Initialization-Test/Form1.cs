using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Tao_OpenGL_Initialization_Test
{
    public partial class Form1 : Form
    {
        const int Xmin = -15, Xmax = 15, Ymin = -15, Ymax = 15, z = -10;
        const double step = 0.005;

        int OA = 6, AB = 4, AM = 1;
        double angle = 0.0;

        bool up = true, trajectory = false;
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }
        private void xtrackBar_Scroll(object sender, EventArgs e) => Timer.Interval = xtrackBar.Value;

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(115, (float)AnT.Width / (float)AnT.Height, 0.2, 100);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Timer.Start();
            checkBox.Checked = false;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();

            if (trajectory)
                DrawTrajectory();

            Angle();    
        }
        void Angle()
        {
            if(OA <= AB)
            {
                if (angle + step <= Math.PI * 2)
                    angle += step;
                else angle = 0.0;
            }
            else
            {
                double m_angle = Math.Asin((float)AB/OA);
                if (up)
                {
                    angle += step;
                    if (angle + step - m_angle > 0)
                        up = false;     
                }
                else
                {
                    angle -= step;
                    if (-angle + step - m_angle > 0)
                        up = true;
                }   
            }
        }
        private void OA_numeric_ValueChanged(object sender, EventArgs e)
        {
            OA = (int)OA_numeric.Value;
            angle = 0.0;
        }

        private void AB_numeric_ValueChanged(object sender, EventArgs e)
        {
           AB = (int)AB_numeric.Value;
           angle = 0.0;
        }

        private void AM_numeric_ValueChanged(object sender, EventArgs e)
        {
            AM = (int)AM_numeric.Value;
            angle = 0.0;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
                trajectory = true;
            else
                trajectory = false;
        }

        void Draw_lines()
        {
            double ay = OA * Math.Sin(angle);
            double ax = OA * Math.Cos(angle);
            double ky = ay / AB;
            //OA
            Draw_point(0, 0); //O
            PrintText2D(-0.8f, -0.8f, "O");

            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2d(0, 0);
            Gl.glVertex2d(ax, ay);
            Gl.glEnd();
            
            Draw_point(ax, ay);//A
            PrintText2D((float)(ax), (float)(ay + 0.2f), "A");
            //AB
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2d(ax, ay);
            if (OA == AB)
            {
                Gl.glVertex2d((OA + AB) * Math.Cos(angle), 0);
                Gl.glEnd();

                Draw_point((OA + AB) * Math.Cos(angle), 0);//B
                PrintText2D((float)((OA + AB) * Math.Cos(angle)), 0.2f, "B");

                Draw_point((OA + AM) * Math.Cos(angle), (AB - AM) * Math.Sin(angle));//M
                PrintText2D((float)((OA + AM) * Math.Cos(angle)), (float)((AB - AM) * Math.Sin(angle)) + 0.2f, "M");
            }

            else if (OA < AB)
            {
                Gl.glVertex2d(ax + Math.Sqrt(AB * AB - ay * ay), 0);
                Gl.glEnd();

                Draw_point(ax + Math.Sqrt(AB * AB - ay * ay), 0);//B
                PrintText2D((float)(ax + Math.Sqrt(AB * AB - ay * ay)), 0.2f, "B");
                
                Draw_point(ax + Math.Sqrt(AM*AM - (AM * ky) * (AM * ky)), (AB - AM) * ky);//M
                PrintText2D((float)(ax + Math.Sqrt(AM * AM - (AM * ky) * (AM * ky))), (float)((AB - AM) * ky) + 0.2f, "M");
            }
            
            else if(OA > AB)
            {
                if (up)
                {
                    Gl.glVertex2d(ax + Math.Sqrt(AB * AB - ay * ay), 0);
                    Gl.glEnd();

                    Draw_point(ax + Math.Sqrt(AB * AB - ay * ay), 0);//B
                    PrintText2D((float)(ax + Math.Sqrt(AB * AB - ay * ay)), 0.2f, "B");

                    Draw_point(ax + Math.Sqrt(AM * AM - (AM * ky) * (AM * ky)), (AB - AM) * ky);//M
                    PrintText2D((float)(ax + Math.Sqrt(AM * AM - (AM * ky) * (AM * ky))), (float)((AB - AM) * ky) + 0.2f, "M");
                }
                else
                {
                    Gl.glVertex2d(ax - Math.Sqrt(AB * AB - ay * ay), 0);
                    Gl.glEnd();

                    Draw_point(ax - Math.Sqrt(AB * AB - ay * ay), 0);//B
                    PrintText2D((float)(ax - Math.Sqrt(AB * AB - ay * ay)), 0.2f, "B");

                    Draw_point(ax - Math.Sqrt(AM * AM - (AM * ky) * (AM * ky)), (AB - AM) * ky);//M
                    PrintText2D((float)(ax - Math.Sqrt(AM * AM - (AM * ky) * (AM * ky))), (float)((AB - AM) * ky) + 0.2f, "M");
                }
            }
        }
        private void Draw()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(0, 0, z);
            DrawGrid();
            DrawAxes();
            Draw_lines();

            AnT.Invalidate();
        }

        private void DrawGrid()
        {
            Gl.glPointSize(2);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glColor3f(0, 0, 0);

            for (int ax = Xmin; ax < Xmax + 1; ax++)
                for (int bx = Ymin; bx < Ymax + 1; bx++)
                    Gl.glVertex2d(ax, bx);
            Gl.glEnd();
        }

        void Draw_point(double x, double y)
        {
            Gl.glPointSize(5);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glColor3f(1, 0, 0);
            Gl.glVertex2d(x, y);
            Gl.glEnd();
            Gl.glColor3f(0, 0, 0);
        }
        private void DrawTrajectory()
        {
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3f(255, 0, 0);
  
            if (OA == AB)
                for(double i = 0.0; i < 360.0; i += step)
                    Gl.glVertex2d((OA + AM) * Math.Cos(i), (AB - AM) * Math.Sin(i));

            else if (OA < AB)
                for (double i = 0.0; i < 360.0; i += step)
                    Gl.glVertex2d(OA * Math.Cos(i) + Math.Sqrt(AM * AM - (AM * OA * Math.Sin(i) / AB) * (AM * OA * Math.Sin(i) / AB)),
                        (AB - AM) * OA * Math.Sin(i) / AB);

            else if(OA > AB)
            {
                double m_angle = Math.Asin((float)AB / OA);
                bool uppy = true;
                double i = 0.0, j = 0;
                while(j != 3)
                {

                    if (uppy)
                    {
                        Gl.glVertex2d(OA * Math.Cos(i) + Math.Sqrt(AM * AM - (AM * OA * Math.Sin(i) / AB) * (AM * OA * Math.Sin(i) / AB)), 
                            (AB - AM) * OA * Math.Sin(i) / AB);
                        i += step;
                        if (i + step > m_angle)
                        {
                            uppy = false;
                            j++;
                        }
                            
                    }
                    else
                    {
                        Gl.glVertex2d(OA * Math.Cos(i) - Math.Sqrt(AM * AM - (AM * OA * Math.Sin(i) / AB) * (AM * OA * Math.Sin(i) / AB)),
                            (AB - AM) * OA * Math.Sin(i) / AB);
                        i -= step;
                        if (i - step < -m_angle)
                        {
                            uppy = true;
                            j++;
                        }
                            
                    }  

                }

            }
            Gl.glEnd();
            Gl.glColor3f(0, 0, 0);
        }
        private void DrawAxes()
        { 
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2d(0, Ymin);
            Gl.glVertex2d(0, Ymax);
            Gl.glEnd();
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2d(Xmin, 0);
            Gl.glVertex2d(Xmax, 0);

            if (Ymax > 0)
            {
                Gl.glVertex2d(0, Ymax);
                Gl.glVertex2d(0.2, Ymax - 0.85);
                Gl.glVertex2d(0, Ymax);
                Gl.glVertex2d(-0.2, Ymax - 0.85);
            }
            if (Xmax > 0)
            {
                Gl.glVertex2d(Xmax, 0);
                Gl.glVertex2d(Xmax - 0.85, 0.2);
                Gl.glVertex2d(Xmax, 0);
                Gl.glVertex2d(Xmax - 0.85, -0.2);
            }
            Gl.glEnd();

            PrintText2D(Xmax, -1f, "x");
            PrintText2D(0.5f, Ymax - 0.5f, "y");
        }

        private void PrintText2D(float x, float y, string text)
        {
            Gl.glColor3f(0, 0, 255);

            Gl.glRasterPos2f(x, y);
            foreach (char char_for_draw in text)
                Glut.glutBitmapCharacter(Glut.GLUT_BITMAP_9_BY_15, char_for_draw);

            Gl.glColor3f(0, 0, 0);
        }
    }
}