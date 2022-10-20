namespace HotDrinksVendingMachine.Ingredients
{
	public abstract class Ingredient 
	{
		private decimal _price;
		public Ingredient(decimal price)
		{
			_price = price;
		}
		public decimal GetPrice()
		{
			return _price;
		}
	}
}