using EDriveRent.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public class User : IUser
    {

        public User(string firstName, string lastName, string drivingLicenseNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DrivingLicenseNumber = drivingLicenseNumber;
            Rating = 0;
            IsBlocked = false;
        }

        private string firstName;

        public string FirstName
        {
            get 
            { 
                return firstName; 
            }
            private set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName cannot be null or whitespace!");
                }
                firstName = value; 
            }
        }

        public string lastName;

        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("LastName cannot be null or whitespace!");
                }
                lastName = value;
            }
        }
        public double rating;
        public double Rating
        {
            get
            {
                return rating;
            }
            private set
            {
                
                rating = value;
            }
        }
        public string drivingLicenseNumber;
        public string DrivingLicenseNumber
        {
            get
            {
                return drivingLicenseNumber;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Driving license number is required!");
                }
                drivingLicenseNumber = value;
            }
        }
        public bool isBlocked;

        public bool IsBlocked
        {
            get
            {
                return isBlocked;
            }
            private set
            {
               
                isBlocked = value;
            }
        }
        public void DecreaseRating()
        {
            if (rating - 2.0 < 0)
            {
                rating = 0;
                IsBlocked = true;
            }
            else
            {
                rating -= 2.0;
            }

        }

        public void IncreaseRating()
        {
            if (rating + 0.5 > 10d)
            {
                rating = 10d;
            }
            else
            {
                rating += 0.5;
            }

        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} Driving license: {DrivingLicenseNumber} Rating: {Rating}";
;
        }
    }
}
