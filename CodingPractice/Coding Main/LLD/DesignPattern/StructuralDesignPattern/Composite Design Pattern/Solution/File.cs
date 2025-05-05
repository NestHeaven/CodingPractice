namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Composite_Design_Pattern.Solution
{
    public class File : IFileSystem
    {
        public string _fileName;

        public File(string name)
        {
            _fileName = name;
        }
        public void PrintLs()
        {
            Console.WriteLine($"File Name - {_fileName}");
        }
    }
}
