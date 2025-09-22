using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingSharp.Domain
{
    public class RecipeStep
    {
        public string Description { get; set; }
        public int Order { get; set; }
        public RecipeStep(string description, int order)
        {
            Description = description;
            Order = order;
        }
        //public UpdateAtributes(string description, int order)
    }
}
