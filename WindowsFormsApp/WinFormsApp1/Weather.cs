using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// БУДТЕ ВНИМАТЕЛЬНЕЕ: ТУТ ДОЛЖЕН СТОЯТЬ ТОТ ЖЕ namespace что и в Program.cs
namespace WinFormsApp1
{
    public class Weather
    {
        public int temperature = 0;
        protected static Random rnd = new Random();
        public virtual String GetInfo()
        {
            var outputStr = String.Format("\nТемпература: {0}", this.temperature);
            return outputStr;        
        }
        
    }
    public class Sun : Weather
    {
        
        public int altitudeAboveHorizon=0;
        public bool presenceOfBreeze=false;
        public override String GetInfo()
        {
            var outputStr = "Солнце";
            outputStr += base.GetInfo();
            outputStr += String.Format("\nВысота солнца над горизонтом: {0}", this.altitudeAboveHorizon);
            outputStr += String.Format("\nНаличие свежего ветерка: {0}", this.presenceOfBreeze);
            return outputStr;
        }
        public static Sun Generate()
        {
            return new Sun()
            {
                temperature = rnd.Next() % 35,
                altitudeAboveHorizon = rnd.Next() % 90,
                presenceOfBreeze = rnd.Next() % 2 == 0
            };
        }
    }

    public class Rain : Weather
    {
        
        public int precipitationAmount = 0;
        public bool rainbowPresence = false;
        public bool stormPresence = false;
        public override String GetInfo()
        {
            var outputStr = "Дождь";
            outputStr += base.GetInfo();
            outputStr += String.Format("\nВеличина осадков: {0}", this.precipitationAmount);
            outputStr += String.Format("\nНаличие радуги: {0}", this.rainbowPresence);
            outputStr += String.Format("\nНаличие грозы: {0}", this.stormPresence);
            return outputStr;
        }
        public static Rain Generate()
        {
            return new Rain
            {
                temperature = rnd.Next() % 10,
                precipitationAmount = rnd.Next() % 500,
                rainbowPresence = rnd.Next() % 2 == 0,
                stormPresence = rnd.Next() % 2 == 0
            };
        }
    }

    public enum snowType {small, flakes, moist};

    public class Snow : Weather
    {
       
        public snowType typeOfSnow = snowType.small;
        public int snowdriftHeight = 0;
        public override String GetInfo()
        {
            var outputStr = "Снег";
            outputStr += base.GetInfo();
            outputStr += String.Format("\nТип: {0}", this.typeOfSnow);
            outputStr += String.Format("\nВысота сугробов: {0}", this.snowdriftHeight);
            return outputStr;
        }
        public static Snow Generate() {
            return new Snow
            {
                temperature = (rnd.Next() % 40) * -1,
                typeOfSnow = (snowType)rnd.Next(3),
                snowdriftHeight = rnd.Next() % 100
            };
        }

    }
}