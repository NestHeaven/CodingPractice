namespace Coding_Main.LLD.DesignPattern.Mediator__Behavioural_Design_Pattern_
{
    public class DialogMediator : IMediator
    {
        public Button button;
        
        public TextBox textBox;

        public void Notify(string eventType)
        {
            if(eventType == "Button Clicked")
            {
                textBox.ClearText();
            }
        }
    }
}
