using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> list = new List<string>();
        // выбор и чтение
        private void button_read_text_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "текстовые файлы|*.txt";
            if (fd.ShowDialog() == DialogResult.OK)
            {
               // нашли файл
                Stopwatch timer = new Stopwatch();
                timer.Start();
                // прочитали
                string text = File.ReadAllText(fd.FileName, Encoding.GetEncoding(1251));
                char[] separators = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };
                // разбили
                string[] words_list = text.Split(separators);
                foreach (string i in words_list)
                {
                    string str = i.Trim();
                    if (!list.Contains(str)) list.Add(str);
                }
                timer.Stop();
                // вывели время
                this.read_time.Text = timer.Elapsed.ToString();
                MessageBox.Show("Чтение файла завершено.");
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл!");
            }
        }
        // поиск
        private void search_button_Click(object sender, EventArgs e)
        {
            string word = this.word_input.Text.Trim();
            if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                // переход в верхний регистр
                string word_upregist = word.ToUpper();
                List<string> words_upregist = new List<string>();
                // поиск в списке
                foreach (string i in list)
                {
                    if (i.ToUpper().Contains(word_upregist))
                    {
                        words_upregist.Add(i);
                    }
                }
                timer.Stop();
                this.search_time.Text = timer.Elapsed.ToString();
                // вывод результатов
                this.result_box.BeginUpdate();
                    this.result_box.Items.Clear();
                    foreach (string str in words_upregist)
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
        // закрытие
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
