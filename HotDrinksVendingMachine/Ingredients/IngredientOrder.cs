namespace HotDrinksVendingMachine.Ingredients
{
	public class IngredientOrder
	{
		public Ingredient Ingredient { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get { return decimal.Multiply(Ingredient.GetPrice(), Quantity); } }
	}
}
