Console.WriteLine("Как вас зовут..?");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша..!!!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}