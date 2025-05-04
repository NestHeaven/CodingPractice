namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Decorater_Design_Pattern
{
    public  class Main
    {

        public static void DecoratorMain()
        {
            BasePizza margheritaPizza = new MargheritaPizza();

            margheritaPizza.cost();
            //this will give the cost of marghrerita


            // I want to decorate it with Extra cheeze

            BasePizza pizza = new ExtraCheese(new MargheritaPizza());

            pizza.cost();

            // this will give cost with margherita with extra cheeze




            // I want to decorate it margherita with Extra cheeze and mushroom

            BasePizza p = new ExtraMushroom(new ExtraCheese(new MargheritaPizza()));

            p.cost();


            // this will give cost with margherita with extra cheeze + mushroom


        }
    }
}
