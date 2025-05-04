namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Decorater_Design_Pattern
{
    public class ExtraCheese : ToppingDecorator
    {
        public BasePizza _basePizza;

        public ExtraCheese(BasePizza basePizza)
        {
            _basePizza = basePizza;
        }

        public override int cost()
        {
            return _basePizza.cost() + 100;
        }
    }
}
