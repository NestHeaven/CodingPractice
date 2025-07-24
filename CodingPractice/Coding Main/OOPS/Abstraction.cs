namespace Coding_Main.OOPS
{

    // Abstraction → Hides implementation details and shows only necessary functionality(e.g., abstract classes, interfaces).

    //The user of IMessageService does not care how Send is implemented.

    //Tomorrow you can create SmsService without changing existing code.


    public interface INotificationService
    {
        public abstract void SendNotification();
    }
    public class EmailService : INotificationService
    {
        public void SendNotification()
        {
            Console.WriteLine("Email Notification Send");
        }
    }
}
