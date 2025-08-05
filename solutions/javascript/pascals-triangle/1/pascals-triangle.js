export const rows = (numRows) => {

//if number of rows greater than 0 then do: in a loop generate new row with with number of elements equal to number of rows. 
//First element and last element are 1, rest are sum of previous two elements from previous row. For element on position i, 
//add elements from past row at position i-1 and i.
  if (numRows <= 0) return [];

  const triangle = [[1]];

  for (let row = 1; row < numRows; row++) {
    const newRow = [1];
    const prevRow = triangle[row - 1];

    for (let i = 1; i < row; i++) {
      newRow[i] = prevRow[i - 1] + prevRow[i];
    }

    newRow.push(1);
    triangle.push(newRow);
  }

  return triangle;
}
