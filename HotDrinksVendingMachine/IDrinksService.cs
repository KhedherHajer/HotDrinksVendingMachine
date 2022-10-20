using HotDrinksVendingMachine.Drinks;

namespace HotDrinksVendingMachine
{
	public interface IDrinksService
	{
		decimal GetDrinkPrice(DrinkNameEnum name);
		decimal GetDrinkCost(DrinkNameEnum name);
		Drink GetDrink(DrinkNameEnum name);
	}
}
