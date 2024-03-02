using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatthewAllison_st10269378_PROG6221_POE1.Classes
{
    internal class InputValidation
    {
        public struct Option
        {
            public string? value;
            public bool? valid;
        }

        
        public static Option ValidateMainMenu(string? input)
        {
            Option option = new Option();
            if (input != null)
            {
                option.value = input.Trim();
                option.valid = true;
            }
            else
            {
                option.valid = false;
            }
            return option;
        }

        public static Option ValidateChangeRecipeMenu(string? input)
        {
            Option option = new Option();
            if (input != null)
            {
                option.value = input.Trim();
                option.valid = true;
            }
            else
            {
                option.valid = false;
            }
            return option;
        }

        internal static Option ValidateScalingFactor(string? input)
        {
            Option option = new Option();
            if (input != null)
            {
                input = input.Trim();
                try
                {
                    float.Parse(input);
                    option.valid = true;
                    option.value = input;
                }
                catch
                {
                    option.valid = false;
                    return option;
                }
            }
            return option;
        }

        internal static Option ValidateRecipeName(string? input)
        {
            Option option = new Option();
            if (input != null)
            {
                option.value = input.Trim();
                option.valid = true;
            }
            else
            {
                option.valid = false;
            }
            return option;
        }

        internal static Option ValidateNumberIngredients(string? input)
        {
            Option option = new Option();
            if (input != null)
            {
                input = input.Trim();
                try
                {
                    int.Parse(input);
                    option.valid = true;
                    option.value = input;
                }
                catch
                {
                    option.valid = false;
                    return option;
                }
            }
            return option;
        }

        internal static Option ValidateIngredientName(string? input)
        {
            Option option = new Option();
            if (input != null)
            {
                option.value = input.Trim();
                option.valid = true; 
            }
            else
            {
                option.valid = false;
            }
            return option;
        }

        internal static Option ValidateQuantity(string? input)
        {
            Option option = new Option();
            if (input != null)
            {
                input = input.Trim();
                try
                {
                    int.Parse(input);
                    option.valid = true;
                    option.value = input;
                }
                catch
                {
                    option.valid = false;
                    return option;
                }
            }
            return option;

        }
    }
}
