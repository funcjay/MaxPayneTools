using MaxPayneTools.Files;

namespace MaxPayneTools.CLI;

public static class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Max Payne Tools DEV BUILD");

        if (args.Length != 1) {
            Console.WriteLine("Provide a Max Payne 1 LDB file as the only argument");
            return;
        }

        var filePath = args[0];

        if (!File.Exists(filePath) || filePath.LastIndexOf(".ldb", StringComparison.Ordinal) == -1) {
            Console.WriteLine("Provided file doesn't exist or isn't a \".ldb\" file!");
            return;
        }

        FileStream file;
        
        try {
            file = File.OpenRead(filePath);
        } catch (Exception) {
            Console.WriteLine($"Failed to open file \"{filePath}\"!");
            return;
        }

        BinaryReader br;

        try {
            br = new BinaryReader(file);
        } catch (Exception) {
            Console.WriteLine($"Failed to create BinaryReader on file \"{filePath}\"!");
            return;
        }
        
        var ldb = new Mp1Ldb(br);

        Console.WriteLine($"DEBUG: ldb.FileVersion = {ldb.FileVersion}");

        br.Close();
        file.Close();
    }
}
