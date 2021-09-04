using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    class producto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int quantity { get; set; }

        public decimal Price { get; set; }
        public DateTime CaducityDate { get; set; }
    }
}
