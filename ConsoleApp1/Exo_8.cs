namespace ConsoleApp1
{
    //search file in //C:\Users\ferta\Documents\tmp
    //tmp
    //    aaa
    //    bbb
    //        ccc
    //    eee
    //    fff
    //        ggg
    //            hhh
    //iii
    //    jjj
    public class Exo_8
    {
        static string fileName = "universe-formula";
        public static void Main()
        {
            string targetPath = "C:\\Users\\ferta\\Documents\\tmp";
            var result = GetDirectories(targetPath);
            Console.WriteLine(result ?? $"{fileName} file could not be found in {result}");
        }

        public static string GetDirectories(string directory) 
        {
            try
            {
                var files = Directory.GetFiles(directory);
                foreach (var file in files)
                {
                    if (Path.GetFileName(file) == fileName)
                    {
                        return file;
                    }
                }

                var subDirectories = Directory.GetDirectories(directory);
                foreach (var subDirectory in subDirectories)
                {
                    var result = GetDirectories(subDirectory);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"an error has occured : {e.Message}");
            }

            return null;
        }
    }
}
