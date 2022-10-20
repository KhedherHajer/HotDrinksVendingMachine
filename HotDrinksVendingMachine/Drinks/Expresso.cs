using HotDrinksVendingMachine.Ingredients;

namespace HotDrinksVendingMachine.Drinks
{
	public class Expresso : Drink
	{
		public Expresso() : base(new List<IngredientOrder> {
			new IngredientOrder { Ingredient = new Coffee(), Quantity = 1 },
			new IngredientOrder { Ingredient = new Water(), Quantity = 1 } })
		{
		}
	}
}
