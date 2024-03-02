using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MatthewAllison_st10269378_PROG6221_POE1.Classes
{
    internal class UserInterface
    {
        Recipe recipe = new Recipe();

        public void Start()
        {
            MainMenu();
        }

        public void MainMenu()
        {
            while (true)
            {
                string choice = "0";

                Console.WriteLine("RECIPE PROCESSING SOFTWARE");
                Console.WriteLine();
                Console.WriteLine("1. Create New Recipe");
                Console.WriteLine("2. View Existing Recipe");
                Console.WriteLine("3. Change Current Recipe");
                Console.WriteLine("4. Delete Existing Recipe");
                Console.WriteLine("5. Exit");
                Console.WriteLine("");
                Console.WriteLine("Enter choice: ");

                InputValidation.Option option = InputValidation.ValidateMainMenu(Console.ReadLine());
                if (option.value == null) {
                    continue;
                }
                choice = option.value;
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        CreateRecipe();
                        break;
                    case "2":
                        ViewRecipe();
                        break;
                    case "3":
                        ChangeRecipe();
                        break;
                    case "4":
                        DeleteRecipe();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private void DeleteRecipe()
        {
            recipe = new Recipe();
            Console.WriteLine("Recipe Deleted Successfully");
            Console.WriteLine();
        }

        private void ChangeRecipe()
        {
            Console.WriteLine("Adjusting Recipe Scale");
            Console.WriteLine("");
            Console.WriteLine($"Current scaling factor is: {recipe.Scaling_factor()}");
            Console.WriteLine();
            Console.WriteLine("1. Adjust scale");
            Console.WriteLine("2. Reset scael");
            Console.WriteLine("Enter choice: ");
            InputValidation.Option option = InputValidation.ValidateChangeRecipeMenu(Console.ReadLine());
            if (option.value == null)
            {
                Console.WriteLine("Pleas enter either 1 or 2.");
                Console.WriteLine();
                ChangeRecipe();
            }
            string choice = option.value;
            
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter new scaling factor in arabic numerals: ");
                    InputValidation.Option option1 = InputValidation.ValidateScalingFactor(Console.ReadLine());
                    if (option1.value == null)
                    {
                        Console.WriteLine("Please enter an arabic numeral");
                        Console.WriteLine("Scaling factor reset to: 1.");
                        recipe.Scaling_factor(1);
                    }
                    else
                    {
                    recipe.Scaling_factor(float.Parse(option1.value));
                    Console.WriteLine($"Scaling factor adjusted to: {recipe.Scaling_factor()}");
                    }
                    break;
                case "2":
                    Console.WriteLine("Scaling factor reset to: 1");
                    recipe.Scaling_factor(1);
                    break;
            }
            Console.WriteLine();
        }

        private void ViewRecipe()
        {
            Console.WriteLine($"RECIPE: {recipe.Name()}");
            Console.WriteLine($"Number of ingredients: {recipe.ingredients.Length}");
            Console.WriteLine($"Number of steps: {recipe.steps.Length}");
            Console.WriteLine();
            Console.WriteLine("LIST OF INGREDIENTS: ");

            for ( int i = 0; i < recipe.ingredients.Length; i++ )
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(recipe.ingredients[i].ToString(recipe.Scaling_factor()));
            }
            Console.WriteLine();

            Console.WriteLine("LIST OF STEPS: ");
            for ( int i = 0; i < recipe.steps.Length; i++ )
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(recipe.steps[i].Description());
            }
            
            Console.WriteLine();
            Console.WriteLine("END OF RECIPE.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }

        private void CreateRecipe()
        {
            Console.WriteLine("Enter recipe name: ");
            InputValidation.Option option = InputValidation.ValidateRecipeName(Console.ReadLine());
            if (option.value == null)
            {
                CreateRecipe();
            }
            else
            {
                recipe.Name(option.value);
            }
            Console.WriteLine();


            
            int num_ingredients;
            while (true)
            {
                Console.WriteLine("Enter number of ingredients: ");
                InputValidation.Option option1 = InputValidation.ValidateNumberIngredients(Console.ReadLine());
                if (option1.value == null)
                {
                    continue;
                }
                else
                {
                    num_ingredients = int.Parse(option1.value);
                    break;
                }
            }
            recipe.MakeIngriedientsArray(num_ingredients);
            Console.WriteLine();

            for (int i = 0; i < recipe.ingredients.Length; i++)
            {
                Console.WriteLine($"Ingredient {i + 1}:");
                while (true)
                {
                    
                    Console.WriteLine("Enter ingriedient name: ");
                    InputValidation.Option option1 = InputValidation.ValidateIngredientName(Console.ReadLine());
                    if (option1.value == null)
                    {
                        continue ;
                    }
                    recipe.ingredients[i].Name = option1.value;
                    Console.WriteLine();
                    break;
                }

                Console.WriteLine("MEASUREMENT UNITS: ");
                Console.WriteLine("-------------------");

                foreach (
                    Recipe.CookingMeasurement measurement in Enum.GetValues(
                        typeof(Recipe.CookingMeasurement)
                    )
                )
                {
                    Console.WriteLine(measurement);
                }
                Console.WriteLine("-------------------");
                while (true)
                {

                    Console.WriteLine("Enter one of the above: ");
                    string input = Console.ReadLine();
                    if ( input == null)
                    {
                        continue;
                    }

                    if (
                        Enum.TryParse<Recipe.CookingMeasurement>(
                            input,
                            true,
                            out Recipe.CookingMeasurement unit
                        )
                    )
                    {
                        recipe.ingredients[i].Unit = unit;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose a valid option");
                        continue;
                    }
                }
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine("Enter quantity: ");
                    InputValidation.Option option1 = InputValidation.ValidateQuantity(Console.ReadLine());
                    if (option1.value == null)
                    {
                        Console.WriteLine("Please use arabic numerals only.");
                        continue;

                    }
                    recipe.ingredients[i].Quantity = int.Parse(option1.value);
                    break;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Thank you, all ingredients captured");
            Console.WriteLine();

            int num_steps;
            while (true)
            {

                Console.WriteLine("Enter number of steps: ");
                InputValidation.Option option1 = InputValidation.ValidateQuantity(Console.ReadLine());
                if (option1.value == null)
                {
                    Console.WriteLine("Please use arabic numerals only.");
                    continue;
                }
                num_steps = int.Parse(option1.value);
                recipe.MakeStepsArray(num_steps);
                break;
            }
            Console.WriteLine();

            for (int i = 0; i < num_steps; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Please enter step {i + 1}");
                    Recipe.Step step = new Recipe.Step();
                    step.Position(i);
                    step.Description(Console.ReadLine());
                    if (step.Description() == null)
                    {
                        continue;
                    }
                    Console.WriteLine();
                    recipe.steps[i] = step;
                    break;
                }
            }
            Console.WriteLine("Thank you. Recipe has been captured");
            Console.WriteLine();
        }
    }
}
