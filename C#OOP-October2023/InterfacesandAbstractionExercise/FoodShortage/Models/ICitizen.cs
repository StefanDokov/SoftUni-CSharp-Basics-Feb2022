using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models
{
    public interface ICitizen
    {

        int Age { get; }

        string Id { get; }

        string Birthdate { get; }
    }
}
