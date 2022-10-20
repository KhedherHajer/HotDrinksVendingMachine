using HotDrinksVendingMachine.Ingredients;

namespace HotDrinksVendingMachine.Drinks
{
	public class HotTea : Drink
	{
		public HotTea() : base(new List<IngredientOrder> {
			new IngredientOrder { Ingredient = new Tea(), Quantity = 1 },
			new IngredientOrder { Ingredient = new Water(), Quantity = 2 } })
		{
		}
	}
}