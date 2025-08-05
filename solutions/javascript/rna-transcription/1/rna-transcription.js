//
// This is only a SKELETON file for the 'RNA Transcription' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const toRna = (nucleotide) => {
  let output ="";

  for (let element of nucleotide) {
    if(element === 'C')
    output += 'G';
    else if(element ==='G')
    output +='C';
    else if (element === 'T')
    output +='A';
    else if(element === 'A')
    output +='U';
    
  };
  return output;
};
