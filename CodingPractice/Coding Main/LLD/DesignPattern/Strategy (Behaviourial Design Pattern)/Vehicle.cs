namespace Coding_Main.LLD.DesignPattern.Strategy__Behaviourial_Design_Pattern_
{
    public class Vehicle
    {
        public readonly IDriveStrategy _driveStrategy;

        public Vehicle(IDriveStrategy driveStrategy)
        {
            _driveStrategy = driveStrategy;
        }

        public void DriveVehicle()
        {
            _driveStrategy.Drive();
        }
    }
}
