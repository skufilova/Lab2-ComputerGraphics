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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDifference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGray2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGray1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginalGray)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1184, 614);
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
            this.tabPage1.Size = new System.Drawing.Size(1176, 585);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1176, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RGB";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1176, 585);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HSV ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
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
    }
}

