using System.Text;

Str s = new Str();
Str q = new Str("Ku");
q.RzByte2();
s.RzByte();
s.Lennght();
s.CLear();
class Str
{
    string str;
    public void RzByte()
    {
        Console.WriteLine("Введите строку");
        str = Console.ReadLine();
        int i = Encoding.Unicode.GetBytes(str).Length;
        Console.WriteLine(str + " " + i + " byte");
    }
    public void RzByte2()
    {
        int i = Encoding.Unicode.GetBytes(str).Length;
        Console.WriteLine(str + " " + i + " byte");
    }
    public Str()
    {

    }
    public Str(string str = "Hello")
    {
        this.str = str;
    }
    public Str(char ch = 'W')
    {
        str = Convert.ToString(ch);
    }
    public void Lennght()
    {
        Console.WriteLine("Длина строки ->> " + str + " = " + str.Length);
    }
    public void CLear()
    {
        str = "";
        Lennght();
    }
    ~Str() { }
}
