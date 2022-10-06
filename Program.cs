using System.Text;
Str s = new Str();
Str q = new Str("Ku");
q.RzByte2();
s.RzByte();
s.Lennght();
s.CLear();

Chi C = new Chi();
C.Vvod();
C.Print();
Chi C2 = new Chi();
C2.Vvod();
C2.Print();
Chi C3 = C+C2;
Console.Write("Сплюсили->>");
C3.Print();
Chi C4 = C - C2;
Console.Write("Сминусили->>");
C4.Print();
if(C!=C2)
{
    Console.WriteLine("Числа не равны\n" + C.real + " " + C.imagn + " != " + C2.real + " " + C2.imagn);
}
if(C==C2)
{
    Console.WriteLine("Числа равны\n" + C.real + " " + C.imagn + " = " + C2.real + " " + C2.imagn);
}
Chi C5 = C * C2;
Console.Write("Умножили->>");
C5.Print();
Chi C6 = C / C2;
Console.Write("Поделили->>");
C6.Print();
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

class Chi
{
    public string real;
    public string imagn;
    double nV;
    public Chi()
    {

    }
    public void Vvod()
    {
        Console.WriteLine("Введите реальное число");
        real = Convert.ToString(Console.ReadLine());
        bool isNumber = double.TryParse(real, out nV);
        Console.WriteLine(isNumber);
        if(isNumber==false)
        {
            real = Convert.ToString(0);
            Console.WriteLine("Real = " + real);
        }
        
        Console.WriteLine("Введите мнимое число");
        imagn = Convert.ToString(Console.ReadLine());
        bool isNumber2 = double.TryParse(imagn, out nV);
        Console.WriteLine(isNumber2);
        if (isNumber2 == false)
        {
            imagn = Convert.ToString(0);
            Console.WriteLine("Imagn = " + imagn);
        }
    }
    
    public void Print()
    {
        Console.WriteLine("Real = " + real + " NeReal = " + imagn + "i");
    }
    public static Chi operator+(Chi n1, Chi n2)
    {
        Chi mas = new Chi();
        mas.real = Convert.ToString(Convert.ToInt32(n1.real)+ Convert.ToInt32(n2.real));
        mas.imagn = Convert.ToString(Convert.ToInt32(n1.imagn) + Convert.ToInt32(n2.imagn));
        return mas;
    }
    public static Chi operator -(Chi n1, Chi n2)
    {
        Chi mas = new Chi();
        mas.real = Convert.ToString(Convert.ToInt32(n1.real) - Convert.ToInt32(n2.real));
        mas.imagn = Convert.ToString(Convert.ToInt32(n1.imagn) - Convert.ToInt32(n2.imagn));
        return mas;
    }
    public static bool operator ==(Chi n1, Chi n2)
    {
        if ((n1.real == n2.real) && (n1.imagn == n2.imagn))
            return true;
        return false;
    }
    public static bool operator !=(Chi n1, Chi n2)
    {
        if ((n1.real == n2.real) && (n1.imagn == n2.imagn))
            return false;
        return true;
    }
    public static Chi operator /(Chi n1, Chi n2)
    {
        Chi mas = new Chi();
        mas.real = Convert.ToString((Convert.ToDouble(n1.real)* Convert.ToDouble(n2.real) + Convert.ToDouble(n1.imagn)* Convert.ToDouble(n2.imagn)) / (Convert.ToDouble(n2.real)* Convert.ToDouble(n2.real)+ Convert.ToDouble(n2.imagn)* Convert.ToDouble(n2.imagn)));
        mas.imagn = Convert.ToString((Convert.ToDouble(n1.real) * Convert.ToDouble(n2.imagn) - Convert.ToDouble(n2.real) * Convert.ToDouble(n1.imagn)) / (Convert.ToDouble(n2.real) * Convert.ToDouble(n2.real) + Convert.ToDouble(n2.imagn) * Convert.ToDouble(n2.imagn)));
        return mas;
    }
    public static Chi operator *(Chi n1, Chi n2)
    {
        Chi mas = new Chi();
        mas.real = Convert.ToString(Convert.ToInt32(n1.real) * Convert.ToInt32(n2.real) - Convert.ToInt32(n1.imagn) * Convert.ToInt32(n2.imagn));
        mas.imagn = Convert.ToString(Convert.ToInt32(n1.real) * Convert.ToInt32(n2.imagn) + Convert.ToInt32(n2.real) * Convert.ToInt32(n1.imagn));
        return mas;
    }
}