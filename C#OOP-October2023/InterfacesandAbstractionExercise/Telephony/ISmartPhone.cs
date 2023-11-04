

namespace Telephony
{
    public interface ISmartPhone
    {
        string PhoneNumber { get; }

        string Calling();

        string WebBrowsing();
    }
}
