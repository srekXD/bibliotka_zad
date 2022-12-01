using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotka.Abstract
{
    internal interface IRepository <T> where T : class
    {
        T VzemiId(int id);
        void Sazdai(T v);
        void Iztri(T v);
        void Obnovi(T v);
    }
}
