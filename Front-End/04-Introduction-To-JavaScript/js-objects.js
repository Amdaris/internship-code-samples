const mike = {
  firstName: 'Mike',
  lastName: 'Smith',
  age: 23,
  occupation: 'Software Engineer',
  'office-access-key-id': 24,
  sayName: function() {
    console.log(`Hello! I'm ${this.firstName} ${this.lastName}.`);
  }
};

mike.sayName(); // Hello! I'm Mike Smith

mike['firstName']; // 'Mike'

mike.occupation; // 'Software Engineer'

mike.office-access-key-id; // Will throw error

mike['office-access-key-id']; // 24


/* Object Operations */

// Check if object has a certain property
'age' in mike // true
'job' in mike // false

// List properties of object
Object.keys(mike); // ['firstName', 'lastName', 'age', 'occupation', ...]

// List values of object
Object.values(mike); // ['Mike', 'Smith', 23, 'Software Engineer', ...]

// List properties and their respective values
Object.entries(mike); // [ ['firstName', 'Mike'], ['lastName', 'Smith'], ... ]

// Remove an object's property
delete mike.age;

'age' in mike // false;

// Freeze object so its properties cannot be changed or removed
Object.freeze(mike);

// Seal an object so its properties cannot be removed
Object.seal(mike);
