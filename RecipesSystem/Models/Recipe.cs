using RecipesSystem.Models.Enums;

namespace RecipesSystem.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Difficult Difficult { get; set; }
        public Category Category { get; set; }
        public int PreparationTime { get; set; }
        public int IngredientId { get; set; }

        public Recipe(int id, string title, Difficult difficult, Category category, int preparationTime, int ingredientId)
        {
            Id = id;
            Title = title;
            Difficult = difficult;
            Category = category;
            PreparationTime = preparationTime;
            IngredientId = ingredientId;
        }

        public Recipe()
        {
        }
    }
}
