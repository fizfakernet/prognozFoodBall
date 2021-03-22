using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Peaople
{
    class TabStat
    {
        private double[,] tab;
        private double nH; // вероятность забития гола за одну минуту для хозяев
        private double nG; // вероятность забития гола за одну минуту для гостей
        private double sredH;
        private double sredG;
        private Results results;
        public TabStat()
        {
            results = new Results();
            tab = new double[7, 6] {
                { 4.33, 6.05, 4.24, 1.98, 0.70, 0.19 },
                { 7.57,10.59, 7.41, 3.46, 1.21, 0.34 },
                { 6.62, 9.27, 6.48, 3.03, 1.06, 0.29 },
                { 3.86, 5.41, 3.78, 1.76, 0.62, 0.17 },
                { 1.68, 2.36, 1.65, 0.78, 0.27, 0    },
                { 0.59, 0.83, 0.57, 0.27, 0,    0    },
                { 0.17, 0.24, 0.17, 0,    0,    0    }  };

            double[] home = new double[6];
            sredH = 0;//среднее количество голов, забитое хозяевами за одим матч
            for (int j = 0; j < 6; j++)
            {
                home[j] = 0;
                for (int i = 0; i < 7; i++)
                    home[j] += tab[i, j];
            }
            for (int k = 0; k < 6; k++)
                sredH += k * home[k]*0.01;
            nH = sredH / 90;// вероятность забивания гола хозяевами за каждую минуту

            

            double[] guest = new double[7];
            sredG = 0;//среднее количество голов, забитое гостями за одим матч
            for (int i = 0; i < 7; i++)
            {
                guest[i] = 0;
                for (int j = 0; j < 6; j++)
                    guest[i] += tab[i, j];
            }
            for (int k = 0; k < 7; k++)
                sredG += k * guest[k]*0.01;
            nG = sredG / 90;// вероятность забивания гола гостями за каждую минуту

            //Console.WriteLine("home  " + sredH + "    "+ nH);
            //Console.WriteLine("guest " + sredG + "    " + nG);
        }
        public double getTab(int i, int j)
        {
            if (i > 0 && j > 0 && i < 7 && j < 6)
            {
                return tab[i, j];
            }
            else
            { 
                return 0;
            }
        }
        public double getSummInterval(int a,int b)
        {
            double summ = 0;
            for (int i = 0; i <= b; i++)
                for (int j = 0; j <= b ; j++)
                    if(i<7 && j<6 && i+j>=a && i+j<=b )
                        summ += tab[i, j];
            return summ;
        }
        
        private int fakt(int n)
        {
            int ret = 1;
            for (int i = 1; i <= n; i++)
                ret *= i;
            return ret;
        }/*
        private int binom( int n , int m)
        {
            return fakt(n)/(fakt(m)*fakt(n-m));
        }
        */
        public void pravka (int numH,int numG,int time_to_end)//правка вероятностей на совершившиеся условия
        {
            for (int i = 0; i <= numG; i++)
                for (int j = 0; j <= numH; j++)
                    tab[i, j] = 0;

            // tab[numG, numH] = 1;
            double lyabdaG = nG * time_to_end;
            double lyabdaH = nH * time_to_end; // Приближение распределением Пуассона
            for (int i=numG;i< 7;i++)
                for (int j = numH; j < 6; j++)
                {
                    tab[i, j] = 100
                        * Math.Pow(lyabdaG, i - numG) * Math.Exp(-lyabdaG) / fakt(i - numG)
                        * Math.Pow(lyabdaH, j - numH) * Math.Exp(-lyabdaH) / fakt(j - numH);// вероятность забить необходимое количество голов за оставшееся ввремя
                }
            /*
            for (int i = numH; i < 7; i++)
                for (int j = numG; j < 6; j++)
                {
                    tab[i, j] -= getTab(i+1,j)+getTab(i,j+1)+getTab(i+1,j+1);//вычитаем результаты с большим количеством голов
                }
                */
        }

        public string printTab()
        {
            string ret=null;
            //ret += nH + "   " + nG + Environment.NewLine;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                    ret += tab[i, j] + "          ";
                ret += Environment.NewLine + Environment.NewLine;// + Environment.NewLine + Environment.NewLine;
            }
            return ret;
        }

        public string printResult(int a,int b) // вывод возможных исходов в интервале голов [ a .. b ]
        {
            string ret = null;
            results.home = 0;//вероятность выйгрыша хозяев
            results.guest = 0;//вероятность выйгрыша гостей
            results.friend = 0;//вероятность выйгрыша ничьей
            results.not_interval = 0;//вероятность выхода за интервал голов

            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 6; j++)
                    if ( i + j >= a && i + j <= b)
                    {
                        if(i<j)
                            results.home += tab[i, j];
                        if (i > j)
                            results.guest += tab[i, j];
                        if (i == j)
                            results.friend += tab[i, j];
                    }
                    else
                        results.not_interval += tab[i, j];

            ret = "хозяева выйграют с вероятностью " + results.home + Environment.NewLine +
                  "гости выйграют с вероятностью     " + results.guest + Environment.NewLine +
                  "ничья с вероятностью                      " + results.friend + Environment.NewLine +
                  "не в диапазоне голов                       " + results.not_interval + Environment.NewLine;

            return ret;
        }

        public Results get_results()
        {
            return results;
        }
        private void clearTab()
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 6; j++)
                    tab[i, j] = 0;
        }
        public void monteKarlo(int numH, int numG, int time_to_end,int iterac)
        {
            Random rnd = new Random();
            int porogH = (int)Math.Round( (double)Int32.MaxValue * nH );
            int porogG = (int)Math.Round((double)Int32.MaxValue * nG);
            int h, g;
            double step = 100 / (double)iterac;

            clearTab();
            for (int iter = 0; iter < iterac; iter++)
            {
                h = numH;
                g = numG;
                for(int minute=0;minute< time_to_end;minute++)
                {
                    if (rnd.Next() < porogH) h++;
                    if (rnd.Next() < porogG) g++;
                }
                //Console.WriteLine(h + "    " + g);
                if (h < 6 && g < 7)
                    tab[g, h] += step;
            }

        }
    }
}
