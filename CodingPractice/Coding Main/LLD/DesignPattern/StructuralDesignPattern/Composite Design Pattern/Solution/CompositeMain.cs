namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Composite_Design_Pattern.Solution
{
    public class CompositeMain
    {
        public static void Main()
        {
            File file = new File("Golmal");

            Directory directory = new Directory("Comedy");

            directory.AddFile(file);

            Directory directory1 = new Directory("Horror");

            directory1.AddFile(new File("Bhootnath"));

            directory.AddFile(directory1);

            directory.PrintLs();
        }
    }
}
