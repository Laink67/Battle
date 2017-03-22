using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seeabattle
{
    class Rasstanovka
    {
        private DataGridView dataGridView1 = new DataGridView();
        int i;
        int j;
        public int[,] Sea = new int [10, 10];
        public int counter_one = 0, counter_two = 0, counter_three = 0, counter_four = 0;
        public int x, y;
        int govnokod;
        

        //Сидоркин
        public void Init(DataGridView dataGridView)
        {
            dataGridView.RowCount = 10;
            
            dataGridView.ColumnCount = 10;

            for ( i = 0; i < 10; i++)
            {
                for( j = 0; j < 10; j++)
                {
                    dataGridView[i, j].Value = 0;
                }

            }
            dataGridView.CellMouseClick += DataGridView1_CellMouseClick;
        }

        //Сидоркин
        public bool Init(DataGridView dataGridView,int[,] Sea)
        {
            bool tmp;
            tmp = true;
            tmp = Int32.TryParse(dataGridView.Rows[i].Cells[j].Value.ToString(), out Sea[i,j]);
            return tmp;
        }

        //Проверка выхода за границы
        public bool Outsize(int x, int y)
        {
            if (((x < 0 | x > 9) || (y < 0 | y > 9)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Проверка суммы элементов, чтобы поставить корабль
        public bool CheckSum(int[] X, int[] Y)
        {
            int sum = 0;
            int i;

            for (i = 0; i < X.Length; i++)
            {
                if (Outsize(X[i], Y[i]))
                {
                    sum = sum + Sea[X[i], Y[i]];
                }
            }

            if (sum == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Проверка расстановки однопалубного корабля
        public bool One(int x, int y)
        {
            int[] X = { x, x - 1, x - 1, x - 1, x, x + 1, x + 1, x + 1, x };   //Координаты строк для проверки
            int[] Y = { y, y - 1, y, y + 1, y + 1, y + 1, y, y - 1, y - 1 };   //Координаты столбцов для проверки

            return CheckSum(X, Y);  //Проверка суммы
        }

        //Проверка расстановки двухпалубного корабля по вертикали
        public bool Two_Vertical(int x, int y)
        {
            int[] X = { x, x - 1,x - 2, x - 2, x - 2, x - 1, x, x + 1, x + 1, x + 1, x, x - 1 };    //Координаты строк для проверки
            int[] Y = { y, y, y - 1, y, y + 1, y + 1, y + 1, y + 1, y, y - 1, y - 1, y - 1 };   //Координаты столбцов для проверки

            return CheckSum(X, Y) & Outsize(x, y) & Outsize(x - 1, y);  //Проверка суммы и выхода корабля за границы поля (проверяются начало и конец корабля)
        }

        //Проверка расстановки двухпалубного корабля по горизонтали
        public bool Two_Horizontal(int x, int y)
        {
            int[] X = { x, x, x - 1, x - 1, x - 1, x - 1, x, x + 1, x + 1, x + 1, x + 1, x };   //Координаты строк для проверки
            int[] Y = { y, y + 1, y - 1, y, y + 1, y + 2, y + 2, y + 2, y + 2, y + 1, y, y - 1, y - 1 };    //Координаты столбцов для проверки

            return CheckSum(X, Y) & Outsize(x, y) & Outsize(x, y + 1);  //Проверка суммы и выхода корабля за границы поля (проверяются начало и конец корабля)
        }

        //Проверка расстановки трехпалубного корабля по вертикали
        public bool Three_Vertical(int x, int y)
        {
            int[] X = { x, x - 1, x - 2, x - 3, x - 3, x - 3, x - 2, x - 1, x, x + 1, x + 1, x + 1, x, x - 1, x - 2 };  //Координаты строк для проверки
            int[] Y = { y, y, y, y - 1, y, y + 1, y + 1, y + 1, y + 1, y + 1, y, y - 1, y - 1, y - 1, y - 1 };  //Координаты столбцов для проверки

            return CheckSum(X, Y) & Outsize(x, y) & Outsize(x - 2, y);  //Проверка суммы и выхода корабля за границы поля (проверяются начало и конец корабля)
        }

        //Проверка расстановки трехпалубного корабля по горизонтали
        public bool Three_Horizontal(int x, int y)
        {
            int[] X = { x, x, x, x - 1, x - 1, x - 1, x - 1, x - 1, x, x + 1, x + 1, x + 1, x + 1, x + 1, x };  //Координаты строк для проверки
            int[] Y = { y, y + 1, y + 2, y - 1, y, y + 1, y + 2, y + 3, y + 3, y + 3, y + 2, y + 1, y, y - 1, y - 1 };  //Координаты столбцов для проверки

            return CheckSum(X, Y) & Outsize(x, y) & Outsize(x, y + 2);  //Проверка суммы и выхода корабля за границы поля (проверяются начало и конец корабля)
        }

        //Проверка расстановки четырехпалубного корабля по вертикали
        public bool Four_Vertical(int x, int y)
        {
            int[] X = { x, x - 1, x - 2, x - 3, x - 4, x - 4, x - 4, x - 3, x - 2, x - 1, x, x + 1, x + 1, x + 1, x, x - 1, x - 2, x - 3 }; //Координаты строк для проверки
            int[] Y = { y, y, y, y, y - 1, y, y + 1, y + 1, y + 1, y + 1, y + 1, y + 1, y, y - 1, y - 1, y - 1, y - 1, y - 1 }; //Координаты столбцов для проверки

            return CheckSum(X, Y) & Outsize(x, y) & Outsize(x - 3, y);  //Проверка суммы и выхода корабля за границы поля (проверяются начало и конец корабля)
        }

        //Проверка расстановки четырехпалубного корабля по горизонтали
        public bool Four_Horizontal(int x, int y)
        {
            int[] X = { x, x, x, x, x - 1, x - 1, x - 1, x - 1, x - 1, x - 1, x, x + 1, x + 1, x + 1, x + 1, x + 1, x + 1, x }; //Координаты строк для проверки
            int[] Y = { y, y + 1, y + 2, y + 3, y - 1, y, y + 1, y + 2, y + 3, y + 4, y + 4, y + 4, y + 3, y + 2, y + 1, y, y - 1, y - 1 }; //Координаты столбцов для проверки

            return CheckSum(X, Y) & Outsize(x, y) & Outsize(x, y + 3);  //Проверка суммы и выхода корабля за границы поля (проверяются начало и конец корабля)
        }

        //Проверка счетчика однопалубных кораблей
        public bool CounterOne()
        {
            if (counter_one >= 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Проверка счетчика двухпалубных кораблей
        public bool CounterTwo()
        {
            if (counter_one >= 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Проверка счетчика трехпалубных кораблей
        public bool CounterThree()
        {
            if (counter_one >= 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Проверка счетчика четырехпалубных кораблей
        public bool CounterFour()
        {
            if (counter_one >= 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Отображение корабля; X и Y - координаты корабля; Ship - тип корабля
        public void DisplayShip(int[] X, int[] Y, int Ship)
        {
            if (X.Length == Y.Length)   //Проверка на правильность введенных точек
            {
                for (i = 0; i < X.Length; i++)
                {
                    Sea[X[i], Y[i]] = Ship;
                }
            }
        }

        //Отображение однопалубного корабля
        public void DisplayOne()
        {
            if (One(x, y))
            {
                int[] X = { x };
                int[] Y = { y };

                DisplayShip(X, Y, 1);
            }
        }
        //Отображение двухпалубного корабля по вертикали
        public void DisplayTwoVertical()
        {
            if (Two_Vertical(x, y))
            {
                int[] X = { x, x - 1 };
                int[] Y = { y, y };

                DisplayShip(X, Y, 2);
            }
        }
        //Отображение двухпалубного корабля по горизонтали
        public void DisplayTwoHorizontal()
        {
            if (Two_Vertical(x, y))
            {
                int[] X = { x, x };
                int[] Y = { y, y + 1 };

                DisplayShip(X, Y, 2);
            }
        }
        //Отображение трехпалубного корабля по вертикали
        public void DisplayThreeVertical()
        {
            if (Two_Vertical(x, y))
            {
                int[] X = { x, x - 1, x - 2 };
                int[] Y = { y, y, y };

                DisplayShip(X, Y, 3);
            }
        }
        //Отображение трехпалубного корабля по горизонтали
        public void DisplayThreeHorizontal()
        {
            if (Two_Vertical(x, y))
            {
                int[] X = { x, x, x };
                int[] Y = { y, y + 1, y + 2 };

                DisplayShip(X, Y, 3);
            }
        }
        //Отображение четырехпалубного корабля по вертикали
        public void DisplayFourVertical()
        {
            if (Two_Vertical(x, y))
            {
                int[] X = { x, x - 1, x - 2, x - 3 };
                int[] Y = { y, y, y, y };

                DisplayShip(X, Y, 4);
            }
        }
        //Отображение четырехпалубного корабля по горизонтали
        public void DisplayFourHorizontal()
        {
            if (Two_Vertical(x, y))
            {
                int[] X = { x, x, x, x };
                int[] Y = { y, y + 1, y + 2, y + 3 };

                DisplayShip(X, Y, 4);
            }
        }

        //Получаем координаты при клике на кнопку DataGridView
        public void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x = e.RowIndex;
            int y = e.ColumnIndex;       
        }
    } 
}

