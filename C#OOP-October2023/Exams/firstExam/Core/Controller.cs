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
            int id = routes.GetAll().Count();
            id++;
            Route route = new(startPoint, endPoint, length, id); 

            if (routes.GetAll().Any(r => r.StartPoint == startPoint && r.EndPoint == endPoint && r.Length == length))
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
                return String.Format(OutputMessages.NewRouteAdded, startPoint, endPoint, length);
            }

        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            IUser user = users.FindById(drivingLicenseNumber);
            IVehicle vehicle = vehicles.FindById(licensePlateNumber);
            IRoute route = routes.FindById(routeId);

            if (user.IsBlocked)
            {
                return String.Format(OutputMessages.UserBlocked, drivingLicenseNumber);
            }
            if (vehicle.IsDamaged)
            {
                return String.Format(OutputMessages.VehicleDamaged, licensePlateNumber);
            }
            if (route.IsLocked)
            {
                return String.Format(OutputMessages.RouteLocked, routeId);
            }

            vehicle.Drive(route.Length);

            if (isAccidentHappened)
            {
                vehicle.ChangeStatus();
                user.DecreaseRating();
            }
            else
            {
                user.IncreaseRating();
            }
            return vehicle.ToString();
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
            int num = 0;
            List<IVehicle> damagedCars = vehicles.GetAll().Where(c => c.IsDamaged == true).OrderBy(c => c.Brand).ThenBy(c => c.Model).ToList();
            if (damagedCars.Count > 0)
            {

            foreach (IVehicle vehicler in damagedCars)
            {
                vehicler.Recharge();
                vehicler.ChangeStatus();
                num++;
                if (num == count) 
                {
                    break;
                }
            }
            }

            return String.Format(OutputMessages.RepairedVehicles, num);
        }

        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
            IVehicle vehiclee;
            if (vehicleType == "CargoVan")
            {
                vehiclee = new CargoVan(brand, model, licensePlateNumber);
            }
            else if (vehicleType == "PassengerCar")
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
            List<IUser> useri = users.GetAll().OrderByDescending(u => u.Rating).ThenBy(u => u.LastName).ThenBy(u => u.FirstName).ToList();
        

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*** E-Drive-Rent ***");

            foreach (IUser user in useri)
            {
                sb.AppendLine(user.ToString());
            }
        
          return sb.ToString().Trim();
        
        }
    }
}
