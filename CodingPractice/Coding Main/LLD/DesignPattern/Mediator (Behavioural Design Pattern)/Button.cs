namespace Coding_Main.LLD.DesignPattern.Mediator__Behavioural_Design_Pattern_
{
    public class Button
    {
        public readonly IMediator mediator;

        public Button(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Click()
        {
            Console.WriteLine("Button Clicked");
            mediator.Notify("Button Clicked");
        }
    }
}
