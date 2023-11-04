
using Telephony.Core.Interfaces;
using Telephony.IO.Interfaces;

namespace Telephony.Core;
public class Engine : IEngine
{
    private IReader reader;
    private IWriter writer;

    public Engine(IReader reader, IWriter writer)
    {
        this.reader = reader;
        this.writer = writer;
    }

    public void Run()
    {
        string[] pNumbers = reader.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string[] pUrls = reader.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries);
        
            foreach (string s in pNumbers)
            {
                if (s.Length == 10)
                {
                    ISmartPhone user = new SmartUser(s);
                try
                {

                    writer.WriteLine(user.Calling());
                } catch (Exception e)
                {
                    writer.WriteLine(e.Message);
                }
            }
                else
                {
                    IStaticPhone user = new StaticUser(s);
                try
                {

                    writer.WriteLine(user.Calling());
                }
                catch (Exception e)
                {
                    writer.WriteLine(e.Message);
                }

            }
            }

            foreach (string s in pUrls)
            {
                ISmartPhone user = new SmartUser(s);
            try
            {
                writer.WriteLine(user.WebBrowsing());

            }
            catch (Exception e)
            {
                writer.WriteLine(e.Message);
            }

            }

        
        
    }
}