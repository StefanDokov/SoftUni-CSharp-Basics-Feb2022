

namespace Stealer;
class Program
{
    static void Main(string[] args)
    {
        Spy spy = new Spy();
        string className = "Stealer.Hacker";
        string[] fieldsToInvestigate = { "username", "password", "Id", "BankAccountBalance" };

        spy.StealFieldInfo(className, fieldsToInvestigate);
    }
}