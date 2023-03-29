using System.Text;
namespace 文件操作;
class Program
{
    static void Main(string[] args)
    {

        //FileStream操作字节的
        //创建一个实例，它接收三个参数
        //1.文件路径
        //2.如果目标路径有对应文件就打开，如果没有就创建一个并打开
        //3.表示对这个文件做什么操作
        FileStream fileStream = new FileStream(@"/Users/liuyin/GitHub/csharp01/new.txt", FileMode.OpenOrCreate, FileAccess.Read);
        //定义一个字节数组来接收内容用来当作缓冲区并限定读取的大小(5M)
        byte[] bytes = new byte[1024 * 1024 * 5];

        //返回的是本次实例读到的有效的字节数
        //第一个参数是用来接收的字节数组实例
        //第二个参数是从什么位置开始读取
        //第三个参数是每次读取的大小
        int r = fileStream.Read(bytes, 0, bytes.Length);

        Console.WriteLine(r);

        //将字节数组中每一个元素按照指定的编码个是解码成字符串，并接收
        //第一个参数是要解码的字节数组
        //第二个参数是从什么位置开始解码
        //第三个参数是从什么位置结束
        string s = Encoding.Default.GetString(bytes,0,r);
        //关闭文件流
        fileStream.Close();
        //释放所占用的资源
        fileStream.Dispose();
        Console.WriteLine(s);

        //使用Using来自动关闭和释放资源
        using (FileStream fileStream1 = new FileStream(@"/Users/liuyin/GitHub/csharp01/new.txt", FileMode.OpenOrCreate, FileAccess.Write)) 
        {
           string str = "大家好，我是大福宝！";
            byte[] bytes1 = Encoding.Default.GetBytes(str);
            fileStream1.Write(bytes1, 0, bytes1.Length);


        }
    }
}

