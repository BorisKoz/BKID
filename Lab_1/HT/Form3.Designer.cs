namespace HT
{
    partial class Form3
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
            this.search_threads = new System.Windows.Forms.Button();
            this.search_distance_threads = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.thread_count = new System.Windows.Forms.TextBox();
            this.report_button = new System.Windows.Forms.Button();
            this.distance_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 264);
            this.button1.Text = "Найти с расстоянием";
            // 
            // distance_box
            // 
            this.distance_box.Location = new System.Drawing.Point(88, 293);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(90, 235);
            // 
            // result_box
            // 
            this.result_box.Location = new System.Drawing.Point(388, 127);
            // 
            // search_threads
            // 
            this.search_threads.Location = new System.Drawing.Point(166, 235);
            this.search_threads.Name = "search_threads";
            this.search_threads.Size = new System.Drawing.Size(100, 25);
            this.search_threads.TabIndex = 27;
            this.search_threads.Text = "найти поточно";
            this.search_threads.UseVisualStyleBackColor = true;
            this.search_threads.Click += new System.EventHandler(this.search_threads_Click);
            // 
            // search_distance_threads
            // 
            this.search_distance_threads.Location = new System.Drawing.Point(166, 264);
            this.search_distance_threads.Name = "search_distance_threads";
            this.search_distance_threads.Size = new System.Drawing.Size(182, 23);
            this.search_distance_threads.TabIndex = 28;
            this.search_distance_threads.Text = "Найти с расстоянием поточно";
            this.search_distance_threads.UseVisualStyleBackColor = true;
            this.search_distance_threads.Click += new System.EventHandler(this.search_distance_threads_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Потоки:";
            // 
            // thread_count
            // 
            this.thread_count.Location = new System.Drawing.Point(248, 294);
            this.thread_count.Name = "thread_count";
            this.thread_count.Size = new System.Drawing.Size(100, 20);
            this.thread_count.TabIndex = 30;
            this.thread_count.Text = "1";
            // 
            // report_button
            // 
            this.report_button.Location = new System.Drawing.Point(166, 393);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(75, 23);
            this.report_button.TabIndex = 31;
            this.report_button.Text = "отчёт";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // distance_time
            // 
            this.distance_time.AutoSize = true;
            this.distance_time.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.distance_time.Location = new System.Drawing.Point(157, 363);
            this.distance_time.Name = "distance_time";
            this.distance_time.Size = new System.Drawing.Size(0, 13);
            this.distance_time.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(15, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Время поиска поточно";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.distance_time);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.thread_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_distance_threads);
            this.Controls.Add(this.search_threads);
            this.Name = "Form3";
            this.Text = "Homework";
            this.Controls.SetChildIndex(this.search_time, 0);
            this.Controls.SetChildIndex(this.result_box, 0);
            this.Controls.SetChildIndex(this.button_read_text, 0);
            this.Controls.SetChildIndex(this.word_input, 0);
            this.Controls.SetChildIndex(this.search_button, 0);
            this.Controls.SetChildIndex(this.distance_box, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.search_threads, 0);
            this.Controls.SetChildIndex(this.search_distance_threads, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.thread_count, 0);
            this.Controls.SetChildIndex(this.report_button, 0);
            this.Controls.SetChildIndex(this.distance_time, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search_threads;
        private System.Windows.Forms.Button search_distance_threads;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox thread_count;
        private System.Windows.Forms.Button report_button;
        private System.Windows.Forms.Label distance_time;
        private System.Windows.Forms.Label label4;
    }
}

