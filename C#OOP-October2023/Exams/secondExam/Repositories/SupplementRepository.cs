﻿using RobotService.Models.Contracts;
using RobotService.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Repositories
{
    public class SupplementRepository : IRepository<ISupplement>
    {
        private List<ISupplement> supplements;
        public SupplementRepository() 
        {
            supplements = new List<ISupplement>();
        }
        public void AddNew(ISupplement model)
        {
            supplements.Add(model);
        }

        public ISupplement FindByStandard(int interfaceStandard)
        {
            return supplements.FirstOrDefault(s => s.InterfaceStandard == interfaceStandard);
        }

        public IReadOnlyCollection<ISupplement> Models()
        {
            return supplements.AsReadOnly();
        }

        public bool RemoveByName(string typeName)
        {
            return supplements.Remove(supplements.FirstOrDefault(s => s.GetType().Name == typeName));
        }
    }
}
