//
// This is only a SKELETON file for the 'Gigasecond' exercise. It's been provided as a
// convenience to get you started writing code faster.
//
const GIGASECOND = Math.pow(10, 9) *1000; // One gigasecond in milliseconds

export const gigasecond = (moment) => {
  
  const date = new Date(moment);
date.setTime(date.getTime() + GIGASECOND);

return date;
};
