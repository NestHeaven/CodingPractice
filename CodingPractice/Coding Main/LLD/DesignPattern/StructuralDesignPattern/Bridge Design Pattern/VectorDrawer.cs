namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Bridge_Design_Pattern
{
    public class VectorDrawer : IDrawer
    {
        public void Draw(string shape)
        {
            Console.WriteLine($"Drawing {shape} with Pixel");
        }
    }
}
