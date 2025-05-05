namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Composite_Design_Pattern.Problem_2_Calculater
{
    public class CompositeProblem2Main
    {
        public static void Main()
        {
            Number number = new Number(3);
            Number number2 = new Number(2);
            Number number3= new Number(7);




            //             *
            //            / \
            //           3   +
            //              / \
            //              2  7

            //           3*(2+7) = 27


            CalculatorComposite c = new CalculatorComposite(number2, number3, Operation.Add);
            CalculatorComposite calculate = new CalculatorComposite(number, c, Operation.Multiply);

            Console.WriteLine(calculate.CalculateValue());
          
        }
    }
}
