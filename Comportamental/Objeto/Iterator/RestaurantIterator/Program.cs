
using RestaurantIterator;
using RestaurantIterator.Bakery;
using RestaurantIterator.CoffeeShop;
using RestaurantIterator.Diner;

BakeryMenu bakeryMenu = new BakeryMenu();
DinerMenu dinerMenu = new DinerMenu();
CoffeeShopMenu coffeeShopMenu = new CoffeeShopMenu();   

Waiter waiter = new Waiter(bakeryMenu, dinerMenu, coffeeShopMenu);

waiter.PrintMenu();