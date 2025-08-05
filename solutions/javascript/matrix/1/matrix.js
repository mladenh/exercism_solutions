//
// This is only a SKELETON file for the 'Matrix' exercise. It's been provided as a
// convenience to get you started writing code faster.
//
export class Matrix { 
  constructor(string) {
    this.string = string;
  }

  get rows() {
    let rows = this.string.split('\n');
    let rowArray = [];
    for (let i = 0; i < rows.length; i++) {
      rowArray.push(rows[i].split(' '));
    }
    return rowArray.map(row => row.map(Number));
  }

  get columns() {
    let columns = [];
    for (let i = 0; i < this.rows[0].length; i++) {
      let column = [];
      for (let j = 0; j < this.rows.length; j++) {
        column.push(this.rows[j][i]);
      }
      columns.push(column);
    }
    return columns.map(column => column.map(Number));
  }
}
