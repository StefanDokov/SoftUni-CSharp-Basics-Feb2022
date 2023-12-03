using EDriveRent.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public abstract class Route : IRoute
    {
        public Route(string startPoint, string endPoint, double length, int routeId)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Length = length;    
            RouteId = routeId;
            IsLocked = false;
        }
        public string startPoint;
        public string StartPoint
        {
            get
            {
                return startPoint;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("StartPoint cannot be null or whitespace!");
                }
                startPoint = value;
            }
        }

        public string endPoint;
        public string EndPoint
        {
            get
            {
                return endPoint;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("EndPoint cannot be null or whitespace!");
                }
                endPoint = value;
            }
        }

        public double length;
        public double Length
        {
            get
            {
                return length;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Length cannot be less than 1 kilometer.");
                }
                length = value;
            }
        }

        public int routeId;
        public int RouteId
        {
            get
            {
                return routeId;
            }
            private set
            {
                routeId = value;
            }
        }

        public bool isLocked;
        public bool IsLocked
        {
            get
            {
                return isLocked;
            }
            private set
            {
                isLocked = value;
            }
        }


        public void LockRoute()
        {
            IsLocked = true;
        }
    }
}
