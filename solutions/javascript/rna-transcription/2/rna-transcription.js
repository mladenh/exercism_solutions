const transcription = { G: "C", C: "G", T: "A", A: "U" };

// export const toRna = (nucleotide) => {
//   let output = "";

//   for (let element of nucleotide) {
//     output += transcription[element];
//   }

//   return output;
// };

 export const toRna = (nucleotide) => nucleotide.split("").map(element => transcription[element]).join("");