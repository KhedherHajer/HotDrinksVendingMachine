using HotDrinksVendingMachine.Ingredients;

namespace HotDrinksVendingMachine.Drinks
{
	public class LongCoffee : Drink
	{
		public LongCoffee() : base(new List<IngredientOrder> {
			new IngredientOrder { Ingredient = new Coffee(), Quantity = 1 },
			new IngredientOrder { Ingredient = new Water(), Quantity = 2 } })
		{
		}
	}
}
