using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Dough
    {
        private Dictionary<string, double> allFlourTypes = new Dictionary<string, double>()
        {
             {"white", 1.5 },
             {"wholegrain", 1 }
        };

        public Dictionary<string, double> AllBakingTechniques = new Dictionary<string, double>()
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0 }
        };

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public int Weight
        {
            get { return weight; }
            private set
            {
                if (value > 200 || value < 1)
                {
                    throw new ArgumentException("Dough weight should be in the range");
                }
                weight = value;
            }
        }
        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (!AllBakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }
        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (!allFlourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public double Calculator => 2 * weight * allFlourTypes[FlourType.ToLower()] * AllBakingTechniques[BakingTechnique.ToLower()];


        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }
    }
}
