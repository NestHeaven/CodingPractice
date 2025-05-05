namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Composite_Design_Pattern.Problem_2_Calculater
{
    public class CalculatorComposite(ICalculate leftArthmetic, ICalculate rightArthmetic, Operation operation) : ICalculate
    {
        public ICalculate LeftArthemetic = leftArthmetic;
        public ICalculate RightArthemetic = rightArthmetic;
        public Operation operation = operation;

        public int CalculateValue()
        {
            if(operation == Operation.Add)
                return LeftArthemetic.CalculateValue() + RightArthemetic.CalculateValue();
            else if(operation == Operation.Substract)
                return LeftArthemetic.CalculateValue() - RightArthemetic.CalculateValue();
            else if(operation == Operation.Multiply)
                return LeftArthemetic.CalculateValue() * RightArthemetic.CalculateValue();
            else if (operation == Operation.Divide)
                return LeftArthemetic.CalculateValue() / RightArthemetic.CalculateValue();

            return 0;
        }
    }
}
