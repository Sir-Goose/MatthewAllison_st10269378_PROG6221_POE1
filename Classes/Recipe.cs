using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewAllison_st10269378_PROG6221_POE1.Classes
{
    internal class Recipe 
    {
        public struct Ingredient
        {
            public string name;
            public int quantity;
            public CookingMeasurement unit; 

            public void multiplyQuantity(int factor)
            {
                quantity *= factor;
            }

            public Ingredient(string name,  int quantity, CookingMeasurement unit)
            {
                this.name = name;
                this.quantity = quantity;
                this.unit = unit;
            }
        }

        public enum CookingMeasurement
        {
            Teaspoon,
            Tablespoon,
            Cup,
            Pint,
            Quart,
            Gallon,
            Milliliter,
            Liter,
            Gram,
            Kilogram,
            Ounce,
            Pound
        }

        public struct Step
        {
            private int position;
            private string description;
        }

        public Step[]? steps;
        public Ingredient[]? ingredients;
        
        public void MakeIngriedientsArray(int num)
        {
            Ingredient[] ingredients = new Ingredient[num];
            this.ingredients = ingredients;
        }
        public void MakeStepsArray(int num)
        {
            Step[] steps = new Step[num];
            this.steps = steps;
        }


        public string Name { get => Name; set => Name = value; }
        public int Num_Steps { get => Num_Steps; set => Num_Steps = value; }
    }

}
