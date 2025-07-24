namespace Coding_Main.OOPS
{
    public  class Encapsulation
    {
        private string Name;

        private Logger logger;
        public Encapsulation() => logger = new Logger();

        // Here encapsualation comes in Play. We have a controlled access to the private propery, So its not

        // accessible from outside and a public property with the controlled setter which can prevent and validate

        // the value before assigning or we can do something before returning value

        public string MyProperty { get { logger.ConsoleMessage("Accessed Name"); return Name; }
            set {
                if(!String.IsNullOrEmpty(value)){
                    Name = value;
                }
            }
        }
    }


    public class Logger
    {
        public void ConsoleMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
