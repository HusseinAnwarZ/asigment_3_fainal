using System.Collections;
//Q1
Console.WriteLine("Q1");
List<Student> l = new List<Student>();
int k = 0;
while (k != 5)
{
Console.WriteLine("enter id of student " + (k + 1));
string? i = Console.ReadLine();
Console.WriteLine("enter name of student " + (k + 1));
string? n = Console.ReadLine();
Console.WriteLine("enter mark of student " + (k + 1));
double m = Convert.ToDouble(Console.ReadLine());
if (m < 0 || m > 100)
{
Console.WriteLine("error please enter vaild number");
k--;
}
l.Add(new Student(i, n, m));
k++;
}
k = 1;
Console.WriteLine("passed students");
foreach (Student i in l)
{
if (i.mark >= 50)
{
Console.WriteLine("student " + k + "\n" + "name:" + i.name + "\n" + "id:" + i.id + "\n" + "mark:" + i.mark + "\n");
k++;
}
}
Console.ReadLine();
class Student
{
    public string id;
    public string name;
    public double mark;
    public Student(string I, string n, double m)
    {
        id = I;
        name = n;
        mark = m;
    }
}
//Q2
/*Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Q2" + "\n" + "-----------------------------------" + "\n");

Console.WriteLine("enter number of accounts");
int x = int.Parse(Console.ReadLine());
int i = 0;
ArrayList l = new ArrayList();
while (i < x)
{
    Console.WriteLine("enter email username");
    string? UsernameInput = Console.ReadLine();
    Console.WriteLine("enter password");
    string? PasswordInput = Console.ReadLine();
    l.Add(new Account(UsernameInput, PasswordInput));
    i++;
}
//made user enter the user user name to change and using copy constracter
Console.WriteLine("enter the user name for the email that you want change ");
string ChangeAccount = Console.ReadLine();
int index = 0;
bool Exsist = true;
foreach (Account o in l)
{
    if (ChangeAccount == o.username)
    {
        Account CAccount = new Account(o);
        Console.WriteLine("enter new username");
        string NewUser = Console.ReadLine();
        Console.WriteLine("enter new password");
        string NewPassword = Console.ReadLine();
        CAccount.username = NewUser;
        CAccount.password = NewPassword;
        l[index] = CAccount;
        Console.WriteLine("new info" + "\n" + "user: " + CAccount.username + "\n" + "password" +
        CAccount.password);
        foreach (Account k in l)
        {
            Console.WriteLine("user:" + k.username + "\n" + "password" + k.password);
        }
        break;
    }
    else
    {
        Exsist = false;
    }
    index++;
}
if (!Exsist)
{
    Console.WriteLine("Unexsist info");
}
bool check = false;
Console.WriteLine("enter user name to check");
string user = Console.ReadLine();
Console.WriteLine("enter password to check");
string password = Console.ReadLine();
foreach (Account k in l)
{
    if (user == k.username && password == k.password)
    {
        check = true;
        Console.WriteLine("corect info");
        break;
    }
}
if (!check)
{
    Console.WriteLine("incorect info");
}
Console.ReadLine();
class Account
{
    public string username;
    public string password;
    public Account(string e, string p)
    {
        username = e;
        password = p;
    }
    public Account(Account a)
    {
        username = a.username;
        password = a.password;
    }
}*/