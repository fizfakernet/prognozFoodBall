using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Peaople
{
    class Results
    {
        public double home = 0;//вероятность выйгрыша хозяев
        public double guest = 0;//вероятность выйгрыша гостей
        public double friend = 0;//вероятность выйгрыша ничьей
        public double not_interval = 0;//вероятность выхода за интервал голов

        public double sumDiff(Results res)
        {
            double ret = 0;
            ret += Math.Abs(this.home - res.home);
            ret += Math.Abs(this.guest - res.guest);
            ret += Math.Abs(this.friend - res.friend);
            ret += Math.Abs(this.not_interval - res.not_interval);

            return ret;
        }
    }
}
