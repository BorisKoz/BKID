using System;

namespace WindowsFormsApp2
{
    partial class Form2
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
            this.read_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.distance_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(136, 235);
            this.search_button.Size = new System.Drawing.Size(67, 25);
            // 
            // read_time
            // 
            this.read_time.AutoSize = true;
            this.read_time.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.read_time.Location = new System.Drawing.Point(110, 138);
            this.read_time.Name = "read_time";
            this.read_time.Size = new System.Drawing.Size(0, 13);
            this.read_time.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Расстояние";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(450, 63);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(132, 20);
            this.distance.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Рассотяние";
            // 
            // distance_box
            // 
            this.distance_box.Location = new System.Drawing.Point(166, 293);
            this.distance_box.Name = "distance_box";
            this.distance_box.Size = new System.Drawing.Size(100, 20);
            this.distance_box.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Найти с расстоянием:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.distance_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.read_time);
            this.Name = "Form2";
            this.Text = "Lab_5";
            this.Controls.SetChildIndex(this.result_box, 0);
            this.Controls.SetChildIndex(this.button_read_text, 0);
            this.Controls.SetChildIndex(this.word_input, 0);
            this.Controls.SetChildIndex(this.search_button, 0);
            this.Controls.SetChildIndex(this.read_time, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.distance_box, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label read_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.TextBox distance_box;
    }
}

