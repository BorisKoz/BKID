using EditDistanceProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace HT
{
    public partial class Form3 : Form2
    {
        public Form3()
        {
            InitializeComponent();
        }
        // взятые из методички методи разбиения массива на подмассивы для каждого потока
        public class MinMax
        {
            public int Min { get; set; }
            public int Max { get; set; }
            public MinMax(int pmin, int pmax) { this.Min = pmin; this.Max = pmax; }
        }
      
        public static List<MinMax> DivideSubArrays(int beginIndex, int endIndex, int subArraysCount)
        {
            List<MinMax> result = new List<MinMax>();
            if ((endIndex - beginIndex) <= subArraysCount)
            {
                result.Add(new MinMax(0, (endIndex - beginIndex)));
            }
            else
            {
           
                int delta = (endIndex - beginIndex) / subArraysCount;
                int currentBegin = beginIndex;
                while ((endIndex - currentBegin) >= 2 * delta)
                {
                    result.Add(new MinMax(currentBegin, currentBegin + delta));
                    currentBegin += delta;
                }
                result.Add(new MinMax(currentBegin, endIndex));
            }
            return result;
        }
      

        private void search_threads_Click(object sender, EventArgs e)
        {
            if (int.Parse(thread_count.Text) == 0)
            {
                MessageBox.Show("введите количество потоков");
            }
            else
            {
                string word = this.word_input.Text.Trim();
                if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
                {
                    Stopwatch timer = new Stopwatch();
                    timer.Start();
                    // переход в верхний регистр
                    string word_upregist = word.ToUpper();
                    List<string> words_result = new List<string>();
                    // поиск в списке
                    List<MinMax> arrayDivList = DivideSubArrays(0, list.Count, int.Parse(thread_count.Text));
                    int count = arrayDivList.Count;
                    Task[] tasks = new Task[count];
                    for (int i = 0; i < count; i++)
                    {
                        //создание тасков
                        List<string> tasklist = list.GetRange(arrayDivList[i].Min, arrayDivList[i].Max - arrayDivList[i].Min);
                        tasks[i] = new Task(() =>
                                            {
                                                foreach (string str in tasklist)
                                                {
                                                    if (str.ToUpper().Contains(word_upregist))
                                                    {
                                                        words_result.Add(str);
                                                    }
                                                }
                                            }
                        );
                        tasks[i].Start();
                    }
                    Task.WaitAll(tasks);
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

        private void search_distance_threads_Click(object sender, EventArgs e)
        {
            if (int.Parse(thread_count.Text) == 0)
            {
                MessageBox.Show("введите количество потоков");
            }
            else
            {
                string word = this.word_input.Text.Trim();
                if (!string.IsNullOrWhiteSpace(word) && list.Count > 0)
                {
                    Stopwatch timer = new Stopwatch();
                    timer.Start();
                    // переход в верхний регистр
                    string word_upregist = word.ToUpper();
                    List<string> words_result = new List<string>();
                    // поиск в списке
                    List<MinMax> arrayDivList = DivideSubArrays(0, list.Count, int.Parse(thread_count.Text));
                    int count = arrayDivList.Count;
                    Task[] tasks = new Task[count];
                    for (int i = 0; i < count; i++)
                    {
                        //создание тасков
                        List<string> tasklist = list.GetRange(arrayDivList[i].Min, arrayDivList[i].Max - arrayDivList[i].Min);
                        tasks[i] = new Task(() =>
                                            {
                                                foreach (string str in tasklist)
                                                {
                                                    // сравнение расстояния и добавление
                                                    if (EditDistance.Distance(word_upregist, str.ToUpper()) <= int.Parse(distance_box.Text))
                                                    {
                                                        words_result.Add(str);
                                                    }
                                                }
                                            }
                        );
                        tasks[i].Start();
                    }
                    Task.WaitAll(tasks);
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
}
