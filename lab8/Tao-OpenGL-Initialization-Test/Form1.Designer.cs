
namespace Tao_OpenGL_Initialization_Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.V0 = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.H_numeric = new System.Windows.Forms.NumericUpDown();
            this.V0_numeric = new System.Windows.Forms.NumericUpDown();
            this.Vx_current = new System.Windows.Forms.Label();
            this.t_current = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.m1 = new System.Windows.Forms.Label();
            this.m1_numeric = new System.Windows.Forms.NumericUpDown();
            this.m2 = new System.Windows.Forms.Label();
            this.m2_numeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_numeric = new System.Windows.Forms.NumericUpDown();
            this.h__numeric = new System.Windows.Forms.NumericUpDown();
            this.F_numeric = new System.Windows.Forms.NumericUpDown();
            this.F = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.h__ = new System.Windows.Forms.Label();
            this.Vy_current = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.H_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V0_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h__numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 60;
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(36, 41);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(857, 476);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // V0
            // 
            this.V0.AutoSize = true;
            this.V0.Location = new System.Drawing.Point(1167, 84);
            this.V0.Name = "V0";
            this.V0.Size = new System.Drawing.Size(23, 13);
            this.V0.TabIndex = 29;
            this.V0.Text = "V0:";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(1167, 43);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(18, 13);
            this.H.TabIndex = 30;
            this.H.Text = "H:";
            // 
            // H_numeric
            // 
            this.H_numeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.H_numeric.Location = new System.Drawing.Point(1218, 41);
            this.H_numeric.Name = "H_numeric";
            this.H_numeric.Size = new System.Drawing.Size(51, 20);
            this.H_numeric.TabIndex = 33;
            this.H_numeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.H_numeric.ValueChanged += new System.EventHandler(this.H_numeric_ValueChanged);
            // 
            // V0_numeric
            // 
            this.V0_numeric.Location = new System.Drawing.Point(1218, 82);
            this.V0_numeric.Name = "V0_numeric";
            this.V0_numeric.Size = new System.Drawing.Size(51, 20);
            this.V0_numeric.TabIndex = 34;
            this.V0_numeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.V0_numeric.ValueChanged += new System.EventHandler(this.V0_numeric_ValueChanged);
            // 
            // Vx_current
            // 
            this.Vx_current.AutoSize = true;
            this.Vx_current.Location = new System.Drawing.Point(62, 535);
            this.Vx_current.Name = "Vx_current";
            this.Vx_current.Size = new System.Drawing.Size(67, 13);
            this.Vx_current.TabIndex = 43;
            this.Vx_current.Text = "Vx_current =";
            // 
            // t_current
            // 
            this.t_current.AutoSize = true;
            this.t_current.Location = new System.Drawing.Point(387, 535);
            this.t_current.Name = "t_current";
            this.t_current.Size = new System.Drawing.Size(58, 13);
            this.t_current.TabIndex = 44;
            this.t_current.Text = "t_current =";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(1170, 437);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(110, 80);
            this.button.TabIndex = 49;
            this.button.Text = "Поiхали";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // m1
            // 
            this.m1.AutoSize = true;
            this.m1.Location = new System.Drawing.Point(1167, 122);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(24, 13);
            this.m1.TabIndex = 51;
            this.m1.Text = "m1:";
            // 
            // m1_numeric
            // 
            this.m1_numeric.Location = new System.Drawing.Point(1218, 120);
            this.m1_numeric.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.m1_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m1_numeric.Name = "m1_numeric";
            this.m1_numeric.Size = new System.Drawing.Size(51, 20);
            this.m1_numeric.TabIndex = 52;
            this.m1_numeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.m1_numeric.ValueChanged += new System.EventHandler(this.m1_numeric_ValueChanged);
            // 
            // m2
            // 
            this.m2.AutoSize = true;
            this.m2.Location = new System.Drawing.Point(1167, 283);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(24, 13);
            this.m2.TabIndex = 53;
            this.m2.Text = "m2:";
            // 
            // m2_numeric
            // 
            this.m2_numeric.Location = new System.Drawing.Point(1218, 281);
            this.m2_numeric.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.m2_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m2_numeric.Name = "m2_numeric";
            this.m2_numeric.Size = new System.Drawing.Size(51, 20);
            this.m2_numeric.TabIndex = 54;
            this.m2_numeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.m2_numeric.ValueChanged += new System.EventHandler(this.m2_numeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Снаряд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1167, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Тележка с песком";
            // 
            // L_numeric
            // 
            this.L_numeric.Location = new System.Drawing.Point(1218, 237);
            this.L_numeric.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.L_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.L_numeric.Name = "L_numeric";
            this.L_numeric.Size = new System.Drawing.Size(51, 20);
            this.L_numeric.TabIndex = 57;
            this.L_numeric.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.L_numeric.ValueChanged += new System.EventHandler(this.L_numeric_ValueChanged);
            // 
            // h__numeric
            // 
            this.h__numeric.Location = new System.Drawing.Point(1218, 196);
            this.h__numeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.h__numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.h__numeric.Name = "h__numeric";
            this.h__numeric.Size = new System.Drawing.Size(51, 20);
            this.h__numeric.TabIndex = 58;
            this.h__numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.h__numeric.ValueChanged += new System.EventHandler(this.h__numeric_ValueChanged);
            // 
            // F_numeric
            // 
            this.F_numeric.Location = new System.Drawing.Point(1218, 355);
            this.F_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.F_numeric.Name = "F_numeric";
            this.F_numeric.Size = new System.Drawing.Size(51, 20);
            this.F_numeric.TabIndex = 59;
            this.F_numeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.F_numeric.ValueChanged += new System.EventHandler(this.F_numeric_ValueChanged);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(1166, 357);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(16, 13);
            this.F.TabIndex = 60;
            this.F.Text = "F:";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Location = new System.Drawing.Point(1166, 239);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(16, 13);
            this.L.TabIndex = 61;
            this.L.Text = "L:";
            // 
            // h__
            // 
            this.h__.AutoSize = true;
            this.h__.Location = new System.Drawing.Point(962, 504);
            this.h__.Name = "h__";
            this.h__.Size = new System.Drawing.Size(13, 13);
            this.h__.TabIndex = 62;
            this.h__.Text = "0";
            // 
            // Vy_current
            // 
            this.Vy_current.AutoSize = true;
            this.Vy_current.Location = new System.Drawing.Point(216, 535);
            this.Vy_current.Name = "Vy_current";
            this.Vy_current.Size = new System.Drawing.Size(67, 13);
            this.Vy_current.TabIndex = 63;
            this.Vy_current.Text = "Vy_current =";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Вращать вдоль X",
            "Вращать вдоль Y",
            "Вращать вдоль Z"});
            this.comboBox1.Location = new System.Drawing.Point(1015, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.Text = "Вращать вдоль X";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(915, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "Вращать по оси: ";
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBar1.Location = new System.Drawing.Point(899, 122);
            this.trackBar1.Maximum = 50000;
            this.trackBar1.Minimum = -50000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 373);
            this.trackBar1.TabIndex = 66;
            this.trackBar1.Value = -5000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBar2.Location = new System.Drawing.Point(950, 122);
            this.trackBar2.Maximum = 50000;
            this.trackBar2.Minimum = -50000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 373);
            this.trackBar2.TabIndex = 67;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBar3.Location = new System.Drawing.Point(1001, 122);
            this.trackBar3.Maximum = 50000;
            this.trackBar3.Minimum = -50000;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 373);
            this.trackBar3.TabIndex = 68;
            this.trackBar3.Value = -10000;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // trackBar4
            // 
            this.trackBar4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBar4.Location = new System.Drawing.Point(1052, 122);
            this.trackBar4.Maximum = 360;
            this.trackBar4.Minimum = -360;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.Size = new System.Drawing.Size(45, 373);
            this.trackBar4.TabIndex = 69;
            this.trackBar4.Value = 10;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar4_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBar5.Location = new System.Drawing.Point(1103, 122);
            this.trackBar5.Maximum = 5000;
            this.trackBar5.Minimum = -5000;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar5.Size = new System.Drawing.Size(45, 373);
            this.trackBar5.TabIndex = 70;
            this.trackBar5.Value = 250;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(915, 504);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "-5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1012, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "-10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1065, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1108, 504);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "0.250";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(914, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(962, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 77;
            this.label15.Text = "Y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1012, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 78;
            this.label10.Text = "Z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1049, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 79;
            this.label11.Text = "Угол";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1100, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 80;
            this.label13.Text = "Zoom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1166, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "h:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 566);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Vy_current);
            this.Controls.Add(this.h__);
            this.Controls.Add(this.L);
            this.Controls.Add(this.F);
            this.Controls.Add(this.F_numeric);
            this.Controls.Add(this.h__numeric);
            this.Controls.Add(this.L_numeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m2_numeric);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.m1_numeric);
            this.Controls.Add(this.m1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.t_current);
            this.Controls.Add(this.Vx_current);
            this.Controls.Add(this.V0_numeric);
            this.Controls.Add(this.H_numeric);
            this.Controls.Add(this.H);
            this.Controls.Add(this.V0);
            this.Controls.Add(this.AnT);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.H_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V0_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m1_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h__numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label V0;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.NumericUpDown H_numeric;
        private System.Windows.Forms.NumericUpDown V0_numeric;
        private System.Windows.Forms.Label Vx_current;
        private System.Windows.Forms.Label t_current;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label m1;
        private System.Windows.Forms.NumericUpDown m1_numeric;
        private System.Windows.Forms.Label m2;
        private System.Windows.Forms.NumericUpDown m2_numeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown L_numeric;
        private System.Windows.Forms.NumericUpDown h__numeric;
        private System.Windows.Forms.NumericUpDown F_numeric;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Label h__;
        private System.Windows.Forms.Label Vy_current;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
    }
}

