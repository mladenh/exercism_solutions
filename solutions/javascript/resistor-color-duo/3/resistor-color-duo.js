//
// This is only a SKELETON file for the 'Resistor Color Duo' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const decodedValue = (colors) => {
  const firstTwoColors = colors.slice(0,2);
  const digits = firstTwoColors.map(colorToDigit);
  return Number(digits.join(''));
}

const colorToDigit = (color) =>{
  return COLORS.indexOf(color);
}

export const COLORS = [
  "black",
  "brown",
  "red",
  "orange",
  "yellow",
  "green",
  "blue",
  "violet",
  "grey",
  "white",
];