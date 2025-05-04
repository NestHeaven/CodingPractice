namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Decorater_Design_Pattern
{
    public class ExtraMushroom : ToppingDecorator
    {
        public BasePizza _basePizza;

        public ExtraMushroom(BasePizza basePizza)
        {
            _basePizza = basePizza;
        }
        public override int cost()
        {
            return _basePizza.cost() + 20;
        }
    }
}
