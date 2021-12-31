
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
            this.angle_numeric = new System.Windows.Forms.NumericUpDown();
            this.Angle_ = new System.Windows.Forms.Label();
            this.V_current = new System.Windows.Forms.Label();
            this.t_current = new System.Windows.Forms.Label();
            this.Ep = new System.Windows.Forms.Label();
            this.Ek = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.trajectory = new System.Windows.Forms.CheckBox();
            this.weight = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AnT3 = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.AnT2 = new Tao.Platform.Windows.SimpleOpenGlControl();
            ((System.ComponentModel.ISupportInitialize)(this.H_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V0_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angle_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 120;
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
            this.AnT.Size = new System.Drawing.Size(593, 405);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // V0
            // 
            this.V0.AutoSize = true;
            this.V0.Location = new System.Drawing.Point(1189, 87);
            this.V0.Name = "V0";
            this.V0.Size = new System.Drawing.Size(23, 13);
            this.V0.TabIndex = 29;
            this.V0.Text = "V0:";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(1189, 46);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(18, 13);
            this.H.TabIndex = 30;
            this.H.Text = "H:";
            // 
            // H_numeric
            // 
            this.H_numeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.H_numeric.Location = new System.Drawing.Point(1240, 44);
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
            this.V0_numeric.Location = new System.Drawing.Point(1240, 80);
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
            // angle_numeric
            // 
            this.angle_numeric.Location = new System.Drawing.Point(1240, 120);
            this.angle_numeric.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.angle_numeric.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.angle_numeric.Name = "angle_numeric";
            this.angle_numeric.Size = new System.Drawing.Size(51, 20);
            this.angle_numeric.TabIndex = 35;
            this.angle_numeric.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.angle_numeric.ValueChanged += new System.EventHandler(this.angle_numeric_ValueChanged);
            // 
            // Angle_
            // 
            this.Angle_.AutoSize = true;
            this.Angle_.Location = new System.Drawing.Point(1189, 127);
            this.Angle_.Name = "Angle_";
            this.Angle_.Size = new System.Drawing.Size(36, 13);
            this.Angle_.TabIndex = 42;
            this.Angle_.Text = "angle:";
            // 
            // V_current
            // 
            this.V_current.AutoSize = true;
            this.V_current.Location = new System.Drawing.Point(61, 474);
            this.V_current.Name = "V_current";
            this.V_current.Size = new System.Drawing.Size(62, 13);
            this.V_current.TabIndex = 43;
            this.V_current.Text = "V_current =";
            // 
            // t_current
            // 
            this.t_current.AutoSize = true;
            this.t_current.Location = new System.Drawing.Point(372, 474);
            this.t_current.Name = "t_current";
            this.t_current.Size = new System.Drawing.Size(58, 13);
            this.t_current.TabIndex = 44;
            this.t_current.Text = "t_current =";
            // 
            // Ep
            // 
            this.Ep.AutoSize = true;
            this.Ep.Location = new System.Drawing.Point(787, 474);
            this.Ep.Name = "Ep";
            this.Ep.Size = new System.Drawing.Size(29, 13);
            this.Ep.TabIndex = 47;
            this.Ep.Text = "Ep =";
            // 
            // Ek
            // 
            this.Ek.AutoSize = true;
            this.Ek.Location = new System.Drawing.Point(701, 474);
            this.Ek.Name = "Ek";
            this.Ek.Size = new System.Drawing.Size(29, 13);
            this.Ek.TabIndex = 48;
            this.Ek.Text = "Ek =";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(1038, 53);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(110, 80);
            this.button.TabIndex = 49;
            this.button.Text = "Поiхали";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // trajectory
            // 
            this.trajectory.AutoSize = true;
            this.trajectory.Location = new System.Drawing.Point(1050, 161);
            this.trajectory.Name = "trajectory";
            this.trajectory.Size = new System.Drawing.Size(89, 17);
            this.trajectory.TabIndex = 50;
            this.trajectory.Text = "Траектория ";
            this.trajectory.UseVisualStyleBackColor = true;
            this.trajectory.CheckedChanged += new System.EventHandler(this.trajectory_CheckedChanged);
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(1189, 163);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(41, 13);
            this.weight.TabIndex = 51;
            this.weight.Text = "weight:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1240, 161);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown1.TabIndex = 52;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // AnT3
            // 
            this.AnT3.AccumBits = ((byte)(0));
            this.AnT3.AutoCheckErrors = false;
            this.AnT3.AutoFinish = false;
            this.AnT3.AutoMakeCurrent = true;
            this.AnT3.AutoSwapBuffers = true;
            this.AnT3.BackColor = System.Drawing.Color.Black;
            this.AnT3.ColorBits = ((byte)(32));
            this.AnT3.DepthBits = ((byte)(16));
            this.AnT3.Location = new System.Drawing.Point(1056, 247);
            this.AnT3.Name = "AnT3";
            this.AnT3.Size = new System.Drawing.Size(235, 240);
            this.AnT3.StencilBits = ((byte)(0));
            this.AnT3.TabIndex = 53;
            // 
            // AnT2
            // 
            this.AnT2.AccumBits = ((byte)(0));
            this.AnT2.AutoCheckErrors = false;
            this.AnT2.AutoFinish = false;
            this.AnT2.AutoMakeCurrent = true;
            this.AnT2.AutoSwapBuffers = true;
            this.AnT2.BackColor = System.Drawing.Color.Black;
            this.AnT2.ColorBits = ((byte)(32));
            this.AnT2.DepthBits = ((byte)(16));
            this.AnT2.Location = new System.Drawing.Point(650, 41);
            this.AnT2.Name = "AnT2";
            this.AnT2.Size = new System.Drawing.Size(225, 405);
            this.AnT2.StencilBits = ((byte)(0));
            this.AnT2.TabIndex = 54;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 520);
            this.Controls.Add(this.AnT2);
            this.Controls.Add(this.AnT3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.trajectory);
            this.Controls.Add(this.button);
            this.Controls.Add(this.Ek);
            this.Controls.Add(this.Ep);
            this.Controls.Add(this.t_current);
            this.Controls.Add(this.V_current);
            this.Controls.Add(this.Angle_);
            this.Controls.Add(this.angle_numeric);
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
            ((System.ComponentModel.ISupportInitialize)(this.angle_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown angle_numeric;
        private System.Windows.Forms.Label Angle_;
        private System.Windows.Forms.Label V_current;
        private System.Windows.Forms.Label t_current;
        private System.Windows.Forms.Label Ep;
        private System.Windows.Forms.Label Ek;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.CheckBox trajectory;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT3;
        private Tao.Platform.Windows.SimpleOpenGlControl AnT2;
    }
}

