using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Ships {
    public class AircraftCarrier : Warship{
        public int numOfPlanes { get; set; }

        public int planeWeight { get; set; }

        public override string getInfo() => "Название: " + name + "\r\nВместимость: " + capacity + "\r\nТекущая загрженность: " + currentCargo + "\r\nКоличество орудий: " + numOfGuns + "\r\nВес боеприпаса: " + projectileWeight 
            + "\r\nКоличество самолетов: " + numOfPlanes + "\r\nВес самолета: " + planeWeight;

        public AircraftCarrier() {
            name = "";
            capacity = 0;
            currentCargo = 0;
            numOfGuns = 0;
            projectileWeight = 0;
            numOfPlanes = 0;
            planeWeight = 0;
        }

        public bool canLaunchPlane() => numOfPlanes > 0;

        public string launchPlane() {
            if (canLaunchPlane()) {
                numOfPlanes--;
                return "Запуск!";
            }
            else {
                return "Нет самолетов. Запуск невозможен";
            }
        }

        public bool canLandPlane() => currentCargo + planeWeight <= capacity;

        public string landPlane() {
            if (canLandPlane()) {
                numOfPlanes++;
                currentCargo += planeWeight;
                return "Самолет принят";
            }
            else {
                return "Опасность перегрузки! Посадка невозможна";
            }
        }
    }
}
