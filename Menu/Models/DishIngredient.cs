namespace Menu.Models
{
    public class DishIngredient
    {
        public int DishId { get; set; }
        public Dish Dishes { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredients { get; set; }
    }
}
