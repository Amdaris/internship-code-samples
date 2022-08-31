// Initializing a new `fruits` array
const fruits = ["Banana", "Orange", "Apple", "Mango"];

fruits[0]; // Banana

fruits[4] = "Pineapple"; // Add "Pineapple" on the 4th position of our array

fruits.length; // Get the length or the number of elements in an array

fruits.push("Watermelon"); // Add "Watermelon" string element to our array

fruits.pop(); // Remove last array element ("Watermelon")

fruits; // ["Banana", "Orange", "Apple", "Mango", "Pineapple"]

const newArr = [1, 2];

newArr[4] = 3;

newArr[3] = 4;

newArr; // [1, 2, 4, 3];

const mixedArray = [
  "Mike Ross",
  12,
  14,
  729,
  { type: "animal" },
  [1, 2, 3, 4, 5],
];

mixedArray[0]; // 'Mike Ross'

mixedArray.length; // 7

mixedArray[0] = "Mike Rogers";

mixedArray[0]; // 'Mike Rogers'

mixedArray.push("New Element"); // Pushes element to array and returns new length of array

mixedArray.includes(14); // true

mixedArray.indexOf(729); // 3

mixedArray.pop(); // Removes the last element from an array and returns that element.

mixedArray.shift(); // Removes the first element from an array and returns that element.

mixedArray.unshift(); // Adds one or more elements to the front of an array, and returns the new length of the array.

mixedArray.reverse(); // Reverses the order of the elements of an array in place. (First becomes the last, last becomes first.)

mixedArray.sort(); // Sorts the elements of an array in place and returns the array.