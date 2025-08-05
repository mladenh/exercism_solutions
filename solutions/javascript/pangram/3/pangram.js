/* export const isPangram = (input) => {
  const alphabet = 'abcdefghijklmnopqrstuvwxyz';


 for (let i = 0; i < alphabet.length; i++) {

  if(!input.toLowerCase().includes(alphabet[i])){
    return false;
  }
}
return true;
}; */

/* export function isPangram(input) {
  return new Set(input.toLowerCase().match(/[a-z]/g)).size === 26; //The function returns if the size of the Set is 26. If the number of unique letters in the Set is equal to the 26 letters in the alphabet, then the function will return true.
} */

export function isPangram(input) {
  const inputLowered = input.toLowerCase();
  
  //return 'abcdefghijklmnopqrstuvwxyz'.split('').every(letter => inputLowered.includes(letter));
  return [...'abcdefghijklmnopqrstuvwxyz'].every(letter => inputLowered.includes(letter)); //The function returns if every letter in the alphabet is included in the inputLowered string.
}
