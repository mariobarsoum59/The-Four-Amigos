using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
        public interface IIngredients
        {
            int ItemID { get; set; }
            string ItemName { get; set; }
            string Description { get; set; }
            double Price { get; set; }
            int Quantity { get; set; }
            string Category { get; set; }
        }
    
}
