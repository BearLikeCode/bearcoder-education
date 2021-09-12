let inputArr = [5,2,4,6,1,3];

function insertionSort(inputArr) {
    let n = inputArr.length;
    for (let i = 1; i < n; i++) {
        let current = inputArr[i];
        let j = i - 1;
        while ((j > -1) && (current < inputArr[j])) {
            inputArr[j+1] = inputArr[j];
            j--;
        }
        inputArr[j+1] = current;
    }
    return inputArr;
}

insertionSort(inputArr);
console.log(inputArr);
