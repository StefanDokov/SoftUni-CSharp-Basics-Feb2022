using RobotService.Models.Contracts;
using RobotService.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Repositories
{
    public class RobotRepository : IRepository<IRobot>
    {
        private List<IRobot> robotes;
        public RobotRepository() 
        {
            robotes = new List<IRobot>();
        }
        public void AddNew(IRobot model)
        {
            robotes.Add(model);
        }

        public IRobot FindByStandard(int interfaceStandard)
        {
            return robotes.FirstOrDefault(r => r.InterfaceStandards.Any(s => s == interfaceStandard));
        }

        public IReadOnlyCollection<IRobot> Models()
        {
            return robotes.AsReadOnly();
        }

        public bool RemoveByName(string typeName)
        {
            return robotes.Remove(robotes.FirstOrDefault(r => r.Model == typeName));
        }
    }
}
