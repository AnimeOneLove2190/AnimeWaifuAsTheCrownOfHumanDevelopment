using System;

namespace Test02Feature531
{
    class Program
    {
        static void Main(string[] args)
        {
            DesktopComputer desktop = new DesktopComputer();
            desktop.Model = "TopComp LP 111902013";
            desktop.VideoCard = "AMD Radeon R2";
            desktop.RAM = 1;
            desktop.CPU = "AMD E1 6010";
            desktop.TypeOfShell = TypeOfShell.Vertical;
            desktop.BodyMaterial = BodyMaterial.Plastic;
            Console.WriteLine(desktop.GetInfo());
            Monoblock monoblock = new Monoblock();
            monoblock.Model = "Lenovo C20-05";
            monoblock.VideoCard = "AMD Radeon R2";
            monoblock.RAM = 4;
            monoblock.CPU = "AMD E1-6010";
            monoblock.BodyMaterial = BodyMaterial.Plastic;
            monoblock.ScreenDiagonal = 19.5;
            monoblock.Webcam = true;
            Console.WriteLine(monoblock.GetInfo());
            Laptop veteranOfLabourran = new Laptop();
            veteranOfLabourran.Model = "Lenovo B590";
            veteranOfLabourran.VideoCard = "NVIDIA GeForce GT 720M";
            veteranOfLabourran.RAM = 8;
            veteranOfLabourran.CPU = "Intel(R) Core(TM) i5-3230M";
            veteranOfLabourran.BodyMaterial = BodyMaterial.Plastic;
            veteranOfLabourran.Webcam = true;
            veteranOfLabourran.BatteryCapacity = 202;
            Console.WriteLine(veteranOfLabourran.GetInfo());
        }
    }
}
