using bibliotka.Abstract;
using bibliotka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotka.Implementation
{
    internal class KnigiMqstoRepo : IRepository<KnigiMqsto>
    {
        private readonly Dbcontext db;
        public KnigiMqstoRepo(Dbcontext context)
        {
            db = context;
        }
        public void Iztri(KnigiMqsto v)
        {
            db.KnigiMqstos.Remove(v);
            db.SaveChanges();
        }

        public void Obnovi(KnigiMqsto v)
        {
            db.Entry(v).CurrentValues.SetValues(v);
            db.SaveChanges();
        }

        public void Sazdai(KnigiMqsto v)
        {
            db.KnigiMqstos.Add(v);
            db.SaveChanges();
        }

        public KnigiMqsto VzemiId(int id)
        {
            return db.KnigiMqstos.Find(id);
        }
    }
}
