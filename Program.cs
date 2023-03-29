namespace 泛型集合;
class Program
{
    static void Main(string[] args)
    {
        //创建泛型集合对象
        List<int> list = new List<int> { };
        //添加单个元素
        list.Add(1);
        list.Add(2);
        //添加数组
        list.AddRange(new int[] { 1, 2, 3, 4, 3, 2, 12, 4 });
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}

