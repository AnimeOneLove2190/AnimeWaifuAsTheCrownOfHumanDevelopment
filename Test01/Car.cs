﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    class Car : Transport
    {
        public int Сonsumption { get; set; }
        public override string GetInfo()
        {
            return $"Мой владелец: {Owner}. Моя скорость: {Speed} км/ч. Мой расход: {Сonsumption} л на 100 км ";
        }
    }
}