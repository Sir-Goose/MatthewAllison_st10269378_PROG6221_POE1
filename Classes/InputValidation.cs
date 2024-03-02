﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MatthewAllison_st10269378_PROG6221_POE1.Classes
{
    /// <summary>
    /// This is the InputValidation class. All user input is parsed through the various static methods. 
    /// This is to improve programme stablity by handelling any null values as well as any other
    /// bad inputs.
    /// </summary>
    internal class InputValidation
    {
        /// <summary>
        /// This is the option struct. It contains two values and is the type always returned from
        /// the input validation methods. It will sometimes have a string value to be used by
        /// the original calling method if the parsed input was valid.
        /// </summary>
        public struct Option
        {
            public string? value; // valid values
            public bool? valid; // is valid yes no
        }
        //------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// This is the ValidateMainMenu method.
        /// It makes sure something other than null has been provided.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        //----------------------------------------------------------------------------//
        /// <summary>
        /// This is the ValidateChangeRecipeMenu method.
        /// It trims any leading and trailing whitespace
        /// and makes sure null was not provided.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        //---------------------------------------------------------------------------------//
        /// <summary>
        /// This is the ValidateScalingFactor method.
        /// It ensures that the provided input is not null.
        /// It trims any leading and trailing whitespace and
        /// ensures the value can be used as a float.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        //-----------------------------------------------------------------------//
        /// <summary>
        /// This is the ValidateRecipeName method.
        /// It just checks that a null value was not provided 
        /// and then removes any leading or trailing whitespace.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

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
        //-----------------------------------------------------------------------//
        /// <summary>
        /// This is the ValidateNumberIngredients method.
        /// It checks that the provided value is not null.
        /// It trims any leading and trailing whitespace and 
        /// ensures that the value can be parsed as an int.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        //----------------------------------------------------------------------------//
        /// <summary>
        /// This is the ValidateIngredientName method.
        /// It checks for null values.
        /// Trims leading and trailing whitespace
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
        //-----------------------------------------------------------------//
        /// <summary>
        /// This is the ValidateQuantity method.
        /// It checks for null values.
        /// Trims any leading and trailing whitespace 
        /// and ensures the value can be parsed as an int.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
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
//--------------------------------------------------------------------END-OF-FILE---------------------------------------------------------------//
