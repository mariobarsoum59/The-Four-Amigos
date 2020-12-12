using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Waste: IWaste
    {
        #region Instance Properties

        private int dishID;
        private string dishName;
        private int numWasted;
        private double lossFromWaste;
        private DateTime date;
        #endregion

        public int DishID
        {
            get
            {
                return dishID;
            }
            set
            {
                dishID = value;
            }
        }

        public string DishName
        {
            get
            {
                return dishName;
            }
            set
            {
                dishName = value;
            }
        }

        public int NumWasted
        {
            get
            {
                return numWasted;
            }
            set
            {
                numWasted = value;
            }
        }

        public double LossFromWaste
        {
            get
            {
                return lossFromWaste;
            }
            set
            {
                lossFromWaste = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        public Waste()
        {
            throw new System.NotImplementedException();
        }

        public Waste(int DishID, string DishName, int NumWasted, double LossFromWaste, DateTime Date)
        {
            this.dishID = DishID;
            this.dishName = DishName;
            this.numWasted = NumWasted;
            this.lossFromWaste = LossFromWaste;
            this.date = Date;
        }

    }

}
