namespace _4Peaople
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
            this.timeToEnd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numH = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.interval_stop = new System.Windows.Forms.NumericUpDown();
            this.interval_start = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownIterac = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeToEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterac)).BeginInit();
            this.SuspendLayout();
            // 
            // timeToEnd
            // 
            this.timeToEnd.Location = new System.Drawing.Point(169, 28);
            this.timeToEnd.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.timeToEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeToEnd.Name = "timeToEnd";
            this.timeToEnd.Size = new System.Drawing.Size(38, 20);
            this.timeToEnd.TabIndex = 0;
            this.timeToEnd.Tag = "";
            this.timeToEnd.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "время до окончания игры";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // numH
            // 
            this.numH.Location = new System.Drawing.Point(147, 54);
            this.numH.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numH.Name = "numH";
            this.numH.Size = new System.Drawing.Size(28, 20);
            this.numH.TabIndex = 2;
            this.numH.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(181, 54);
            this.numG.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(29, 20);
            this.numG.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "счёт: Хозяева - Гости";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "интервал голов";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // interval_stop
            // 
            this.interval_stop.Location = new System.Drawing.Point(181, 81);
            this.interval_stop.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.interval_stop.Name = "interval_stop";
            this.interval_stop.Size = new System.Drawing.Size(29, 20);
            this.interval_stop.TabIndex = 6;
            this.interval_stop.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.interval_stop.ValueChanged += new System.EventHandler(this.NumericUpDown3_ValueChanged);
            // 
            // interval_start
            // 
            this.interval_start.Location = new System.Drawing.Point(147, 81);
            this.interval_start.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.interval_start.Name = "interval_start";
            this.interval_start.Size = new System.Drawing.Size(28, 20);
            this.interval_start.TabIndex = 5;
            this.interval_start.ValueChanged += new System.EventHandler(this.NumericUpDown4_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "расчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxOut
            // 
            this.textBoxOut.Location = new System.Drawing.Point(28, 138);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(311, 119);
            this.textBoxOut.TabIndex = 9;
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(345, 138);
            this.textBoxTest.Multiline = true;
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(311, 119);
            this.textBoxTest.TabIndex = 11;
            this.textBoxTest.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(345, 109);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 10;
            this.buttonTest.Text = "проверить";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "количество итерации";
            // 
            // numericUpDownIterac
            // 
            this.numericUpDownIterac.Location = new System.Drawing.Point(486, 86);
            this.numericUpDownIterac.Maximum = new decimal(new int[] {
            32000000,
            0,
            0,
            0});
            this.numericUpDownIterac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIterac.Name = "numericUpDownIterac";
            this.numericUpDownIterac.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownIterac.TabIndex = 12;
            this.numericUpDownIterac.Tag = "";
            this.numericUpDownIterac.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "исходное рапределение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 273);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownIterac);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textBoxOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.interval_stop);
            this.Controls.Add(this.interval_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numG);
            this.Controls.Add(this.numH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeToEnd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.timeToEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interval_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown timeToEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numH;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown interval_stop;
        private System.Windows.Forms.NumericUpDown interval_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownIterac;
        private System.Windows.Forms.Button button2;
    }
}

