using System;
using System.Collections.Generic;
using System.Text;

namespace Test02Feature531
{
    class TechnicalService
    {
        public string CheckWebcam(bool webcam)
        {
            if (webcam)
            {
                return "да";
            }
            else
            {
                return "нет";
            }
        }
        public string CheckMaterial(BodyMaterial material)
        {
            if (material == BodyMaterial.Plastic)
            {
                return "пластик";
            }
            if (material == BodyMaterial.Metal)
            {
                return "металл";
            }
            if (material == BodyMaterial.Wood)
            {
                return "дерево";
            }
            return "антивещество";
        }
    }
}
