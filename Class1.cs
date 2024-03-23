using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleList
{
    internal class Product
    {
        public String name;
        public decimal value;
        public string ID;
        public decimal price;
        public decimal weight;
        public string category;
        public Product? next;
        // O "?" (o sinal de interrogação) serve de "null safe"; garante que o
        // o programa continue operando ainda que o valor seja nulo.
    }
}