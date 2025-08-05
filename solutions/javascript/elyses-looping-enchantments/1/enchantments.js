// @ts-check

/**
 * Determine how many cards of a certain type there are in the deck
 *
 * @param {number[]} stack
 * @param {number} card
 *
 * @returns {number} number of cards of a single type there are in the deck
 */
export function cardTypeCheck(stack, card) {
  let cardcounter = 0;
  for (const currentCard of stack) {
    if (card === currentCard) {
      cardcounter++;
    }
  }
  return cardcounter;
}

/**
 * Determine how many cards are odd or even
 *
 * @param {number[]} stack
 * @param {boolean} type the type of value to check for - odd or even
 * @returns {number} number of cards that are either odd or even (depending on `type`)
 */
export function determineOddEvenCards(stack, type) {
  let evencounter = 0;
  let oddcounter = 0;
  stack.forEach((card) => {
    if (card % 2 === 0) {
      evencounter++;
    }
    if (card % 2 !== 0) {
      oddcounter++;
    }
  });
  if (type === true) {
    return evencounter;
  } else {
    return oddcounter;
  }
}
