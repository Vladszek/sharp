using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ships {
    public class AircraftCarrier : Warship {
        public int NumOfPlanes { get; set; }

        public int PlaneWeight { get; set; }

        public override string GetInfo() => "Название: " + Name + "\r\nВместимость: " + Capacity + "\r\nТекущая загрженность: " + CurrentCargo + "\r\nКоличество орудий: " + NumOfGuns + "\r\nВес боеприпаса: " + ProjectileWeight
            + "\r\nКоличество самолетов: " + NumOfPlanes + "\r\nВес самолета: " + PlaneWeight;

        public AircraftCarrier() {
            Name = "";
            Capacity = 0;
            CurrentCargo = 0;
            NumOfGuns = 0;
            ProjectileWeight = 0;
            NumOfPlanes = 0;
            PlaneWeight = 0;
        }

        private bool CanLaunchPlane() => NumOfPlanes > 0;

        public string LaunchPlane() {
            if (CanLaunchPlane()) {
                NumOfPlanes--;
                return "Запуск!";
            }
            else {
                return "Нет самолетов. Запуск невозможен";
            }
        }

        private bool CanLandPlane() => CurrentCargo + PlaneWeight <= Capacity;

        public string LandPlane() {
            if (CanLandPlane()) {
                NumOfPlanes++;
                CurrentCargo += PlaneWeight;
                return "Самолет принят";
            }
            else {
                return "Опасность перегрузки! Посадка невозможна";
            }
        }
    }
}
