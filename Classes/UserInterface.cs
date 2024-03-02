using System;
using System.Collections.Generic;
using System.Linq;
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
            string choice = "0";
            while (choice == "0")
            {
                Console.WriteLine("RECIPE PROCESSING SOFTWARE");
                Console.WriteLine("");
                Console.WriteLine("1. Create New Recipe");
                Console.WriteLine("2. View Existing Recipe");
                Console.WriteLine("3. Change Current Recipe");
                Console.WriteLine("");
                Console.WriteLine("Enter choice: ");
                choice = Console.ReadLine();
            }
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
            }
        }

        private void ChangeRecipe()
        {
            throw new NotImplementedException();
        }

        private void ViewRecipe()
        {
            throw new NotImplementedException();
        }

        private void CreateRecipe()
        {
            Console.WriteLine("Enter recipe name: ");
            try
            {
                recipe.Name(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("");
            }

            Console.WriteLine("Enter number of ingredients: ");
            int num_ingredients = int.Parse(Console.ReadLine());
            recipe.MakeIngriedientsArray(num_ingredients);

            
            for (int i = 0; i < recipe.ingredients.Length; i++)
            {
                Console.WriteLine("Ingriedient Name: ");
                recipe.ingredients[i].Name = Console.ReadLine();

                Console.WriteLine("Measurement Unit: ");
                Console.WriteLine("Enter one of the following: ");

                foreach (
                    Recipe.CookingMeasurement measurement in Enum.GetValues(
                        typeof(Recipe.CookingMeasurement)
                    )
                )
                {
                    Console.WriteLine(measurement);
                }
                string input = Console.ReadLine();

                if (
                    Enum.TryParse<Recipe.CookingMeasurement>(
                        input,
                        true,
                        out Recipe.CookingMeasurement unit
                    )
                )
                {
                    recipe.ingredients[i].Unit = unit;
                }
                Console.WriteLine("Quantity: ");
                recipe.ingredients[i].Quantity = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Thank you, all ingredients captured");

            Console.WriteLine("Enter number of steps: ");
            int num_steps = int.Parse(Console.ReadLine());
            recipe.MakeStepsArray(num_steps);

            for (int i = 0;i < num_steps; i++)
            {
                Console.WriteLine($"Please enter step {i}");
                Recipe.Step step = new Recipe.Step();
                step.Position(i);
                step.Description(Console.ReadLine());
                Console.WriteLine();

            }
            Console.WriteLine("Thank you. Recipe has been captured");

        }
    }
}
