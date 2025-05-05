namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Composite_Design_Pattern.Solution
{
    public class Directory : IFileSystem
    {
        public string _directoryName;
        public List<IFileSystem> _directories;

        public Directory(string directoryName)
        {
            _directories = new List<IFileSystem>();
            _directoryName = directoryName; 
        }

        public void AddFile(IFileSystem directory) => _directories.Add(directory);
        public void PrintLs()
        {
            Console.WriteLine($"Directory Name -{_directoryName}");

            foreach (IFileSystem directory in _directories)
                directory.PrintLs();
        }
    }
}
