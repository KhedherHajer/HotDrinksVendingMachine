using HotDrinksVendingMachine.Ingredients;

namespace HotDrinksVendingMachine.Drinks
{
	public class Cappucino : Drink
	{
		public Cappucino() : base(new List<IngredientOrder> {
			new IngredientOrder { Ingredient = new Coffee(), Quantity = 1 },
			new IngredientOrder { Ingredient = new Chocolat(), Quantity = 1 },
			new IngredientOrder { Ingredient = new Cream(), Quantity = 1 },
			new IngredientOrder { Ingredient = new Water(), Quantity = 1 } })
		{
		}
	}
}
