namespace Coding_Main.LLD.DesignPattern.Mediator__Behavioural_Design_Pattern_
{
    public class MediatorMain
    {
        public static void Main()
        {
            DialogMediator dialogMediator = new DialogMediator();
            Button b = new Button(dialogMediator);
            TextBox t = new TextBox();

            dialogMediator.textBox = t;
            dialogMediator.button = b;  

            b.Click();

        }
    }
}
