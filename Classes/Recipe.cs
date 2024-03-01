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
            private string name;
            private int quantity;
            private UnitOfMeasurement unit; 

        }

        public enum UnitOfMeasurement
        {
            table_spoon,
            grams,
            ounces,
            
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
