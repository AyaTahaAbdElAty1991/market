

using marketApp;

JoinMyCharArray(new char[] {'A','y','a' });
Person p = new()
{
    Name = "A",
    Age = 10
};
Console.WriteLine(p.Name);

static void JoinMyCharArray(char[] mine)
{
    Console.WriteLine( string.Join(' ', mine));

}
