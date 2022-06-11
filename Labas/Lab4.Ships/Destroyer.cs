using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ships {
    public class Destroyer : Warship {
        public int NumOfTorpedoes { get; set; }

        public int TorpedoWeight { get; set; }

        public override string GetInfo() => "Название: " + Name + "\r\nВместимость: " + Capacity + "\r\nТекущая загрженность: " + CurrentCargo + "\r\nКоличество орудий: " + NumOfGuns + "\r\nВес боеприпаса: " + ProjectileWeight
            + "\r\nКоличество торпед: " + NumOfTorpedoes + "\r\nВес торпеды: " + TorpedoWeight;

        public Destroyer() {
            Name = "";
            Capacity = 0;
            CurrentCargo = 0;
            NumOfGuns = 0;
            ProjectileWeight = 0;
            NumOfTorpedoes = 0;
            TorpedoWeight = 0;
        }

        private bool CanLaunchTorpedo() => NumOfTorpedoes > 0;

        public string LaunchTorpedo() {
            if (CanLaunchTorpedo()) {
                NumOfTorpedoes--;
                return "Огонь!";
            }
            else {
                return "Нет торпед. Запуск невозможен";
            }
        }

        private bool CanLoadTorpedo() => CurrentCargo + TorpedoWeight <= Capacity;

        public string LoadTorpedo() {
            if (CanLoadTorpedo()) {
                NumOfTorpedoes++;
                CurrentCargo += TorpedoWeight;
                return "Торпеда погружена";
            }
            else {
                return "Опасность перегрузки! Загрузка невозможна";
            }
        }
    }
}
