

namespace Telephony
{
    public interface IStaticPhone
    {
        string PhoneNumber { get; }

        string Calling();
    }
}
