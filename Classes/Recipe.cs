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
            private string name;
            private int quantity;
            private CookingMeasurement unit;

            public string Name
            {
                get => name;
                set => name = value;
            }
            public int Quantity
            {
                get => quantity;
                set => quantity = value;
            }
            public CookingMeasurement Unit
            {
                get => unit;
                set => unit = value;
            }

            public void multiplyQuantity(int factor)
            {
                quantity *= factor;
            }
            new public string ToString(float scaling_factor)
            {
                string output = "";
                output += quantity * scaling_factor;
                output += " of ";
                output += name;
                output += ".";

                return output;
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

            public void Position(int pos)
            {
                this.position = pos;
            }
            public int Position()
            {
                return this.position;
            }

            public void Description(string description)
            {
                this.description = description;
            }
            public string Description()
            {
                return description;
            }
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

        private string name = "";
        private int num_steps = 0;
        private float scaling_factor = 1; 

        public void Name(string name)
        {
            this.name = name;
        }

        public string Name()
        {
            return name;
        }

        public void Num_steps(int num)
        {
            this.num_steps = num;
        }

        public int Num_steps()
        {
            return this.num_steps;
        }
        public void Scaling_factor(float scaling_factor)
        {
            this.scaling_factor = scaling_factor;
        }
        public float Scaling_factor()
        {
            return this.scaling_factor;
        }
    }
}
