using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;
using EditDistanceProject;

namespace WindowsFormsApp2
{
    
    public partial class Form2 : WindowsFormsApp1.Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = this.word_input.Text.Trim();

            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                // к верхнему
                string word_upregist = word.ToUpper();
                List<string> words_result = new List<string>();
                Stopwatch timer = new Stopwatch();
                timer.Start();
                foreach (string str in list)
                {
                    // сравнение расстояния и добавление
                    if (EditDistance.Distance(word_upregist, str.ToUpper()) <= int.Parse(distance_box.Text))
                    {
                        words_result.Add(str);
                    }  
                }
                timer.Stop();
                this.search_time.Text = timer.Elapsed.ToString();
                // вывод результатов
                this.result_box.BeginUpdate();
                this.result_box.Items.Clear();
                foreach (string str in words_result)
                {
                    this.result_box.Items.Add(str);
                }
                this.result_box.EndUpdate();
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
            }
        }
    }
}
