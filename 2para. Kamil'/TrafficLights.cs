using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2para._Kamil_
{
    internal struct TrafficLights
    {
        public enum Light { Red, Yellow, Green };

        public Light currentLight;

        public TrafficLights(Light initialLight)
        {
            currentLight = initialLight;
        }

        public Light CurrentLight
        {
            get { return currentLight; }
            set { currentLight = value; }
        }

        public void ChangeLight()
        {
            switch (currentLight)
            {
                case Light.Red:
                    CurrentLight = Light.Green;
                    break;
                case Light.Green:
                    CurrentLight = Light.Yellow;
                    break;
                case Light.Yellow:
                    CurrentLight = Light.Red;
                    break;
            }
        }
        public override string ToString()
        {
            return currentLight.ToString();
        }
    }
}
