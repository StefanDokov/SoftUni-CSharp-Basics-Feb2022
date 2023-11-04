

namespace Telephony
{
    public class SmartUser : ISmartPhone
    {

        public SmartUser(string phoneNumber) 
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
                return $"Calling... {this.PhoneNumber}";
            }
            
        }

        public string WebBrowsing()
        {
            if (this.PhoneNumber.Any(char.IsNumber))
            {
                throw new ArgumentException($"Invalid URL!");
            }
            else
            {
                return $"Browsing: {this.PhoneNumber}!";
            }
        }
    }
}
