using System;

class NameFon
{
    protected string name;
    protected string fon;

    public NameFon() { name = ""; fon = ""; }
    public NameFon(string n,string f) { name = n; fon = f; }

    public string N
    {
        get { return name; }
        set { name = value; }
    }
    public string F
    {
        get { return fon; }
        set { fon = value; }
    }
    public void Display()
    {
        Console.WriteLine("Name= "+name+ " Fon= "+fon);
    }

    public static bool operator < (NameFon a, NameFon b)
    {
        bool f = false;
        if (a.name[0] < b.name[0]) f = true;
        return f;
    }
    public static bool operator >(NameFon a, NameFon b)
    {
        bool f = false;
        if (a.name[0] > b.name[0]) f = true;
        return f;
    }
}

class GuideFon
{
    NameFon[] guide;
    int size;

    public GuideFon() { size = 0; guide = new NameFon[0]; }
    public GuideFon(NameFon[] arr, int n)
    {
        guide = arr;
        size = n;
    }
    public void Display()
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(guide[i].F+" " +guide[i].N);
        }
    }
    public bool Find(string name)
    {
        bool f = false;
        for (int i = 0; i < size; i++)
        {
            if (guide[i].N == name) f = true;
        }
        return f;
    }
    public static GuideFon operator +(GuideFon guidf, NameFon namef)
    {
        NameFon[] arr = new NameFon[guidf.guide.Length + 1];
        for (int i = 0; i < guidf.guide.Length; i++)
        {
            arr[i] = guidf.guide[i];
        }
        arr[guidf.guide.Length] = namef;
        return new GuideFon(arr, guidf.size + 1);
    }
    public void Sort()
    {
        for (int j = 0; j < guide.Length; j++)
        {
            for (int i = 0; i < guide.Length; i++)
            {
                if (i < (guide.Length - 1))
                {
                    if (guide[i + 1] < guide[i])
                    {
                        NameFon change = guide[i + 1];
                        guide[i + 1] = guide[i];
                        guide[i] = change;
                    }
                }
            }
        }
    }
}

class Demo
{
    public static void Main()
    {
        GuideFon gf=new GuideFon();
        // создание абонентов
        NameFon n1 = new NameFon("Марченко","8999221221");
        NameFon n2 = new NameFon("Иванов", "89991767621");
        NameFon n3 = new NameFon("Сидоров", "89991765433");
        // создания массива абонентов для упрощения работы
        NameFon[] arr = { n1, n2, n3 };
        //заролнение справочника
        for (int i = 0; i < arr.Length; i++)
        {
            gf = gf + arr[i];
        }
        // вывод на экран
        gf.Display();
        Console.WriteLine("===============");
        // проверка по справочнику
        string namefind = "Иванов";
        if (gf.Find(namefind)) Console.WriteLine("{0} Есть в справочнике", namefind);
        else Console.WriteLine("{0} НЕТ в справочнике", namefind);
        // сортировка и вывод
        Console.WriteLine("===============");
        Console.WriteLine("После сортировки");
        gf.Sort();
        gf.Display();
    }
}