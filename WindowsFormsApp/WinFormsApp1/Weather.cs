using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// БУДТЕ ВНИМАТЕЛЬНЕЕ: ТУТ ДОЛЖЕН СТОЯТЬ ТОТ ЖЕ namespace что и в Program.cs
namespace WinFormsApp1
{
    public class Sun
    {
        public int temperature=0;
        public int altitudeAboveHorizon=0;
        public bool presenceOfBreeze=false;
    }

    public class Rain
    {
        public int temperature = 0;
        public int precipitationAmount = 0;
        public bool rainbowPresence = false;
        public bool stormPresence = false;
    }

    public enum snowType {small, flakes, moist};

    public class Snow
    {
        public int temperature=0;
        public snowType type = snowType.small;
        public int snowdriftHeight = 0;
    }
}