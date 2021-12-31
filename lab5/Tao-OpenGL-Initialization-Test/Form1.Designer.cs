
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ytrackBar = new System.Windows.Forms.TrackBar();
            this.ztrackBar = new System.Windows.Forms.TrackBar();
            this.angletrackBar = new System.Windows.Forms.TrackBar();
            this.zoomtrackBar = new System.Windows.Forms.TrackBar();
            this.xlabel = new System.Windows.Forms.Label();
            this.ylabel = new System.Windows.Forms.Label();
            this.zlabel = new System.Windows.Forms.Label();
            this.anglelabel = new System.Windows.Forms.Label();
            this.zoomlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.n_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.m_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.d_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.up_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dr1_dr2 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.loadToolStripMenuItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angletrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomtrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
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
            this.AnT.Location = new System.Drawing.Point(12, 27);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(812, 561);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(849, 112);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(75, 17);
            this.checkBox.TabIndex = 10;
            this.checkBox.Text = "Сеточный";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // xtrackBar
            // 
            this.xtrackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.xtrackBar.Location = new System.Drawing.Point(860, 174);
            this.xtrackBar.Maximum = 500;
            this.xtrackBar.Minimum = -500;
            this.xtrackBar.Name = "xtrackBar";
            this.xtrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.xtrackBar.Size = new System.Drawing.Size(45, 373);
            this.xtrackBar.TabIndex = 11;
            this.xtrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.xtrackBar.Value = -8;
            this.xtrackBar.Scroll += new System.EventHandler(this.xtrackBar_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Вращать вдоль X",
            "Вращать вдоль Y",
            "Вращать вдоль Z"});
            this.comboBox1.Location = new System.Drawing.Point(849, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Сфера",
            "Куб",
            "Хрень какая-то"});
            this.comboBox2.Location = new System.Drawing.Point(849, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(226, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // ytrackBar
            // 
            this.ytrackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ytrackBar.Location = new System.Drawing.Point(911, 174);
            this.ytrackBar.Maximum = 500;
            this.ytrackBar.Minimum = -500;
            this.ytrackBar.Name = "ytrackBar";
            this.ytrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ytrackBar.Size = new System.Drawing.Size(45, 373);
            this.ytrackBar.TabIndex = 14;
            this.ytrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ytrackBar.Scroll += new System.EventHandler(this.ytrackBar_Scroll);
            // 
            // ztrackBar
            // 
            this.ztrackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ztrackBar.Location = new System.Drawing.Point(967, 174);
            this.ztrackBar.Maximum = 500;
            this.ztrackBar.Minimum = -500;
            this.ztrackBar.Name = "ztrackBar";
            this.ztrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ztrackBar.Size = new System.Drawing.Size(45, 373);
            this.ztrackBar.TabIndex = 15;
            this.ztrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ztrackBar.Value = -30;
            this.ztrackBar.Scroll += new System.EventHandler(this.ztrackBar_Scroll);
            // 
            // angletrackBar
            // 
            this.angletrackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.angletrackBar.Location = new System.Drawing.Point(1018, 174);
            this.angletrackBar.Maximum = 360;
            this.angletrackBar.Minimum = -360;
            this.angletrackBar.Name = "angletrackBar";
            this.angletrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.angletrackBar.Size = new System.Drawing.Size(45, 373);
            this.angletrackBar.TabIndex = 16;
            this.angletrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.angletrackBar.Value = 120;
            this.angletrackBar.Scroll += new System.EventHandler(this.angletrackBar_Scroll);
            // 
            // zoomtrackBar
            // 
            this.zoomtrackBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.zoomtrackBar.Location = new System.Drawing.Point(1069, 174);
            this.zoomtrackBar.Maximum = 50;
            this.zoomtrackBar.Minimum = -50;
            this.zoomtrackBar.Name = "zoomtrackBar";
            this.zoomtrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.zoomtrackBar.Size = new System.Drawing.Size(45, 373);
            this.zoomtrackBar.TabIndex = 17;
            this.zoomtrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoomtrackBar.Value = 1;
            this.zoomtrackBar.Scroll += new System.EventHandler(this.zoomtrackBar_Scroll);
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.Location = new System.Drawing.Point(857, 550);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(16, 13);
            this.xlabel.TabIndex = 18;
            this.xlabel.Text = "-8";
            // 
            // ylabel
            // 
            this.ylabel.AutoSize = true;
            this.ylabel.Location = new System.Drawing.Point(913, 550);
            this.ylabel.Name = "ylabel";
            this.ylabel.Size = new System.Drawing.Size(13, 13);
            this.ylabel.TabIndex = 19;
            this.ylabel.Text = "0";
            // 
            // zlabel
            // 
            this.zlabel.AutoSize = true;
            this.zlabel.Location = new System.Drawing.Point(964, 550);
            this.zlabel.Name = "zlabel";
            this.zlabel.Size = new System.Drawing.Size(22, 13);
            this.zlabel.TabIndex = 20;
            this.zlabel.Text = "-30";
            // 
            // anglelabel
            // 
            this.anglelabel.AutoSize = true;
            this.anglelabel.Location = new System.Drawing.Point(1018, 550);
            this.anglelabel.Name = "anglelabel";
            this.anglelabel.Size = new System.Drawing.Size(25, 13);
            this.anglelabel.TabIndex = 24;
            this.anglelabel.Text = "120";
            // 
            // zoomlabel
            // 
            this.zoomlabel.AutoSize = true;
            this.zoomlabel.Location = new System.Drawing.Point(1069, 550);
            this.zoomlabel.Name = "zoomlabel";
            this.zoomlabel.Size = new System.Drawing.Size(13, 13);
            this.zoomlabel.TabIndex = 25;
            this.zoomlabel.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(973, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1018, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Угол";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1064, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Зум-Зум";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(848, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Вращение по оси:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(848, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Объект визуализации:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(869, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(925, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Y";
            // 
            // n_numericUpDown
            // 
            this.n_numericUpDown.ForeColor = System.Drawing.SystemColors.WindowText;
            this.n_numericUpDown.Location = new System.Drawing.Point(1252, 35);
            this.n_numericUpDown.Name = "n_numericUpDown";
            this.n_numericUpDown.Size = new System.Drawing.Size(51, 20);
            this.n_numericUpDown.TabIndex = 33;
            this.n_numericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // m_numericUpDown
            // 
            this.m_numericUpDown.Location = new System.Drawing.Point(1252, 75);
            this.m_numericUpDown.Name = "m_numericUpDown";
            this.m_numericUpDown.Size = new System.Drawing.Size(51, 20);
            this.m_numericUpDown.TabIndex = 34;
            this.m_numericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // d_numericUpDown
            // 
            this.d_numericUpDown.Location = new System.Drawing.Point(1252, 112);
            this.d_numericUpDown.Name = "d_numericUpDown";
            this.d_numericUpDown.Size = new System.Drawing.Size(51, 20);
            this.d_numericUpDown.TabIndex = 35;
            this.d_numericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1238, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1228, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // up_button
            // 
            this.up_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.up_button.Location = new System.Drawing.Point(1238, 297);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(61, 23);
            this.up_button.TabIndex = 38;
            this.up_button.Text = "Up";
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // left_button
            // 
            this.left_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.left_button.Location = new System.Drawing.Point(1176, 326);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(61, 23);
            this.left_button.TabIndex = 39;
            this.left_button.Text = "Left";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // right_button
            // 
            this.right_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.right_button.Location = new System.Drawing.Point(1301, 326);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(61, 23);
            this.right_button.TabIndex = 40;
            this.right_button.Text = "Right";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // down_button
            // 
            this.down_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.down_button.Location = new System.Drawing.Point(1238, 356);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(61, 23);
            this.down_button.TabIndex = 41;
            this.down_button.Text = "Down";
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.Click += new System.EventHandler(this.down_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1225, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Выбор текстуры";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Яблоко",
            "Ножка",
            "Листик"});
            this.comboBox3.Location = new System.Drawing.Point(1201, 494);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(142, 21);
            this.comboBox3.TabIndex = 43;
            // 
            // dr1_dr2
            // 
            this.dr1_dr2.AutoSize = true;
            this.dr1_dr2.Location = new System.Drawing.Point(937, 112);
            this.dr1_dr2.Name = "dr1_dr2";
            this.dr1_dr2.Size = new System.Drawing.Size(143, 17);
            this.dr1_dr2.TabIndex = 44;
            this.dr1_dr2.Text = "С текстурками или без";
            this.dr1_dr2.UseVisualStyleBackColor = true;
            this.dr1_dr2.CheckedChanged += new System.EventHandler(this.dr1_dr2_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.AutoSize = true;
            this.loadToolStripMenuItem.Location = new System.Drawing.Point(12, 9);
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(23, 13);
            this.loadToolStripMenuItem.TabIndex = 45;
            this.loadToolStripMenuItem.Text = "File";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 585);
            this.Controls.Add(this.loadToolStripMenuItem);
            this.Controls.Add(this.dr1_dr2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.d_numericUpDown);
            this.Controls.Add(this.m_numericUpDown);
            this.Controls.Add(this.n_numericUpDown);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.zoomlabel);
            this.Controls.Add(this.anglelabel);
            this.Controls.Add(this.zlabel);
            this.Controls.Add(this.ylabel);
            this.Controls.Add(this.xlabel);
            this.Controls.Add(this.zoomtrackBar);
            this.Controls.Add(this.angletrackBar);
            this.Controls.Add(this.ztrackBar);
            this.Controls.Add(this.ytrackBar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.xtrackBar);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ytrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ztrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angletrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomtrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.TrackBar xtrackBar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TrackBar ytrackBar;
        private System.Windows.Forms.TrackBar ztrackBar;
        private System.Windows.Forms.TrackBar angletrackBar;
        private System.Windows.Forms.TrackBar zoomtrackBar;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Label ylabel;
        private System.Windows.Forms.Label zlabel;
        private System.Windows.Forms.Label anglelabel;
        private System.Windows.Forms.Label zoomlabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown n_numericUpDown;
        private System.Windows.Forms.NumericUpDown m_numericUpDown;
        private System.Windows.Forms.NumericUpDown d_numericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.CheckBox dr1_dr2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label loadToolStripMenuItem;
    }
}

