using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

 struct AnT_axes
{
    public int Xmin, Xmax, Ymin, Ymax, z;
    public void set(int xmin, int xmax, int ymin, int ymax, int Z)
    {
        Xmin = xmin;
        Xmax = xmax;
        Ymin = ymin;
        Ymax = ymax;
        z = Z;
    }
};

namespace Tao_OpenGL_Initialization_Test
{
    public partial class Form1 : Form
    {
        const double g = 9.82;

        AnT_axes Ant1, Ant2, Ant3;
        double h = 5, v0 = 15, m = 5, angle = 80 * Math.PI / 180;
        double ep, ek, v;

        double t = 0.0;
        double tMax = 0.0, epMax = 0.0, ekMax = 0.0, eMax = 1000;
        bool go = false, traj = false;
        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
            AnT2.InitializeContexts();
            AnT3.InitializeContexts();
        }
        private void H_numeric_ValueChanged(object sender, EventArgs e) => h = (int)H_numeric.Value;
        private void V0_numeric_ValueChanged(object sender, EventArgs e) => v0 = (int)V0_numeric.Value;
        private void angle_numeric_ValueChanged(object sender, EventArgs e) => angle = (int)angle_numeric.Value * Math.PI / 180;
        private void trajectory_CheckedChanged(object sender, EventArgs e) => traj = trajectory.Checked;
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            m = (int)numericUpDown1.Value;
            t = 0.0;
        }
        private void button_Click(object sender, EventArgs e)
        {
            t = 0.0;  
            go = true;
            CalcMax();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Glut.glutInit();
            AnT.MakeCurrent();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(115, (float)AnT.Width / (float)AnT.Height, 0.2, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            AnT2.MakeCurrent();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT2.Width, AnT2.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(115, (float)AnT2.Width / (float)AnT2.Height, 0.2, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            AnT3.MakeCurrent();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT3.Width, AnT3.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(115, (float)AnT3.Width / (float)AnT3.Height, 0.2, 100);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AnT.MakeCurrent();
            DrawAnT1(Ant1);
            
            if (traj) 
                DrawTrajectory();

            AnT2.MakeCurrent();
            DrawAnT2(Ant2);

            AnT3.MakeCurrent();
            DrawAnT3(Ant3);

            UpdateValue();
            set_string();

            if (go)
                t += 0.05;

            if (t > tMax)
            {
                v = 0;
                t = tMax;
                go = false;
            }  
        }

        private void DrawAnT1(AnT_axes ant)
        {
            ant.set(-22, 45, -15, 30, -10);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(ant.Xmin, ant.Ymin, ant.z);

            DrawGrid(ant);
            DrawAxes("x", "y", ant);
            Draw_point(v0 * Math.Cos(angle) * t, v0 * Math.Sin(angle) * t + h - (g * t * t / 2), Ant1);

            AnT.Invalidate();
        }

        private void DrawAnT2(AnT_axes ant)
        {
            ant.set(-4, 17, -10, 30, -7);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(ant.Xmin, ant.Ymin, ant.z);

            DrawGrid(ant);
            DrawAxes(" ", " ", ant);
            DrawEnergy(ant);
            DrawAnt2Info(eMax, 20, 100);
            
            AnT2.Invalidate();
        }

        private void DrawAnT3(AnT_axes ant)
        {
            ant.set(-5, 12, -5, 12, -5);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(ant.Xmin, ant.Ymin, ant.z);

            DrawGrid(ant);
            DrawAxes("t", "v", ant);
            DrawAnt3Info(Math.Sqrt(v0 * v0 - 2 * v0 * Math.Sin(angle) * g * tMax + g * g * tMax * tMax), 10);
            Gl.glColor3f(0, 0, 255);
            Gl.glBegin(Gl.GL_LINE_STRIP);
             
            int k;
            //for (k = (int)(v0 * t * Math.Cos(angle)); k % 10 != 0; k++);
            for (double T = 0.0; T < tMax; T += 0.1)
                Gl.glVertex2d(T, v0 * Math.Sin(angle) - g * T);
            /*for (k = (int)Math.Sqrt(v0 * v0 - 2 * v0 * Math.Sin(angle) * g * tMax + g * g * tMax * tMax); k % 10 != 0; k++);

            for (double T = 0.0; T < tMax; T += 0.1)
                Gl.glVertex2d(T, Math.Sqrt(v0 * v0 - 2 * v0 * Math.Sin(angle) * g * T + g * g * T * T) / (k / 10));
*/
            Gl.glEnd();

            AnT3.Invalidate();
        }


        private void DrawTrajectory()
        {
            Gl.glColor3f(0, 0, 255);
            Gl.glBegin(Gl.GL_LINE_STRIP);

            for (double T = 0.0; T < tMax; T += 0.1)
                Gl.glVertex2d(v0 * Math.Cos(angle) * T, v0 * Math.Sin(angle) * T + h - (g * T * T / 2));

            Gl.glVertex2d(v0 * Math.Cos(angle) * tMax, v0 * Math.Sin(angle) * tMax + h - (g * tMax * tMax / 2));
            Gl.glEnd();
        }
        private void DrawAnt2Info(double value, int point_num, int norm)
        {
            int k;
            for (k = (int)value; k % point_num != 0 || k % norm != 0 || k / point_num % 10 != 0; k++);

            for (int i = 0; i <= point_num; i++)
                PrintText2D((float)-2, (float)i, (i * (k/ point_num)).ToString());
        }
        private void DrawAnt3Info(double value, int point_num)
        {
            int k;
            for (k = (int)value; k % point_num != 0; k++);

            for (int i = 0; i <= point_num; i++)
                PrintText2D((float)-2, (float)i, (i * (k / point_num)).ToString());
        }
        private void CalcMax()
        {
            tMax = (v0 * Math.Sin(angle) + Math.Sqrt(v0 * v0 * Math.Sin(angle) * Math.Sin(angle) + 2 * g * h)) / g;
            epMax = m * g * (h + (v0 * v0 * Math.Sin(angle) * Math.Sin(angle) / 2 / g));
            ekMax = m * Math.Sqrt(v0 * v0 - 2 * v0 * Math.Sin(angle) * g * tMax + g * g * tMax * tMax) *
                Math.Sqrt(v0 * v0 - 2 * v0 * Math.Sin(angle) * g * tMax + g * g * tMax * tMax) / 2;
            eMax = Math.Round((epMax > ekMax ? epMax : ekMax), 0);
        }
        private void DrawEnergy(AnT_axes ant)
        {
            int k;
            for (k = (int)eMax; k % 20 != 0 || k % 100 != 0 || k / 20 % 10 != 0; k++);

            double ek_ = 0.0, ep_ = 0.0;
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3f(255, 0, 255);
            while(ek_ <= ek)
            { 
                Gl.glVertex2d(1, ek_/ (k / 20));
                Gl.glVertex2d(4, ek_/ (k / 20));
                ek_ += 0.1;
            }
            Gl.glEnd();
           
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3f(0, 255, 0);
            while (ep_ <= ep)
            {
                Gl.glVertex2d(6, ep_ / (k / 20));
                Gl.glVertex2d(9, ep_ / (k / 20));
                ep_ += 0.1;
            }
            Gl.glEnd();
        }
        private void set_string()
        {
            V_current.Text = "V_curent = " + Math.Round(v, 3).ToString();
            t_current.Text = "t_current = " + Math.Round(t, 3).ToString();
            Ek.Text = "Ek = " + Math.Round(ek, 3).ToString();
            Ep.Text = "Ep = " + Math.Round(ep, 3).ToString();
        }
        private void UpdateValue()
        {
            if (t == tMax)
                v = 0;
            else
                v = Math.Sqrt(v0 * v0 - 2 * v0 * Math.Sin(angle) * g * t + g * g * t * t);

            ek = m * v * v / 2;
            ep = m * g * (v0 * Math.Sin(angle) * t + h - (g * t * t / 2));
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void DrawGrid(AnT_axes ant)
        {
            Gl.glPointSize(2);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glColor3f(0, 0, 0);

            for (int ax = ant.Xmin; ax < ant.Xmax + 1; ax++)
                for (int bx = ant.Ymin; bx < ant.Ymax + 1; bx++)
                    Gl.glVertex2d(ax, bx);
            Gl.glEnd();
        }

        void Draw_point(double x, double y, AnT_axes ant)
        {
            Gl.glPointSize(7);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glColor3f(1, 0, 0);
            Gl.glVertex2d(x, y);
            Gl.glEnd();
            Gl.glColor3f(0, 0, 0);
        }

        private void DrawAxes(String x, String y, AnT_axes ant)
        { 
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2d(0, ant.Ymin);
            Gl.glVertex2d(0, ant.Ymax);
            Gl.glEnd();
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2d(ant.Xmin, 0);
            Gl.glVertex2d(ant.Xmax, 0);

            if (ant.Ymax > 0)
            {
                Gl.glVertex2d(0, ant.Ymax);
                Gl.glVertex2d(0.2, ant.Ymax - 0.85);
                Gl.glVertex2d(0, ant.Ymax);
                Gl.glVertex2d(-0.2, ant.Ymax - 0.85);
            }
            if (ant.Xmax > 0)
            {
                Gl.glVertex2d(ant.Xmax, 0);
                Gl.glVertex2d(ant.Xmax - 0.85, 0.2);
                Gl.glVertex2d(ant.Xmax, 0);
                Gl.glVertex2d(ant.Xmax - 0.85, -0.2);
            }
            Gl.glEnd();

            PrintText2D(ant.Xmax - 0.8f, 0.5f, x);
            PrintText2D(0.5f, ant.Ymax - 0.5f, y);
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