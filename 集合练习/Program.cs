namespace 集合练习;
class Program
{
    static void Main(string[] args)
    {
        //将一个数组中的奇数放到集合中，偶数放到另一个集合中
        //定义一个数组
        int[] ints = new int[] {1,2,3,4,5,6,7,8,9};
        //定义两个泛型集合用来接收奇数和偶数
        List<int> ints1 = new List<int> { };
        List<int> ints2 = new List<int> { };
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] %2==0)
            {
                ints2.Add(ints[i]);
            }
            else { ints1.Add(ints[i]); }
        }
        ints2.AddRange(ints1);

   
        for (int i = 0; i < ints2.Count; i++)
        {
            Console.Write(ints2[i]);
        }


        //接收用户输入的一个字符串，通过然后赋值给一个char类型的数组
        //提示用户输入
        Console.WriteLine("请输入：");
        //接收用户输入的内容
        string str = Console.ReadLine();
        //定义一个char数组接收内容
        char[] chars = new char[str.Length];
        //通过循环赋值
        int iii = 0;
        foreach (var item in str)
        {
            chars[iii] = item;
            iii++;

        }
    }
}

