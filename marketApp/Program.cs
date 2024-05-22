

using marketApp;

JoinMyCharArray(new char[] {'A','y','a' });
Person p = new()
{
    Name = "A",
    Age = 10
};
Console.WriteLine(p.Name);

var requairedItemCount = 10;
var userName = "user";
var password = "EME#int123$";
GetConnectionLink(userName, password, requairedItemCount);


//Console.WriteLine( string.Join(' ', mine));
//Console.WriteLine( string.Join(' ', any text));

string GetConnectionLink(string userName, string password, int requairedItemCount)
{
    return $"http://mylink?user={userName}&password={password}&items={requairedItemCount}";
}

void JoinMyCharArray(char[] mine)
{
    
}
