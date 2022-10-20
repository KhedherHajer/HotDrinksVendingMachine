using System.ComponentModel;

namespace HotDrinksVendingMachine.Drinks
{
	public enum DrinkNameEnum
	{
		[Description("Expresso")]
		Expresso,
		[Description("Allongé")]
		LongCoffee,
		[Description("Cappucino")]
		Cappucino,
		[Description("Chocolat")]
		HotChocolat,
		[Description("Thé")]
		HotTea,
	}
}
