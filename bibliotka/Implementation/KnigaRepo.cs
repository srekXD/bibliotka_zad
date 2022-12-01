using bibliotka.Abstract;
using bibliotka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotka.Implementation
{
    internal class KnigaRepo : IRepository<Kniga>

    {
        private readonly Dbcontext db;
        public KnigaRepo(Dbcontext context)
        {
            db = context;
        }
        public void Iztri(Kniga v)
        {
            db.Knigas.Remove(v);
            db.SaveChanges();
        }

        public void Obnovi(Kniga v)
        {
            db.Entry(v).CurrentValues.SetValues(v);
            db.SaveChanges();
        }

        public void Sazdai(Kniga v)
        {
            db.Knigas.Add(v);
            db.SaveChanges();
        }

        public Kniga VzemiId(int id)
        {
            return db.Knigas.Find(id);
        }
    }
}
