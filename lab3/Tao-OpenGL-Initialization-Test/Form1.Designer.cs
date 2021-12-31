
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
            this.PointInGrap = new System.Windows.Forms.Timer(this.components);
            this.func = new System.Windows.Forms.ComboBox();
            this.color = new System.Windows.Forms.ComboBox();
            this.element = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.x_pos = new System.Windows.Forms.Label();
            this.y_pos = new System.Windows.Forms.Label();
            this.z_pos = new System.Windows.Forms.Label();
            this.numericX = new System.Windows.Forms.NumericUpDown();
            this.numericY = new System.Windows.Forms.NumericUpDown();
            this.numericZ = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.x_max = new System.Windows.Forms.Label();
            this.x_min = new System.Windows.Forms.Label();
            this.y_min = new System.Windows.Forms.Label();
            this.y_max = new System.Windows.Forms.Label();
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PointInGrap
            // 
            this.PointInGrap.Tick += new System.EventHandler(this.PointInGrap_Tick);
            // 
            // func
            // 
            this.func.FormattingEnabled = true;
            this.func.Items.AddRange(new object[] {
            "Синусоида",
            "Парабола"});
            this.func.Location = new System.Drawing.Point(954, 56);
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(121, 21);
            this.func.TabIndex = 1;
            this.func.Text = "Синусоида";
            this.func.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // color
            // 
            this.color.FormattingEnabled = true;
            this.color.Items.AddRange(new object[] {
            "Красный",
            "Зелёный",
            "Синий",
            "Чёрный"});
            this.color.Location = new System.Drawing.Point(954, 145);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(121, 21);
            this.color.TabIndex = 2;
            this.color.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // element
            // 
            this.element.FormattingEnabled = true;
            this.element.Items.AddRange(new object[] {
            "График функции",
            "Оси",
            "Точка и курсор"});
            this.element.Location = new System.Drawing.Point(954, 99);
            this.element.Name = "element";
            this.element.Size = new System.Drawing.Size(121, 21);
            this.element.TabIndex = 3;
            this.element.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Функция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(857, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Элемент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(867, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цвет";
            // 
            // x_pos
            // 
            this.x_pos.AutoSize = true;
            this.x_pos.Location = new System.Drawing.Point(864, 214);
            this.x_pos.Name = "x_pos";
            this.x_pos.Size = new System.Drawing.Size(37, 13);
            this.x_pos.TabIndex = 11;
            this.x_pos.Text = "Ось X";
            // 
            // y_pos
            // 
            this.y_pos.AutoSize = true;
            this.y_pos.Location = new System.Drawing.Point(862, 258);
            this.y_pos.Name = "y_pos";
            this.y_pos.Size = new System.Drawing.Size(37, 13);
            this.y_pos.TabIndex = 12;
            this.y_pos.Text = "Ось Y";
            // 
            // z_pos
            // 
            this.z_pos.AutoSize = true;
            this.z_pos.Location = new System.Drawing.Point(862, 301);
            this.z_pos.Name = "z_pos";
            this.z_pos.Size = new System.Drawing.Size(37, 13);
            this.z_pos.TabIndex = 13;
            this.z_pos.Text = "Ось Z";
            // 
            // numericX
            // 
            this.numericX.Location = new System.Drawing.Point(955, 207);
            this.numericX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericX.Name = "numericX";
            this.numericX.Size = new System.Drawing.Size(120, 20);
            this.numericX.TabIndex = 15;
            this.numericX.ValueChanged += new System.EventHandler(this.numericX_ValueChanged);
            // 
            // numericY
            // 
            this.numericY.Location = new System.Drawing.Point(954, 251);
            this.numericY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericY.Name = "numericY";
            this.numericY.Size = new System.Drawing.Size(120, 20);
            this.numericY.TabIndex = 16;
            this.numericY.ValueChanged += new System.EventHandler(this.numericY_ValueChanged);
            // 
            // numericZ
            // 
            this.numericZ.Location = new System.Drawing.Point(954, 294);
            this.numericZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericZ.Name = "numericZ";
            this.numericZ.Size = new System.Drawing.Size(120, 20);
            this.numericZ.TabIndex = 17;
            this.numericZ.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericZ.ValueChanged += new System.EventHandler(this.numericZ_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // x_max
            // 
            this.x_max.AutoSize = true;
            this.x_max.Location = new System.Drawing.Point(788, 556);
            this.x_max.Name = "x_max";
            this.x_max.Size = new System.Drawing.Size(35, 13);
            this.x_max.TabIndex = 19;
            this.x_max.Text = "label4";
            // 
            // x_min
            // 
            this.x_min.AutoSize = true;
            this.x_min.Location = new System.Drawing.Point(59, 556);
            this.x_min.Name = "x_min";
            this.x_min.Size = new System.Drawing.Size(35, 13);
            this.x_min.TabIndex = 20;
            this.x_min.Text = "label5";
            // 
            // y_min
            // 
            this.y_min.AutoSize = true;
            this.y_min.Location = new System.Drawing.Point(12, 534);
            this.y_min.Name = "y_min";
            this.y_min.Size = new System.Drawing.Size(35, 13);
            this.y_min.TabIndex = 21;
            this.y_min.Text = "label6";
            // 
            // y_max
            // 
            this.y_max.AutoSize = true;
            this.y_max.Location = new System.Drawing.Point(12, 51);
            this.y_max.Name = "y_max";
            this.y_max.Size = new System.Drawing.Size(35, 13);
            this.y_max.TabIndex = 22;
            this.y_max.Text = "label7";
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.BackgroundImage = global::Tao_OpenGL_Initialization_Test.Properties.Resources._89e3e06e079aedd484cd6d05ce5684f6_w200;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(62, 51);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(761, 496);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.MouseHover += new System.EventHandler(this.AnT_MouseHover);
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AnT_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tao_OpenGL_Initialization_Test.Properties.Resources._89e3e06e079aedd484cd6d05ce5684f6_w200;
            this.pictureBox1.Location = new System.Drawing.Point(860, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 585);
            this.Controls.Add(this.y_max);
            this.Controls.Add(this.y_min);
            this.Controls.Add(this.x_min);
            this.Controls.Add(this.x_max);
            this.Controls.Add(this.numericZ);
            this.Controls.Add(this.numericY);
            this.Controls.Add(this.numericX);
            this.Controls.Add(this.z_pos);
            this.Controls.Add(this.y_pos);
            this.Controls.Add(this.x_pos);
            this.Controls.Add(this.AnT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.element);
            this.Controls.Add(this.color);
            this.Controls.Add(this.func);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer PointInGrap;
        private System.Windows.Forms.ComboBox func;
        private System.Windows.Forms.ComboBox color;
        private System.Windows.Forms.ComboBox element;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label x_pos;
        private System.Windows.Forms.Label y_pos;
        private System.Windows.Forms.Label z_pos;
        private System.Windows.Forms.NumericUpDown numericX;
        private System.Windows.Forms.NumericUpDown numericY;
        private System.Windows.Forms.NumericUpDown numericZ;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label x_max;
        private System.Windows.Forms.Label x_min;
        private System.Windows.Forms.Label y_min;
        private System.Windows.Forms.Label y_max;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

