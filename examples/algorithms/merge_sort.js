const inputArr = ['e', 'g', 'a', 'd', 'f', 'c', 'b'];

const mergeArrays = (a, b) => {
    const c = []

  while (a.length && b.length) {
    c.push(a[0] > b[0] ? b.shift() : a.shift())
  }

  //if we still have values, let's add them at the end of `c`
  while (a.length) {
    c.push(a.shift())
  }
  while (b.length) {
    c.push(b.shift())
  }

  return c
}

const mergeSort = (a) => {
    if (a.length < 2) return a;
    const middle = Math.floor(a.length / 2);
    const a_l = a.slice(0, middle);
    const a_r = a.slice(middle, a.length)
    const sorted_l = mergeSort(a_l);
    const sorted_r = mergeSort(a_r);
    return mergeArrays(sorted_l, sorted_r);
}

console.log(mergeSort(inputArr));
