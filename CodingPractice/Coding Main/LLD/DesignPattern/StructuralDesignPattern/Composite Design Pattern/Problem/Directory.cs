using System.Collections;

namespace Coding_Main.LLD.DesignPattern.StructuralDesignPattern.Composite_Design_Pattern.Problem
{
    public class Directory
    {
        public string Name;

        public List<object> list;
        public Directory(string name)
        {
            Name = name;
            list = [];
        }


        public void IterateDirectory()
        {
            Console.WriteLine($"Directory name - {Name}");

            foreach (var directory in list)
            {

                if (directory is File file)
                {
                    file.Print();
                }
                else if (directory is Directory directoryInfo)
                {
                    directoryInfo.IterateDirectory();
                }
            }
        }
    }
}
