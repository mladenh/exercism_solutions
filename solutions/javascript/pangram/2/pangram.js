/* export const isPangram = (input) => {
  const alphabet = 'abcdefghijklmnopqrstuvwxyz';


 for (let i = 0; i < alphabet.length; i++) {

  if(!input.toLowerCase().includes(alphabet[i])){
    return false;
  }
}
return true;
}; */

export function isPangram(input) {
  return new Set(input.toLowerCase().match(/[a-z]/g)).size === 26;
}
