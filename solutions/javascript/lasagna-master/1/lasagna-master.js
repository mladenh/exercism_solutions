/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 * @param {number} remainingTime
 */
export function cookingStatus(remainingTime) {
  let answer = "";
  if (remainingTime === 0) {
    answer = "Lasagna is done.";
    return answer;
  }
  if (remainingTime > 0) {
    answer = "Not done, please wait.";
    return answer;
  }
  answer = "You forgot to set the timer.";
  return answer;
}

/**
 * @param {string | any[]} layers
 */
export function preparationTime(layers, time = 2) {
  return layers.length * time;
}

/**
 * @param {string[]} layers
 */
export function quantities(layers) {
  let amounts = {
    noodles: 0,
    sauce: 0,
  };

  layers.forEach((/** @type {string} */ element) => {
    if (element === "noodles") {
      amounts.noodles += 50;
    }
    if (element === "sauce") {
      amounts.sauce += 0.2;
    }
  });
  return amounts;
}

 /**
 * @param {string | any[]} friendList
 * @param {any[]} myList
 */
 export function addSecretIngredient(friendList, myList) {
  myList.push(friendList[friendList.length - 1]);
}

/**
 * Scales a recipe to the desired number of portions.
 * @param {Object} recipe - An object representing a recipe with amounts needed for 2 portions.
 * @param {number} portions - The desired number of portions.
 * @returns {Object} - An object representing the scaled recipe.
 */
export function scaleRecipe(recipe, portions){
    let newrecipe ={};
    Object.keys(recipe).forEach(element => {
    newrecipe[element] = recipe[element] * (portions /2)
});
return newrecipe;
}