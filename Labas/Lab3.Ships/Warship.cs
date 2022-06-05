using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Ships {
    public abstract class Warship : IShip {
        public int capacity { get; set; }

        public string name { get; set; }

        public int numOfGuns { get; set; }

        public int projectileWeight { get; set; }

        public int currentCargo { get; set; }

        public bool canLoad(int cargo) => currentCargo + cargo <= capacity;

        public string load(int cargo) {
            if (canLoad(cargo)) {
                currentCargo += cargo;
                return "Припасы загружены";
            }
            else {
                return "Не хватает места под припасы, уменьшите объем загрузки";
            }
        }

        public bool canFireAllGuns() => currentCargo >= numOfGuns * projectileWeight && numOfGuns > 0;

        public string fireAllGuns() {
            if (canFireAllGuns()) {
                currentCargo -= numOfGuns * projectileWeight;
                return "Залп!";
            }
            else {
                return "Не хватает снарядов! Необходима дозагрузка";
            }
        }

        public string getName() => name;

        public abstract string getInfo();
    }
}
