﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SparseMatrix
{
    public class Matrix<T>
    {
        /// <summary>
        /// Словарь для хранения значений
        /// </summary>
        Dictionary<string, T> _matrix = new Dictionary<string, T>();

        /// <summary>
        /// Количество элементов по горизонтали (максимальное количество столбцов)
        /// </summary>
        int maxX;

        /// <summary>
        /// Количество элементов по вертикали (максимальное количество строк)
        /// </summary>
        int maxY;

        /// <summary>
        /// Количество элементов в глубину (максимальное количество строк)
        /// </summary>
        int maxZ;

        /// <summary>
        /// Пустой элемент, который возвращается если элемент с нужными координатами не был задан
        /// </summary>
        T nullElement;

        /// <summary>
        /// Конструктор 3D
        /// </summary>
        public Matrix(int px, int py, int pz, T nullElementParam)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.nullElement = nullElementParam;
        }

        /// <summary>
        /// Индексатор для доступа к данным
        /// </summary>
        public T this[int x, int y, int z]
        {
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this._matrix.ContainsKey(key))
                {
                    return this._matrix[key];
                }
                else
                {
                    return this.nullElement;
                }
            }
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this._matrix.Add(key, value);
            }
        }

        /// <summary>
        /// Проверка границ
        /// </summary>
        void CheckBounds(int x, int y, int z)
        {
            if (x < 0 || x >= this.maxX) throw new Exception("x=" + x + " выходит за границы");
            if (y < 0 || y >= this.maxY) throw new Exception("y=" + y + " выходит за границы");
            if (z < 0 || z >= this.maxZ) throw new Exception("y=" + y + " выходит за границы");
        }

        /// <summary>
        /// Формирование ключа
        /// </summary>
        string DictKey(int x, int y, int z)
        {
            return x.ToString() + "_" + y.ToString() + " " + z.ToString();
        }

        /// <summary>
        /// Приведение к строке
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //Класс StringBuilder используется для построения длинных строк
            //Это увеличивает производительность по сравнению с созданием и склеиванием 
            //большого количества обычных строк

            StringBuilder b = new StringBuilder();
            for (int k = 0; k < this.maxZ; k++)
            {
                for (int j = 0; j < this.maxY; j++)
                {
                    for (int i = 0; i < this.maxX; i++)
                    {
                        string key = DictKey(i, j, k);
                        if (this._matrix.ContainsKey(key))
                        {
                            b.Append("(" + i.ToString() + ";" + j.ToString() + ";" + k.ToString() + ") : " + this[i, j, k].ToString() + '\n');
                        }
                    }
                }
            }

            return b.ToString();
        }

    }
}
