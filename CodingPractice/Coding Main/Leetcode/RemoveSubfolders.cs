namespace Coding_Main.Leetcode
{
    public static class RemoveSubfolders
    {

        //LeetCode--Remove Sub-Folders from the Filesystem

        public static IList<string> RemoveSubfoldersMethod(string[] folder)
        {
            List<string> result = new List<string>();

            Parallel.ForEach(folder, item =>
            {

                var value = item.Split("/").Where(x => x != "");

                string s = string.Empty;

                bool isNotExists = true;

                foreach (var subItems in value)
                {
                    s += $"/{subItems}";

                    if (item == s)
                        continue;

                    if (folder.Any(x => x == s))
                    {
                        isNotExists = false;
                        break;
                    }
                }

                if (isNotExists)
                {
                    result.Add(s);
                }
            });

            //for (int i = 0; i < folder.Length-1; i++) {

            //    var value = folder[i].Split("/").Where(x => x != "");

            //    string s = string.Empty;

            //    bool isNotExists = true;

            //    for (int j = 0; j < folder.Length - 1; j++){

            //        s += $"/{folder[j]}";

            //        if (folder[i] == s)
            //            continue;

            //        if (folder.Any(x => x == s))
            //        {
            //            isNotExists = false;
            //            break;
            //        }
            //    }
            //    if (isNotExists)
            //    {
            //        result.Add(s);
            //    }
            //}

            return result;
        }
    }
}
