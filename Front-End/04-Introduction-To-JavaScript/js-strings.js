// The most widespread way that strings are initialized
const firstName = "Kyle";
const lastName = "Jordan";

// Initializing strings through the available `String` class constructor
// This method is usually disregarded
const firstName2 = new String("Jamie");
const lastName2 = new String("Kors");

// Concatenating Strings
const name = firstName + " " + lastName;

name; // 'Kyle Jordan'

// Concatenating strings through a template literal
const templateLiteralName = `${firstName2} ${lastName2}`;

templateLiteralName; // 'Jamie Kors'


/* Common String Manipulation Use-Cases */

// Get lowercase string
const str1 = "Wolf";
str1.toLowerCase(); // 'wolf'

// Get uppercase string
const str2 = "Tiger";
str2.toUpperCase(); // 'TIGER'

// Get nth character of a string
const str3 = "Kitten";
str3.charAt(4); // 'e'

// Comparing two strings
const compStr1 = "Closet",
  compStr2 = "Tub";

// Case insensitive comparison
compStr1.toLowerCase() == compStr2.toLowerCase(); // false

// Check if substring
const strToSearchIn = 'This is a sentence';
const searchTerm1 = 'word';
const searchTerm2 = 'sentence';

strToSearchIn.includes(searchTerm1); // false
strToSearchIn.includes(searchTerm2); // true

// Split string by token
const stringToSplit = 'this-will-be-split-at-hyphen';
stringToSplit.split('-'); // ['this', 'will', 'be', 'split', 'at', 'hyphen']