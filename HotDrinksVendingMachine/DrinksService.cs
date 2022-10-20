using HotDrinksVendingMachine.Drinks;

namespace HotDrinksVendingMachine
{
	public class DrinksService : IDrinksService
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly Dictionary<DrinkNameEnum, Type> _demultiplexerPerDrinkName = new Dictionary<DrinkNameEnum, Type>
		{
			[DrinkNameEnum.Expresso] = typeof(Expresso),
			[DrinkNameEnum.LongCoffee] = typeof(LongCoffee),
			[DrinkNameEnum.Cappucino] = typeof(Cappucino),
			[DrinkNameEnum.HotChocolat] = typeof(HotChocolat),
			[DrinkNameEnum.HotTea] = typeof(HotTea)
		};
		public DrinksService(IServiceProvider serviceProvider)
		{
			_serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
		}

		public Drink GetDrink(DrinkNameEnum drinkName)
		{
			if (_demultiplexerPerDrinkName.TryGetValue(drinkName, out Type drinkClass))
			{
				if (_serviceProvider.GetService(drinkClass) is Drink drink)
				{
					return drink;
				}
			}
			throw new InvalidOperationException($"Could not find the matching service for drinkName {drinkName}");
		}

		public decimal GetDrinkCost(DrinkNameEnum drinkName)
		{
			return GetDrink(drinkName).Ingredients();
		}

		public decimal GetDrinkPrice(DrinkNameEnum drinkName)
		{
			return GetDrinkCost(drinkName) * 1.3m;
		}
	}
}