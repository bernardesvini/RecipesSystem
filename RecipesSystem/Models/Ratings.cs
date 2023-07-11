namespace RecipesSystem.Models
{
    public class Ratings
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int RecipeID { get; set; }

        public Ratings(int id, int rating, int recipeID)
        {
            Id = id;
            Rating = rating;
            RecipeID = recipeID;
        }

        public Ratings()
        {
        }
    }
}
