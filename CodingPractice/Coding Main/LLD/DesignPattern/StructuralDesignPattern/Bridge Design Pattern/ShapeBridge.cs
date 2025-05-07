namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Bridge_Design_Pattern
{
    public abstract class ShapeBridge
    {
        public IDrawer _drawer;

        protected ShapeBridge(IDrawer drawer)
        {
            _drawer = drawer;
        }

        public abstract void Draw();

    }
}
