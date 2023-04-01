namespace 简单工厂模式;
class Program
{
    static void Main(string[] args)
    {
        //根据用户的需求，返回给用户所要的结果！
        Console.WriteLine("请输入你想要的笔记本品牌：");
        string brang = Console.ReadLine();

        //把方法的处理结果赋值给父类
        NetBook book = GetNetBook(brang);
        book.SayHelly();

    }
    //使用一个方法处理用户的需求
    public static NetBook GetNetBook(string brang)
    {
        NetBook? book = null;

        switch (brang)
        {
            case "Lenvov":book = new Lenvov();
                break;
            case "IBM":book = new IBM();
                break;
            case "Acer":book = new Acer();
                break;
            case "Dell":book = new Dell();
                break;

        }

        return book;
    }
}

//创建一个抽象的基类
abstract class NetBook
{
    //抽象方法，注意抽象方法不需要{}！
    public abstract void SayHelly();
}

//创建Lenvov 用来继承 NetBook;
class Lenvov : NetBook
{
    public override void SayHelly()
    {
        Console.WriteLine("大家好！我是Lenvov!");
    }
}

//创建Acer，用来继承NetBook；
class Acer : NetBook
{
    public override void SayHelly()
    {
        Console.WriteLine("大家好！我是Acer!");
    }
}

//创建DELL，用来继承NetBook；
class Dell : NetBook
{
    public override void SayHelly()
    {
        Console.WriteLine("大家好！我是DELL!");
    }
}

class IBM : NetBook
{
    public override void SayHelly()
    {
        Console.WriteLine("大家好！我是IBM！");
    }
}

