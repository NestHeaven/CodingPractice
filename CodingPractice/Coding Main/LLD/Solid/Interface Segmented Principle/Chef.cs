namespace Coding_Main.LLD.Solid.Interface_Segmented_Principle
{
    public interface RestaurantEmployee
    {
        void WashDishes();
        void ServeFood();
        void Cook();
    }


    // This class voilates Interface Segmented Principle as Waiter class does not have implementation for Cook & WashDishes Method

    public class Waiter : RestaurantEmployee
    {
        public void Cook()
        {
            Console.WriteLine("I can not cook");
        }

        public void ServeFood()
        {
            Console.WriteLine("I can serve food");
        }

        public void WashDishes()
        {
            Console.WriteLine("I can not wash dishes");
        }
    }


    // Interface should be such that base class should not implement unnecessary methods

    // How to fix this


    public interface IWaiter
    {

    }

    public class WaiterEmployee : IWaiter
    {

    }

    public interface ICook
    {

    }


    public class CookEmployee : ICook {
    }

    // So here divided the interfaces so that specific class inherit specific interfaces. 

}
