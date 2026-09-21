namespace Lab2
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelHistGray2 = new System.Windows.Forms.Panel();
            this.panelHistGray1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGray = new System.Windows.Forms.Button();
            this.pictureDifference = new System.Windows.Forms.PictureBox();
            this.pictureGray2 = new System.Windows.Forms.PictureBox();
            this.pictureGray1 = new System.Windows.Forms.PictureBox();
            this.pictureOriginalGray = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelHistBlue = new System.Windows.Forms.Panel();
            this.panelHistGreen = new System.Windows.Forms.Panel();
            this.panelHistRed = new System.Windows.Forms.Panel();
            this.btnRGB = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBlue = new System.Windows.Forms.PictureBox();
            this.pictureGreen = new System.Windows.Forms.PictureBox();
            this.pictureRed = new System.Windows.Forms.PictureBox();
            this.pictureOriginalRGB = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaveHSV = new System.Windows.Forms.Button();
            this.labelValueValue = new System.Windows.Forms.Label();
            this.labelSaturationValue = new System.Windows.Forms.Label();
            this.labelHueValue = new System.Windows.Forms.Label();
            this.trackValue = new System.Windows.Forms.TrackBar();
            this.trackSaturation = new System.Windows.Forms.TrackBar();
            this.trackHue = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureResultHSV = new System.Windows.Forms.PictureBox();
            this.labelOriginalHSV = new System.Windows.Forms.Label();
            this.pictureOriginalHSV = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGray2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGray1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginalGray)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginalRGB)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResultHSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginalHSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(933, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(211, 34);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Загрузить изображение";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1184, 754);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelHistGray2);
            this.tabPage1.Controls.Add(this.panelHistGray1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnGray);
            this.tabPage1.Controls.Add(this.pictureDifference);
            this.tabPage1.Controls.Add(this.pictureGray2);
            this.tabPage1.Controls.Add(this.pictureGray1);
            this.tabPage1.Controls.Add(this.pictureOriginalGray);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1176, 725);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оттенки серого";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelHistGray2
            // 
            this.panelHistGray2.BackColor = System.Drawing.Color.White;
            this.panelHistGray2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistGray2.Location = new System.Drawing.Point(640, 338);
            this.panelHistGray2.Name = "panelHistGray2";
            this.panelHistGray2.Size = new System.Drawing.Size(450, 170);
            this.panelHistGray2.TabIndex = 12;
            this.panelHistGray2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHistGray2_Paint);
            // 
            // panelHistGray1
            // 
            this.panelHistGray1.BackColor = System.Drawing.Color.White;
            this.panelHistGray1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistGray1.Location = new System.Drawing.Point(75, 338);
            this.panelHistGray1.Name = "panelHistGray1";
            this.panelHistGray1.Size = new System.Drawing.Size(450, 170);
            this.panelHistGray1.TabIndex = 11;
            this.panelHistGray1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHistGray1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(637, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Гистограмма 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Гистограмма 1";
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(930, 256);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(211, 34);
            this.btnGray.TabIndex = 8;
            this.btnGray.Text = "Выполнить преобразование";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // pictureDifference
            // 
            this.pictureDifference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureDifference.Location = new System.Drawing.Point(901, 53);
            this.pictureDifference.Name = "pictureDifference";
            this.pictureDifference.Size = new System.Drawing.Size(240, 180);
            this.pictureDifference.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDifference.TabIndex = 7;
            this.pictureDifference.TabStop = false;
            // 
            // pictureGray2
            // 
            this.pictureGray2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureGray2.Location = new System.Drawing.Point(614, 53);
            this.pictureGray2.Name = "pictureGray2";
            this.pictureGray2.Size = new System.Drawing.Size(240, 180);
            this.pictureGray2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGray2.TabIndex = 6;
            this.pictureGray2.TabStop = false;
            // 
            // pictureGray1
            // 
            this.pictureGray1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureGray1.Location = new System.Drawing.Point(326, 53);
            this.pictureGray1.Name = "pictureGray1";
            this.pictureGray1.Size = new System.Drawing.Size(240, 180);
            this.pictureGray1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGray1.TabIndex = 5;
            this.pictureGray1.TabStop = false;
            // 
            // pictureOriginalGray
            // 
            this.pictureOriginalGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureOriginalGray.Location = new System.Drawing.Point(32, 53);
            this.pictureOriginalGray.Name = "pictureOriginalGray";
            this.pictureOriginalGray.Size = new System.Drawing.Size(240, 180);
            this.pictureOriginalGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOriginalGray.TabIndex = 4;
            this.pictureOriginalGray.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(989, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Разность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(686, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Формула 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Формула 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходное изображение";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.panelHistBlue);
            this.tabPage2.Controls.Add(this.panelHistGreen);
            this.tabPage2.Controls.Add(this.panelHistRed);
            this.tabPage2.Controls.Add(this.btnRGB);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.pictureBlue);
            this.tabPage2.Controls.Add(this.pictureGreen);
            this.tabPage2.Controls.Add(this.pictureRed);
            this.tabPage2.Controls.Add(this.pictureOriginalRGB);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 725);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RGB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(786, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Гистограмма B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 286);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Гистограмма G";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Гистограмма R";
            // 
            // panelHistBlue
            // 
            this.panelHistBlue.BackColor = System.Drawing.Color.White;
            this.panelHistBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistBlue.Location = new System.Drawing.Point(789, 317);
            this.panelHistBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHistBlue.Name = "panelHistBlue";
            this.panelHistBlue.Size = new System.Drawing.Size(355, 249);
            this.panelHistBlue.TabIndex = 11;
            this.panelHistBlue.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHistBlue_Paint);
            // 
            // panelHistGreen
            // 
            this.panelHistGreen.BackColor = System.Drawing.Color.White;
            this.panelHistGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistGreen.Location = new System.Drawing.Point(418, 317);
            this.panelHistGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHistGreen.Name = "panelHistGreen";
            this.panelHistGreen.Size = new System.Drawing.Size(355, 249);
            this.panelHistGreen.TabIndex = 10;
            this.panelHistGreen.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHistGreen_Paint);
            // 
            // panelHistRed
            // 
            this.panelHistRed.BackColor = System.Drawing.Color.White;
            this.panelHistRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistRed.Location = new System.Drawing.Point(43, 317);
            this.panelHistRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHistRed.Name = "panelHistRed";
            this.panelHistRed.Size = new System.Drawing.Size(355, 249);
            this.panelHistRed.TabIndex = 9;
            this.panelHistRed.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHistRed_Paint);
            // 
            // btnRGB
            // 
            this.btnRGB.Location = new System.Drawing.Point(982, 249);
            this.btnRGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRGB.Name = "btnRGB";
            this.btnRGB.Size = new System.Drawing.Size(162, 34);
            this.btnRGB.TabIndex = 8;
            this.btnRGB.Text = "Выделить каналы";
            this.btnRGB.UseVisualStyleBackColor = true;
            this.btnRGB.Click += new System.EventHandler(this.btnRGB_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(927, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Синий канал";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(642, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Зелёный канал";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(349, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Красный канал";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Исходное изображение";
            // 
            // pictureBlue
            // 
            this.pictureBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBlue.Location = new System.Drawing.Point(931, 50);
            this.pictureBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBlue.Name = "pictureBlue";
            this.pictureBlue.Size = new System.Drawing.Size(214, 185);
            this.pictureBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBlue.TabIndex = 3;
            this.pictureBlue.TabStop = false;
            // 
            // pictureGreen
            // 
            this.pictureGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureGreen.Location = new System.Drawing.Point(645, 50);
            this.pictureGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureGreen.Name = "pictureGreen";
            this.pictureGreen.Size = new System.Drawing.Size(214, 185);
            this.pictureGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureGreen.TabIndex = 2;
            this.pictureGreen.TabStop = false;
            // 
            // pictureRed
            // 
            this.pictureRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureRed.Location = new System.Drawing.Point(353, 50);
            this.pictureRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureRed.Name = "pictureRed";
            this.pictureRed.Size = new System.Drawing.Size(214, 185);
            this.pictureRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRed.TabIndex = 1;
            this.pictureRed.TabStop = false;
            // 
            // pictureOriginalRGB
            // 
            this.pictureOriginalRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureOriginalRGB.Location = new System.Drawing.Point(43, 50);
            this.pictureOriginalRGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureOriginalRGB.Name = "pictureOriginalRGB";
            this.pictureOriginalRGB.Size = new System.Drawing.Size(214, 185);
            this.pictureOriginalRGB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOriginalRGB.TabIndex = 0;
            this.pictureOriginalRGB.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSaveHSV);
            this.tabPage3.Controls.Add(this.labelValueValue);
            this.tabPage3.Controls.Add(this.labelSaturationValue);
            this.tabPage3.Controls.Add(this.labelHueValue);
            this.tabPage3.Controls.Add(this.trackValue);
            this.tabPage3.Controls.Add(this.trackSaturation);
            this.tabPage3.Controls.Add(this.trackHue);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.pictureResultHSV);
            this.tabPage3.Controls.Add(this.labelOriginalHSV);
            this.tabPage3.Controls.Add(this.pictureOriginalHSV);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1176, 725);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HSV ";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnSaveHSV
            // 
            this.btnSaveHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveHSV.Location = new System.Drawing.Point(924, 582);
            this.btnSaveHSV.Name = "btnSaveHSV";
            this.btnSaveHSV.Size = new System.Drawing.Size(243, 66);
            this.btnSaveHSV.TabIndex = 11;
            this.btnSaveHSV.Text = "Сохранить результат";
            this.btnSaveHSV.UseVisualStyleBackColor = true;
            this.btnSaveHSV.Click += new System.EventHandler(this.btnSaveHSV_Click);
            // 
            // labelValueValue
            // 
            this.labelValueValue.AutoSize = true;
            this.labelValueValue.Location = new System.Drawing.Point(892, 329);
            this.labelValueValue.Name = "labelValueValue";
            this.labelValueValue.Size = new System.Drawing.Size(99, 20);
            this.labelValueValue.TabIndex = 10;
            this.labelValueValue.Text = "Яркость: 0";
            this.labelValueValue.Click += new System.EventHandler(this.labelValueValue_Click);
            // 
            // labelSaturationValue
            // 
            this.labelSaturationValue.AutoSize = true;
            this.labelSaturationValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSaturationValue.Location = new System.Drawing.Point(494, 329);
            this.labelSaturationValue.Name = "labelSaturationValue";
            this.labelSaturationValue.Size = new System.Drawing.Size(155, 20);
            this.labelSaturationValue.TabIndex = 9;
            this.labelSaturationValue.Text = "Насыщенность: 0";
            this.labelSaturationValue.Click += new System.EventHandler(this.labelSaturationValue_Click);
            // 
            // labelHueValue
            // 
            this.labelHueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHueValue.Location = new System.Drawing.Point(113, 329);
            this.labelHueValue.Name = "labelHueValue";
            this.labelHueValue.Size = new System.Drawing.Size(163, 33);
            this.labelHueValue.TabIndex = 8;
            this.labelHueValue.Text = "Оттенок: 0° ";
            this.labelHueValue.Click += new System.EventHandler(this.labelHueValue_Click);
            // 
            // trackValue
            // 
            this.trackValue.Location = new System.Drawing.Point(793, 363);
            this.trackValue.Maximum = 180;
            this.trackValue.Minimum = -180;
            this.trackValue.Name = "trackValue";
            this.trackValue.Size = new System.Drawing.Size(300, 56);
            this.trackValue.TabIndex = 7;
            this.trackValue.TickFrequency = 30;
            this.trackValue.Scroll += new System.EventHandler(this.trackHSV_Scroll);
            // 
            // trackSaturation
            // 
            this.trackSaturation.Location = new System.Drawing.Point(430, 363);
            this.trackSaturation.Maximum = 100;
            this.trackSaturation.Minimum = -100;
            this.trackSaturation.Name = "trackSaturation";
            this.trackSaturation.Size = new System.Drawing.Size(300, 56);
            this.trackSaturation.TabIndex = 6;
            this.trackSaturation.TickFrequency = 20;
            this.trackSaturation.Scroll += new System.EventHandler(this.trackHSV_Scroll);
            // 
            // trackHue
            // 
            this.trackHue.Location = new System.Drawing.Point(20, 363);
            this.trackHue.Maximum = 180;
            this.trackHue.Minimum = -180;
            this.trackHue.Name = "trackHue";
            this.trackHue.Size = new System.Drawing.Size(300, 56);
            this.trackHue.TabIndex = 4;
            this.trackHue.TickFrequency = 30;
            this.trackHue.Scroll += new System.EventHandler(this.trackHSV_Scroll);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(730, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Результат";
            this.label14.Click += new System.EventHandler(this.label14_Click_1);
            // 
            // pictureResultHSV
            // 
            this.pictureResultHSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureResultHSV.Location = new System.Drawing.Point(621, 70);
            this.pictureResultHSV.Name = "pictureResultHSV";
            this.pictureResultHSV.Size = new System.Drawing.Size(300, 240);
            this.pictureResultHSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureResultHSV.TabIndex = 2;
            this.pictureResultHSV.TabStop = false;
            this.pictureResultHSV.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelOriginalHSV
            // 
            this.labelOriginalHSV.AutoSize = true;
            this.labelOriginalHSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOriginalHSV.Location = new System.Drawing.Point(245, 34);
            this.labelOriginalHSV.Name = "labelOriginalHSV";
            this.labelOriginalHSV.Size = new System.Drawing.Size(205, 20);
            this.labelOriginalHSV.TabIndex = 1;
            this.labelOriginalHSV.Text = "Исходное изображение";
            this.labelOriginalHSV.Click += new System.EventHandler(this.label14_Click);
            // 
            // pictureOriginalHSV
            // 
            this.pictureOriginalHSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureOriginalHSV.Location = new System.Drawing.Point(195, 70);
            this.pictureOriginalHSV.Name = "pictureOriginalHSV";
            this.pictureOriginalHSV.Size = new System.Drawing.Size(300, 240);
            this.pictureOriginalHSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOriginalHSV.TabIndex = 0;
            this.pictureOriginalHSV.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 793);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDifference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGray2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGray1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginalGray)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginalRGB)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResultHSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginalHSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureDifference;
        private System.Windows.Forms.PictureBox pictureGray2;
        private System.Windows.Forms.PictureBox pictureGray1;
        private System.Windows.Forms.PictureBox pictureOriginalGray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHistGray2;
        private System.Windows.Forms.Panel panelHistGray1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.PictureBox pictureBlue;
        private System.Windows.Forms.PictureBox pictureGreen;
        private System.Windows.Forms.PictureBox pictureRed;
        private System.Windows.Forms.PictureBox pictureOriginalRGB;
        private System.Windows.Forms.Panel panelHistRed;
        private System.Windows.Forms.Button btnRGB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelHistBlue;
        private System.Windows.Forms.Panel panelHistGreen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureOriginalHSV;
        private System.Windows.Forms.Label labelOriginalHSV;
        private System.Windows.Forms.PictureBox pictureResultHSV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackHue;
        private System.Windows.Forms.TrackBar trackSaturation;
        private System.Windows.Forms.Label labelHueValue;
        private System.Windows.Forms.TrackBar trackValue;
        private System.Windows.Forms.Label labelValueValue;
        private System.Windows.Forms.Label labelSaturationValue;
        private System.Windows.Forms.Button btnSaveHSV;
    }
}

