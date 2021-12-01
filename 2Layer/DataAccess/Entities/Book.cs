using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Edition { get; set; }
        public string Publisher { get; set; }
    }
}
