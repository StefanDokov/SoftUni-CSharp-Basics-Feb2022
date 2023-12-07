using EDriveRent.Core.Contracts;
using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories;
using EDriveRent.Repositories.Contracts;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Core
{
    public class Controller : IController
    {

        private IRepository<IRoute> routes;
        private IRepository<IUser> users;
        private IRepository<IVehicle> vehicles;

        public Controller()
        {
            routes = new RouteRepository();
            users = new UserRepository();
            vehicles = new VehicleRepository();
        }
        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            Route route = new(startPoint, endPoint, length, routes.GetAll().Count() + 1); 

            if (routes.FindById(route.RouteId.ToString()) != null )
            {
                return String.Format(OutputMessages.RouteExisting, startPoint, endPoint, length);
            }
            if (routes.GetAll().Any(r => r.StartPoint == startPoint && r.EndPoint == endPoint && r.Length < length))
            {
                return String.Format(OutputMessages.RouteIsTooLong, startPoint, endPoint);
            }
            else
            {
                routes.AddModel(route);
                foreach(Route routee in routes.GetAll())
                {
                    if (routee.StartPoint == startPoint && routee.EndPoint == endPoint && routee.Length > length)
                    {
                        routee.LockRoute();
                    }
                }
                return String.Format(OutputMessages.NewRouteAdded, startPoint, endPoint);
            }

        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            throw new NotImplementedException();
        }

        public string RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
        {
            User user = new(firstName, lastName, drivingLicenseNumber);
            if (users.FindById(drivingLicenseNumber) != null)
            {
                return String.Format(OutputMessages.UserWithSameLicenseAlreadyAdded, drivingLicenseNumber);
            }
            users.AddModel(user);
            return String.Format(OutputMessages.UserSuccessfullyAdded, firstName, lastName, drivingLicenseNumber);
        }

        public string RepairVehicles(int count)
        {
            throw new NotImplementedException();
        }

        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
            IVehicle vehiclee;
            if (vehicleType == "CargoVan")
            {
                vehiclee = new CargoVan(brand, model, licensePlateNumber);
            }
            else if (vehicleType == "PassangerCar")
            {
                vehiclee = new PassengerCar(brand, model, licensePlateNumber);
            }
            else
            {
                return String.Format(OutputMessages.VehicleTypeNotAccessible, vehicleType);
            }

            if (vehicles.FindById(licensePlateNumber) != null)
            {
                return String.Format(OutputMessages.LicensePlateExists, licensePlateNumber);
            }

            vehicles.AddModel(vehiclee);
            return String.Format(OutputMessages.VehicleAddedSuccessfully, brand, model, licensePlateNumber);



        }

        public string UsersReport()
        {
            throw new NotImplementedException();
        }
    }
}
