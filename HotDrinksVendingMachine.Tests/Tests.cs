using HotDrinksVendingMachine.Drinks;
using Moq;

namespace HotDrinksVendingMachine.Tests
{
    public class Tests
    {       
        private DrinksService drinksService;
        private Mock<IServiceProvider> serviceProvider;
        [SetUp]
        public void Setup()
        {
            serviceProvider = new Mock<IServiceProvider>();
        }

        [Test]
        public void ExpressoDrinkCost_Should_Return_Ingredients_Prices()
        {
            // GIVEN
            var drinkName = DrinkNameEnum.Expresso;
            serviceProvider.Setup(s => s.GetService(typeof(Expresso)))
				.Returns(new Expresso());
            drinksService = new DrinksService(serviceProvider.Object);

            // WHEN
            decimal drinkPrice = drinksService.GetDrinkCost(drinkName);

            // THEN
            Assert.That(drinkPrice, Is.EqualTo(1 + 0.2m));
        }

        [Test]
        public void LongDrinkCost_Should_Return_Ingredients_Prices()
        {
            // GIVEN
            var drinkName = DrinkNameEnum.LongCoffee;
            serviceProvider.Setup(s => s.GetService(typeof(LongCoffee)))
                .Returns(new LongCoffee());
            drinksService = new DrinksService(serviceProvider.Object);

            // WHEN
            decimal drinkPrice = drinksService.GetDrinkCost(drinkName);

            // THEN
            Assert.That(drinkPrice, Is.EqualTo(1 + 0.2m*2));
        }

        [Test]
        public void CappucinoDrinkCost_Should_Return_Ingredients_Prices()
        {
            // GIVEN
            var drinkName = DrinkNameEnum.Cappucino;
            serviceProvider.Setup(s => s.GetService(typeof(Cappucino)))
                .Returns(new Cappucino());
            drinksService = new DrinksService(serviceProvider.Object);

            // WHEN
            decimal drinkPrice = drinksService.GetDrinkCost(drinkName);

            // THEN
            Assert.That(drinkPrice, Is.EqualTo(1 + 1 + 0.5m + 0.2m ));
        }

        [Test]
        public void HotTeaDrinkCost_Should_Return_Ingredients_Prices()
        {
            // GIVEN
            var drinkName = DrinkNameEnum.HotTea;
            serviceProvider.Setup(s => s.GetService(typeof(HotTea)))
                .Returns(new HotTea());
            drinksService = new DrinksService(serviceProvider.Object);

            // WHEN
            decimal drinkPrice = drinksService.GetDrinkCost(drinkName);

            // THEN
            Assert.That(drinkPrice, Is.EqualTo(2 + 0.2m*2));
        }

        [Test]
        public void HotChocolatDrinkCost_Should_Return_Ingredients_Prices()
        {
            // GIVEN
            var drinkName = DrinkNameEnum.HotChocolat;
            serviceProvider.Setup(s => s.GetService(typeof(HotChocolat)))
                .Returns(new HotChocolat());
            drinksService = new DrinksService(serviceProvider.Object);

            // WHEN
            decimal drinkPrice = drinksService.GetDrinkCost(drinkName);

            // THEN
            Assert.That(drinkPrice, Is.EqualTo(1*3 + 2*0.4m + 0.1m + 0.2m));
        }


        [Test]
        public void ExpressoDrinkPrice_Should_Return_Ingredients_Prices_With_Margin()
        {
            // GIVEN
            var drinkName = DrinkNameEnum.Expresso;
            serviceProvider.Setup(s => s.GetService(typeof(Expresso)))
                .Returns(new Expresso());
            drinksService = new DrinksService(serviceProvider.Object);

            // WHEN
            decimal drinkPrice = drinksService.GetDrinkPrice(drinkName);

            // THEN
            Assert.That(drinkPrice, Is.EqualTo((1 + 0.2m) * 1.3m));
        }


        [Test]
        public void SetExpresso_Should_Return_Drink_Cost_And_take_No_Params()
        {
            var expresso = new Expresso();

            // WHEN
            decimal expressoPrice = expresso.Ingredients();

            // THEN
            Assert.That(expressoPrice, Is.EqualTo(1 + 0.2m));
        }

        [Test]
        public void SetLongCoffee_Should_Return_Drink_Cost_And_take_No_Params()
        {
            var longCoffee = new LongCoffee();

            // WHEN

            decimal longCoffeePrice = longCoffee.Ingredients();

            // THEN

            Assert.That(longCoffeePrice, Is.EqualTo(1 + 0.2m * 2));
        }

        [Test]
        public void SetCappucino_Should_Return_Drink_Cost_And_take_No_Params()
        {
            var cappucino = new Cappucino();

            // WHEN

            decimal cappucinoPrice = cappucino.Ingredients();

            // THEN

            Assert.That(cappucinoPrice, Is.EqualTo(1 + 1 + 0.2m + 0.5m));

        }

        [Test]
        public void SetHotChocolat_Should_Return_Drink_Cost_And_take_No_Params()
        {
            var hotChocolat = new HotChocolat();

            // WHEN

            decimal hotChocolatPrice = hotChocolat.Ingredients();


            // THEN

            Assert.That(hotChocolatPrice, Is.EqualTo(1 * 3 + 2 * 0.4m + 0.2m + 0.1m));

        }


        [Test]
        public void SetHotTea_Should_Return_Drink_Cost_And_take_No_Params()
        {
            var hotTea = new HotTea();
            // WHEN

            decimal hotTeaPrice = hotTea.Ingredients();

            // THEN
            Assert.That(hotTeaPrice, Is.EqualTo(2 + 0.2m * 2));
        }
    }
}