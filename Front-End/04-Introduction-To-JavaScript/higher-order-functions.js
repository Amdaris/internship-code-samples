const arr = [1, 2, 3, 4, 5];

const mappedArr = arr.map((elm) => elm * 2); // [2, 4, 6, 8, 10]

const filteredArr = arr.filter((elm) => elm % 2 == 0); // [2, 4]

const sumOfArrElms = arr.reduce((elm, acc) => acc + elm, 0); // 15

const foundFive = arr.findIndex((elm) => elm == 5); // 4

arr.forEach((elm) => console.log(elm)); // Will log to the console all elements