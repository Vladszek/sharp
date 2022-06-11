using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ships {
    public abstract class Warship : IShip {
        public int Capacity { get; set; }

        public string Name { get; set; }

        public int NumOfGuns { get; set; }

        public int ProjectileWeight { get; set; }

        public int CurrentCargo { get; set; }

        public bool CanLoad(int cargo) => CurrentCargo + cargo <= Capacity;

        public string Load(int cargo) {
            if (CanLoad(cargo)) {
                CurrentCargo += cargo;
                return "Припасы загружены";
            }
            else {
                return "Не хватает места под припасы, уменьшите объем загрузки";
            }
        }

        public bool CanFireAllGuns() => CurrentCargo >= NumOfGuns * ProjectileWeight && NumOfGuns > 0;

        public string FireAllGuns() {
            if (CanFireAllGuns()) {
                CurrentCargo -= NumOfGuns * ProjectileWeight;
                return "Залп!";
            }
            else {
                return "Не хватает снарядов! Необходима дозагрузка";
            }
        }

        public string GetName() => Name;

        public abstract string GetInfo();
    }
}
