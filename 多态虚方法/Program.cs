
using 多态虚方法;

FuBao fuBao = new FuBao("大福宝");
DCM dCM = new DCM("大聪明");
SB sB = new SB("三宝");
Cat[] cats = { fuBao, dCM, sB };
for (int i = 0; i < cats.Length; i++)
{
    cats[i].SayHi();
}
namespace 多态虚方法
{
    class Cat
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public Cat(string name)
        {
            this.Name = name;
        }

        public virtual void SayHi()
        {

        }
    }

    class FuBao : Cat
    {
        public FuBao(string name) : base(name)
        {
        }
        public override void SayHi()
        {
            Console.WriteLine("大家好! 我叫{0}", this.Name);
        }

    }

    class DCM : Cat
    {
        public DCM(string name) : base(name)
        {
        }
        public override void SayHi()
        {
            Console.WriteLine("大家好! 我叫{0}", this.Name);
        }

    }

    class SB : Cat
    {
        public SB(string name) : base(name)
        {
        }
        public override void SayHi()
        {
            Console.WriteLine("大家好! 我叫{0}", this.Name);
        }

    }
}