namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Composite_Design_Pattern.Problem_2_Calculater
{
    public class Number : ICalculate
    {
        int _number;

        public Number(int number)
        {
            _number = number;
        }
        public int CalculateValue()
        {
            return _number;
        }
    }
}
