//
// This is only a SKELETON file for the 'Pangram' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const isPangram = (input) => {
  const alphabet = 'abcdefghijklmnopqrstuvwxyz';


 for (let i = 0; i < alphabet.length; i++) {

  if(!input.toLowerCase().includes(alphabet[i])){
    return false;
  }
}
return true;
};
