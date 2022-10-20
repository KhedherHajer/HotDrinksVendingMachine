using HotDrinksVendingMachine.Ingredients;

namespace HotDrinksVendingMachine.Drinks
{
	public class HotChocolat : Drink
	{
		public HotChocolat() : base(new List<IngredientOrder> {
			new IngredientOrder { Ingredient = new Chocolat(), Quantity = 3 },
			new IngredientOrder { Ingredient = new Milk(), Quantity = 2 },
			new IngredientOrder { Ingredient = new Sugar(), Quantity = 1 },
			new IngredientOrder { Ingredient = new Water(), Quantity = 1 } })
		{
		}
	}
}
