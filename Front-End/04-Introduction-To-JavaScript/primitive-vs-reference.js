const num = 5;

const person1 = {
  firstName: 'Mike',
  lastName: 'Ross',
};

const person2 = person1;

person1.firstName = 'John';

console.log(person1, '\n', person2);