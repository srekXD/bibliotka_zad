using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotka.Models
{
    public class KnigiMqsto
    {
        public int Id { get; set; }
        public int KnigaId { get; set; }
        public string OtdelPisatel { get; set; } //otdel ot a do z 
        public int Red {get; set; }
        public int Nomer { get; set; }
        public List<Kniga> knigi { get; set; }

    }
}
