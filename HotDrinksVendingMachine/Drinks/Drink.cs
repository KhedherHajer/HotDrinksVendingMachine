using HotDrinksVendingMachine.Ingredients;

namespace HotDrinksVendingMachine.Drinks
{
	public class Drink
	{
		private readonly List<IngredientOrder> _ingredients;
		public Drink(List<IngredientOrder> ingredients)
		{
			_ingredients = ingredients;
		}

		public decimal Ingredients()
		{
			return _ingredients.Select(i => i.Price).Sum();
		}
	}
}