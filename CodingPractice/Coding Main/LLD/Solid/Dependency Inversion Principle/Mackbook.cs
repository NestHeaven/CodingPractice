namespace Coding_Main.LLD.Solid.Dependency_Inversion_Principle
{

    // Dependency Inversion Princple says your class should be dependent of Interfaces rather than concrete class
    public class Mackbook
    {
        //But here Macbook is directly refering to a class (which means when we will make instance of Macbook it will behave like WiredKeyBoard and WiredMouse
        public WiredKeyBoard WiredKeyBoard;
        public WiredMouse WiredMouse;

        public Mackbook(WiredMouse wiredMouse , WiredKeyBoard wiredKeyBoard)
        {
            WiredKeyBoard = wiredKeyBoard;
            WiredMouse = wiredMouse;
        }

    }

    public class WiredKeyBoard
    {

    }

    public class WiredMouse
    {

    }



    //Solution

    // we can create interfaces and Mackbook will now inherit Interfaces rather that concreate class


    public interface IKeyboard
    {

    }

    public class WiredKeyBoardClass : IKeyboard
    {

    }

    public class WireLessKeyBoardClass : IKeyboard { }

    public class MackbookPro
    {

        //So here when we make intance we can define which type keyboard to behave

        // Instance 1 of MackbookPro can be WiredKeyBoardClass
        // Instance 2 of MackbookPro can be WireLessKeyBoardClass
        public IKeyboard Keyboard;

        public MackbookPro(IKeyboard keyboard)
        {
            this.Keyboard = keyboard;
        }
    }
}
