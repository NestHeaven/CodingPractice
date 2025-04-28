namespace Coding_Main.LLD.Solid.Liskov_s_Substitution_Principle
{
    public class Vehicle
    {
        public virtual void Accelerate()
        {
            Console.WriteLine("It accelerate");
        }
    }

    public class MoterCycle: Vehicle
    {
        public override void Accelerate() {
            Console.WriteLine("Bike can accerate");
        }
    }

    public class Bycycle : Vehicle
    {
        // voilating Lsp (base class should extend the parent class not narrow it down)
        public override void Accelerate()
        {
            throw new NotImplementedException("It can't accelerate");
        }
    }



    //What we can do to follow LSP 


    public class SuperVehicle : Vehicle
    {

    }


    public class NormalVehicle
    {

    }


    // Now the bycycle class can inherit NormalVehicle not Vehicle which follows LSP
}
