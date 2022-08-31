/* function sumOfTwoNumbers(num1, num2) {
  const sum = num1 + num2;
  return sum;
} */

// Normal functions can be used as constructors
function Person(firstName, lastName) {
  this.firstName = firstName;
  this.lastName = lastName;

  console.log(this); // 'Person { firstName: 'Mike', lastName: 'Herrera' }
}

// const person = new Person("Mike", "Herrera");

/* 
  Arrow function notation
  Remove the word "function" and place arrow between the argument and opening body bracket
*/
const sumOfTwoNumbers = (num1, num2) => {
  const sum = num1 + num2;
  return sum;
};

/*
  Shorthand notation
  Remove the body braces and word "return" — the return is implied
  (This applies in cases where we don’t do anything more than simply return something based on the args).
*/
const sumOfTwoNumbersSimplified = (num1, num2) => num1 + num2;

/* *********************************************************************************************** */

const object = {
  property: 'Some value',
  logThis: () => {
    console.log(this);
  },
  logThisAgain: function() {
    console.log(this);
  }
};

object.logThis();

object.logThisAgain();