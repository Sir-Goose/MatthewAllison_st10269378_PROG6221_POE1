using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewAllison_st10269378_PROG6221_POE1.Classes
{
    internal class Recipe 
    {
        private struct Ingredient
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

        private struct Step
        {
            private int position;
            private string description;
        }



        int Num_Ingredients;
        int Num_Setps;
        Step[]? steps;
        Ingredient[]? ingredients;
        

    }

}
