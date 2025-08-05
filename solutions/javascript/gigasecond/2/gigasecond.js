//
// This is only a SKELETON file for the 'Gigasecond' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const gigasecond = (moment) => {

const date = new Date(moment);
const gigasecond = Math.pow(10, 9) *1000; // One gigasecond in milliseconds
date.setTime(date.getTime() + gigasecond);

return date;
};
