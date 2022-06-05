using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Phones {
    public class FirstPhone {
        public string Brand { get; set; }

        public int Price { get; set; }

        public int Memory { get; set; }

        public FirstPhone() {
            Brand = "";
            Price = 0;
            Memory = 0;
        }

        public FirstPhone(string brand, int price, int memory) {
            Brand = brand;
            Price = price;
            Memory = memory;
        }

        public virtual double quality() => (double)Memory / Price;

        public virtual string displayInfo() => "Марка: " + Brand + "\r\nЦена: " + Price + "\r\nОбъем памяти: " + Memory;
    }
}
