using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Tao_OpenGL_Initialization_Test
{
    public partial class Form1 : Form
    {
        const double g = 9.82;

        double h_ = 2, H_ = 5, v0 = 15, m1_ = 5, m2_ = 30, L_ = 11, F_ = 50, angle = 45;
        double vx, vy;
        double C1;
        double t = 0.0, tMax = 0.0;
        double tBallMax = 0, xBall = 0;
        bool go = false, go2 = false;
        double a = -5, b = 0, c = -10, d = 10, zoom = 0.25;
        int os_x = 1, os_y = 0, os_z = 0;

        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }
        private void H_numeric_ValueChanged(object sender, EventArgs e) => H_ = (int)H_numeric.Value;
        private void h__numeric_ValueChanged(object sender, EventArgs e) => h_ = (int) h__numeric.Value;
        private void V0_numeric_ValueChanged(object sender, EventArgs e) => v0 = (int)V0_numeric.Value;
        private void m1_numeric_ValueChanged(object sender, EventArgs e) => m1_ = (int)m1_numeric.Value;

        private void trackBar1_Scroll(object sender, EventArgs e){a = (double)trackBar1.Value / 1000.0;label4.Text = a.ToString();}
        private void trackBar2_Scroll(object sender, EventArgs e){b = (double)trackBar2.Value / 1000.0; h__.Text = b.ToString();}
        private void trackBar3_Scroll(object sender, EventArgs e){c = (double)trackBar3.Value / 1000.0; label5.Text = c.ToString();}
        private void trackBar4_Scroll(object sender, EventArgs e){d = (double)trackBar4.Value;label6.Text = d.ToString();}
        private void trackBar5_Scroll(object sender, EventArgs e){zoom = (double)trackBar5.Value / 1000.0;label7.Text = zoom.ToString();}

        private void m2_numeric_ValueChanged(object sender, EventArgs e) => m2_ = (int)m2_numeric.Value;
        private void L_numeric_ValueChanged(object sender, EventArgs e) => L_ = (int)L_numeric.Value;
        private void F_numeric_ValueChanged(object sender, EventArgs e) => F_ = (int)F_numeric.Value;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: { os_x = 1; os_y = 0; os_z = 0; break; }
                case 1: { os_x = 0; os_y = 1; os_z = 0; break; }
                case 2: { os_x = 0; os_y = 0; os_z = 1; break; }
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            t = 0.0; 
            go = true;
            go2 = false;
            tMax = (v0 * Math.Sin(angle) + Math.Sqrt(v0 * v0 * Math.Sin(angle) * Math.Sin(angle) + 2 * g * H_)) / g;
            v0 = (double)V0_numeric.Value; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            //Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Draw();
            
           /* if (traj) 
                DrawTrajectory();*/


            UpdateValue();
            set_string();

            if (go)
                t += 0.01;

            if (t > tMax)
            {
                vx = vy = 0;
                t = tMax;
                go = false;
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

            Draw_field();

            double x, y;
            if(!go2)
            {
                x = v0 * Math.Cos(angle) * t;
                y = v0 * Math.Sin(angle) * t + H_ - (g * t * t / 2);
                Draw_bogie(0);
                Draw_ball(x, y);
                
                if (x >= L_ && x <= L_ + 5 && y <= h_)
                {
                    go2 = true;
                    v0 = m1_ * vx / (m1_ + m2_);
                    C1 = v0 * (m1_ + m2_);
                    xBall = x - L_;
                    tBallMax = t;
                    tMax = t + C1 / F_;
                }
            }
            else
            {
                double t_truck = t - tBallMax;
                x = -F_ * t_truck * t_truck / 2 + C1 * t_truck;
                y = h_;
                Draw_ball(x + L_ + xBall, y);
                Draw_bogie(x);
            }
            
            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }
        
        void Draw_field()
        {
            Gl.glColor3f(0.8f, 0.8f, 0.8f);
            Gl.glTranslated(0, -101, -20);
            Glut.glutSolidCube(200);
            Gl.glTranslated(0, 101, 20);
        }
        void Draw_bogie(double x)
        {
            Gl.glColor3f(0.0f, 0.0f, 0.8f);
            Gl.glTranslated(2.5 + L_ + x, 1.5 - (5 - h_), 0);
            Glut.glutSolidCube(5);
            Gl.glTranslated(-(2.5 + L_), -(1.5 - (5 - h_)), 0);

            Gl.glColor3f(0.0f, 0.8f, 0.0f);
            Gl.glTranslated(L_ + 1, -0.4, 2.6);
            Glut.glutSolidTorus(0.15, 0.4, 32, 32);
            Gl.glTranslated(0, 0, -5.2);
            Glut.glutSolidTorus(0.15, 0.4, 32, 32);
            Gl.glTranslated(3, 0, 0);
            Glut.glutSolidTorus(0.15, 0.4, 32, 32);
            Gl.glTranslated(0, 0, 5.2);
            Glut.glutSolidTorus(0.15, 0.4, 32, 32);
            Gl.glTranslated(-(L_ + 4 + x), 0.4, -2.6);
        }
        void Draw_ball(double x, double y)
        {
            Gl.glColor3f(1, 0, 0);
            Gl.glTranslated(x, y - 0.5, 0);
            Glut.glutSolidSphere(0.5, 8, 8);
            Gl.glColor3f(0, 0, 0);
            Gl.glTranslated(-x, -y + 0.5, 0);
        }
        private void set_string()
        {
            Vx_current.Text = "Vx_curent = " + Math.Round(vx, 3).ToString();
            Vy_current.Text = "Vy_curent = " + Math.Round(vy, 3).ToString();
            t_current.Text = "t_current = " + Math.Round(t, 3).ToString();  
        }
        private void UpdateValue()
        {
            if (t == tMax || t == 0)
            {
                vx = vy = 0;
            }   
            else
            {
                if(!go2)
                {
                     vx = v0 * Math.Cos(angle);
                     vy = v0 * Math.Sin(angle) - g * t;
                }
                else
                {
                    vx = (-F_ * (t - tBallMax) + C1) / (m1_ + m2_);
                    vy = 0;
                }
               
            }       
        }
    }
}


//if (x - 0.5 >= L_ && y <= h_ - 0.5)
//go = false;