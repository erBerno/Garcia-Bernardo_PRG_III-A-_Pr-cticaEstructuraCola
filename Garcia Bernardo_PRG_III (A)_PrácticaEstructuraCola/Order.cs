using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garcia_Bernardo_PRG_III__A__PrácticaEstructuraCola
{
    public class Order
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public Order(int id, string name, int number)
        {
            ID = id;
            Name = name;
            Number = number;
        }
    }
}
