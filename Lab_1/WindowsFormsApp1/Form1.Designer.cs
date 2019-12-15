namespace WindowsFormsApp1
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
            this.button_read_text = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.red_time_label = new System.Windows.Forms.Label();
            this.read_time = new System.Windows.Forms.Label();
            this.search_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.word_input = new System.Windows.Forms.TextBox();
            this.result_box = new System.Windows.Forms.ListBox();
            this.search_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_read_text
            // 
            this.button_read_text.Location = new System.Drawing.Point(12, 26);
            this.button_read_text.Name = "button_read_text";
            this.button_read_text.Size = new System.Drawing.Size(189, 70);
            this.button_read_text.TabIndex = 0;
            this.button_read_text.Text = "Найти файл";
            this.button_read_text.UseVisualStyleBackColor = true;
            this.button_read_text.Click += new System.EventHandler(this.button_read_text_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.time_label.Location = new System.Drawing.Point(9, 127);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(77, 13);
            this.time_label.TabIndex = 1;
            this.time_label.Text = "Время чтения";
            // 
            // red_time_label
            // 
            this.red_time_label.AutoSize = true;
            this.red_time_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.red_time_label.Location = new System.Drawing.Point(12, 330);
            this.red_time_label.Name = "red_time_label";
            this.red_time_label.Size = new System.Drawing.Size(79, 13);
            this.red_time_label.TabIndex = 2;
            this.red_time_label.Text = "Время поиска";
            // 
            // read_time
            // 
            this.read_time.AutoSize = true;
            this.read_time.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.read_time.Location = new System.Drawing.Point(107, 127);
            this.read_time.Name = "read_time";
            this.read_time.Size = new System.Drawing.Size(0, 13);
            this.read_time.TabIndex = 3;
            // 
            // search_time
            // 
            this.search_time.AutoSize = true;
            this.search_time.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.search_time.Location = new System.Drawing.Point(113, 330);
            this.search_time.Name = "search_time";
            this.search_time.Size = new System.Drawing.Size(0, 13);
            this.search_time.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "слово для поиска";
            // 
            // word_input
            // 
            this.word_input.Location = new System.Drawing.Point(149, 209);
            this.word_input.Name = "word_input";
            this.word_input.Size = new System.Drawing.Size(132, 20);
            this.word_input.TabIndex = 6;
            // 
            // result_box
            // 
            this.result_box.FormattingEnabled = true;
            this.result_box.Location = new System.Drawing.Point(318, 127);
            this.result_box.Name = "result_box";
            this.result_box.Size = new System.Drawing.Size(261, 290);
            this.result_box.TabIndex = 7;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(149, 235);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(60, 23);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "найти";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.result_box);
            this.Controls.Add(this.word_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_time);
            this.Controls.Add(this.read_time);
            this.Controls.Add(this.red_time_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.button_read_text);
            this.Name = "Form1";
            this.Text = "Lab_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label red_time_label;
        private System.Windows.Forms.Label read_time;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button search_button;
        protected System.Windows.Forms.Button button_read_text;
        protected System.Windows.Forms.TextBox word_input;
        protected System.Windows.Forms.ListBox result_box;
        protected System.Windows.Forms.Label search_time;
    }
}

