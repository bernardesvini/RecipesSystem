using RecipesSystem.Models;
using System.Collections.Generic;

namespace RecipesSystem.Services
{
    public interface IIngredientService
    {
        List<Ingredient> RetrieveAll();
        Ingredient Retrieve(int id);
        void Create(Ingredient ingredient);
        void Update(Ingredient ingredient);
        void Delete(int id);
    }
}
