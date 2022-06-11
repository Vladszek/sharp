using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ships {
    public class SpaceDreadnought : Warship {

        public int MaxAltitude { get; set; }

        public int CurrentAltitude { get; set; }

        public override string GetInfo() => "Название: " + Name + "\r\nВместимость: " + Capacity + "\r\nТекущая загрженность: " + CurrentCargo + "\r\nКоличество орудий: " + NumOfGuns + "\r\nВес боеприпаса: " + ProjectileWeight
            + "\r\nМаксимальная высота полета: " + MaxAltitude + "\r\nТекущая высота полета: " + CurrentAltitude;

        public SpaceDreadnought() {
            Name = "";
            Capacity = 0;
            CurrentCargo = 0;
            NumOfGuns = 0;
            ProjectileWeight = 0;
            MaxAltitude = 0;
            CurrentAltitude = 0;
        }

        private bool CanGainAltitude(int height) => CurrentAltitude + height <= MaxAltitude;

        public string GainAltitude(int height) {
            if (CanGainAltitude(height)) {
                CurrentAltitude += height;
                return "Высота набрана!";
            }
            else {
                return "Высота превысит максимальную, подъем невозможен!";
            }
        }
    }
}
