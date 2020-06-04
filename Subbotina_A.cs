using System;
using System.IO;

class Group
{
    public int n;
    public string[] group;
    //свойство
    public int N
    {
        get { return n; }
        set { n = value; }
    }
    //Конструктор
    public Group(string[] g)
    {
        n = g.Length;
        group = g;
    }
    //индексатор
    public string this[int index]
    {
        get
        { 
            return group[index];
        }
        set 
        {
            group[index] = value;
        }
    }
    // метод копирования
    public static void Copy (Group group1, Group group2)
    {
        group2.group = group1.group;
        group2.n = group1.n;
    }
    //мето для сортировки
    public void Sort()
    {
        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (i < (n - 1))
                {
                    if (group[i + 1][0] < group[i][0])
                    {
                        string str = group[i + 1];
                        group[i + 1] = group[i];
                        group[i] = str;
                    }
                }
            }
        }
    }
    // метод для вывода в консоль
    public virtual void Display()
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{i+1}" + group[i]+" ");
        }
    }
    // метод для поиска фамилии в списке
    public bool Find(string name)
    {
        bool b = false;
        for (int i = 0; i < n; i++)
        {
            if (group[i] == name) b = true;
        }
        return b;
    }
    // перегрезка оператора для удаления фамилии из списка
    public static Group operator -(Group group1, string newname)
    {
        string[] strarr = new string[group1.n - 1];
        if (group1.Find(newname))
        {
            for (int i = 0; i < group1.n; i++)
                if (newname == group1.group[i])
                    group1.group[i] = "";
            
            for (int i = 0; i < group1.n; i++)
            {
                if (group1.group[i] != "")
                {
                    strarr[i] = group1.group[i];
                }
                else
                {
                    strarr[i] = group1.group[i + 1];
                    i++;
                }
            }
        }
        return new Group(strarr);
    }
    //метод дял записи в файл
    public virtual void InFile(string path)
    {
        StreamWriter sw = new StreamWriter(path);
        for (int i = 0; i < n; i++)
        {
            sw.WriteLine( $"{i+1}) " + group[i]);
        }
        sw.Close();
    }

}
class StudGroup  : Group
{
    string number;
    string facultet;
    public StudGroup(string number,string facultet,string[] group) :base(group)
    {
        this.number = number;
        this.facultet = facultet;
    }
    public override void Display()
    {
        Console.WriteLine($"Факультет {facultet}  Группа {number}");
        base.Display();
    }
    public override void InFile(string path)
    {
        StreamWriter sw = new StreamWriter(path);
        for (int i = 0; i < n; i++)
        {
            sw.WriteLine((i + 1) + ") " + group[i] + ", " + number + ", " + facultet);
        }
        sw.Close();
    }
    
}
class Demo
{
    public static void Main()
    {
        string[] name =
        {
            "Ивнов","Петров","Сидоров","Субботина","Алексеев"
        };
        Group gr = new Group(name);
        StudGroup StudGrup = new StudGroup( "09-901", "ИВМИиТ", gr.group);
        Console.WriteLine("##### ДО СОРТИРОВКИ #####");
        StudGrup.Display();

        Console.WriteLine("##### ПОСЛЕ СОРТИРОВКИ #####");
        StudGrup.Sort();
        StudGrup.Display();
        string n = "Сидоров";
        Console.WriteLine("##### После удаления ={0}= #####", n);
       
        gr = gr- n;//удаляем из масиива grup класса group
        StudGrup = new StudGroup("09-901", "ИВМИиТ", gr.group); // записываем заново удалив 
        StudGrup.Display();
        StudGrup.InFile("..\\..\\Text.txt");

    }
}