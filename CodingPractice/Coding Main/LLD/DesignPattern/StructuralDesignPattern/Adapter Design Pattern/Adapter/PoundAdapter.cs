namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Adapter_Design_Pattern.Adapter
{
    public class PoundAdapter : IPoundAdapter
    {
        public readonly IWeightMachine _weightMachine;

        public PoundAdapter(IWeightMachine weightMachine)
        {
            _weightMachine = weightMachine;
        }

        public double GetWeightInPounds()
        {
            var a = _weightMachine.GetWeightInKgs();

            // Add a logic to convert in Pound

            return a * 0.45;
        }
    }
}
