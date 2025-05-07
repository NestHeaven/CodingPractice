namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Bridge_Design_Pattern
{
    public class Circle : ShapeBridge
    {
        public Circle(IDrawer drawer) : base(drawer)
        {
        }

        public override void Draw()
        {
            _drawer.Draw("Circle");
        }
    }
}
