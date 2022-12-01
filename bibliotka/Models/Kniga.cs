using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotka.Models
{
    public class Kniga
    {
        public Guid KnigaID { get; set; }
        public string Name { get; set; }
        public string Pisatel { get; set; }
        public int Stranici { get; set; }
        public List<KnigiMqsto> KnigiRaftove { get; set; }
        
    }
}
