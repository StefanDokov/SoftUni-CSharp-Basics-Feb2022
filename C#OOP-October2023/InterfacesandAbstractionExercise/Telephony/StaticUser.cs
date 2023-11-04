

namespace Telephony
{
    public class StaticUser : IStaticPhone
    {
        public StaticUser(string phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }
        public string PhoneNumber { get; private set; }


        public string Calling()
        {
            if (!this.PhoneNumber.All(char.IsDigit))
            {
                throw new ArgumentException($"Invalid number!");
            }
            else
            {
                return $"Dialing... {this.PhoneNumber}";
            }
        }
    }
}
