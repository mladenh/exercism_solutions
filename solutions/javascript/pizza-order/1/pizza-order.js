/// <reference path="./global.d.ts" />
//
// @ts-check

/**
 * Determine the prize of the pizza given the pizza and optional extras
 *
 * @param {Pizza} pizza name of the pizza to be made
 * @param {Extra[]} extras list of extras
 *
 * @returns {number} the price of the pizza
 */
export function pizzaPrice(pizza, ...extras) {
  const pizzaPrices = {
    'Margherita': 7,
    'Caprese': 9,
    'Formaggio': 10,
    'ExtraSauce': 1,
    'ExtraToppings': 2,
  }
  //base case
  if (extras.length === 0) {
    return pizzaPrices[pizza];
  }
  //recursive case
  const currentExtras = extras[0];
  const remainingExtras = extras.slice(1);
  const currentPrice = pizzaPrices[currentExtras] || 0;
  return  pizzaPrice(pizza, ...remainingExtras) + currentPrice;




}

/**
 * Calculate the prize of the total order, given individual orders
 *
 * @param {PizzaOrder[]} pizzaOrders a list of pizza orders
 * @returns {number} the price of the total order
 */
export function orderPrice(pizzaOrders) {
  //base case
/*   if (pizzaOrders.length === 0) {
    return 0;
  }
  //recursive case
   const currentOrder = pizzaOrders[0];
   const remainingOrders = pizzaOrders.slice(1);
   const currentPrice = pizzaPrice(currentOrder.pizza, ...currentOrder.extras);
   return currentPrice + orderPrice(remainingOrders); */

    return pizzaOrders.reduce((acc, currentOrder) => {
      const currentPrice = pizzaPrice(currentOrder.pizza, ...currentOrder.extras);
      return acc + currentPrice;
    }
    , 0);
}
