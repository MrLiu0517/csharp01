namespace 基础01;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string str = @"/Users/liuyin/GitHub/csharp01/Program.cs";
        //获取文件名
        Console.WriteLine(Path.GetFileName(str));
        //获取文件名，但不包含扩展名
        Console.WriteLine(Path.GetFileNameWithoutExtension(str));
        //获取文件的扩展名
        Console.WriteLine(Path.GetExtension(str));
        //获取文件所在文件夹的路径
        Console.WriteLine(Path.GetDirectoryName(str));
        //获取文件所在的全路径
        Console.WriteLine(Path.GetFullPath(str));

        //创建文件
        //File.Create(@"/Users/liuyin/GitHub/csharp01/ceshi.txt");
        //删除一个文件
        File.Delete(@"/Users/liuyin/GitHub/csharp01/ceshi.txt");
    }
}
