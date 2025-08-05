// @ts-check

/**
 * Calculates the sum of the two input arrays.
 *
 * @param {number[]} array1
 * @param {number[]} array2
 * @returns {number} sum of the two arrays
 */
export function twoSum(array1, array2) {
  let number = Number(array1.join("")) + Number(array2.join(""));
  return number;
}

/**
 * Checks whether a number is a palindrome.
 *
 * @param {number} value
 * @returns {boolean} whether the number is a palindrome or not
 */
export function luckyNumber(value) {
  let testString = String(value);
  let length = String(value).length;
  if (length === 1) return true;

  const numb = testString.split("");
  const numbToString = numb.join();
  const revnumb = numb.reverse();
  const numb2Tostring = revnumb.join();

  if (numbToString === numb2Tostring) {
    return true;
  }
  return false;
}

/**
 * Determines the error message that should be shown to the user
 * for the given input value.
 *
 * @param {string|null|undefined} input
 * @returns {string} error message
 */
export function errorMessage(input) {
  let output = null;

  if (input === null || input === undefined || input === "") {
    output = "Required field";
    return output;
  }

  if (!Number(input)) {
    output = "Must be a number besides 0";
    return output;
  } else {
    output = "";
    return output;
  }
}
