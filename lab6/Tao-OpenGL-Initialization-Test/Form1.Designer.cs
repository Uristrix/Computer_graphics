
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.xtrackBar = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.OA_numeric = new System.Windows.Forms.NumericUpDown();
            this.AB_numeric = new System.Windows.Forms.NumericUpDown();
            this.AM_numeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OA_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AB_numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AM_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
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
            this.AnT.Size = new System.Drawing.Size(593, 561);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(711, 158);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(129, 17);
            this.checkBox.TabIndex = 10;
            this.checkBox.Text = "Траектория точки М";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // xtrackBar
            // 
            this.xtrackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xtrackBar.Location = new System.Drawing.Point(709, 223);
            this.xtrackBar.Maximum = 50;
            this.xtrackBar.Minimum = 1;
            this.xtrackBar.Name = "xtrackBar";
            this.xtrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xtrackBar.Size = new System.Drawing.Size(178, 45);
            this.xtrackBar.TabIndex = 11;
            this.xtrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.xtrackBar.Value = 1;
            this.xtrackBar.Scroll += new System.EventHandler(this.xtrackBar_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(708, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Длина AB:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(708, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Длина OA:";
            // 
            // OA_numeric
            // 
            this.OA_numeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OA_numeric.Location = new System.Drawing.Point(836, 39);
            this.OA_numeric.Name = "OA_numeric";
            this.OA_numeric.Size = new System.Drawing.Size(51, 20);
            this.OA_numeric.TabIndex = 33;
            this.OA_numeric.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.OA_numeric.ValueChanged += new System.EventHandler(this.OA_numeric_ValueChanged);
            // 
            // AB_numeric
            // 
            this.AB_numeric.Location = new System.Drawing.Point(836, 80);
            this.AB_numeric.Name = "AB_numeric";
            this.AB_numeric.Size = new System.Drawing.Size(51, 20);
            this.AB_numeric.TabIndex = 34;
            this.AB_numeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.AB_numeric.ValueChanged += new System.EventHandler(this.AB_numeric_ValueChanged);
            // 
            // AM_numeric
            // 
            this.AM_numeric.Location = new System.Drawing.Point(836, 122);
            this.AM_numeric.Name = "AM_numeric";
            this.AM_numeric.Size = new System.Drawing.Size(51, 20);
            this.AM_numeric.TabIndex = 35;
            this.AM_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AM_numeric.ValueChanged += new System.EventHandler(this.AM_numeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Длина AM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(729, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Скорость отрисовки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 649);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AM_numeric);
            this.Controls.Add(this.AB_numeric);
            this.Controls.Add(this.OA_numeric);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.xtrackBar);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OA_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AB_numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AM_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TrackBar xtrackBar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown OA_numeric;
        private System.Windows.Forms.NumericUpDown AB_numeric;
        private System.Windows.Forms.NumericUpDown AM_numeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

