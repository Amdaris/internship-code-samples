// Class Declaration
class Person {
  constructor(firstName, lastName, age, occupation) {
    this._firstName = firstName;
    this._lastName = lastName;
    this._age = age;
    this._occupation = occupation;
  }

  getName() {
    return `${this._firstName} ${this._lastName}`;
  }

  greet() {
    console.log('Hello!');
  }

  introduceThemselves() {
    console.log(`Hello! I'm ${this.getName()} and I'm an ${this._occupation}.`);
  }

  set firstName(firstName) {
    this._firstName = firstName;
  }

  set lastName(lastName) {
    this._lastName = lastName;
  }
}

// Instantiation
const person = new Person('Anne', 'Pearson', 25, 'Interior Designer');

person.getName(); // 'Anne Pearson'

person.lastName = 'Sparrow';

person.introduceThemselves(); // Hello! I'm Anne Sparrow  and I'm a Interior Designer.



// Inheritance using the `extends` keyword
class ExtendedPerson extends Person {
  #_salary; // Define private field

  constructor(firstName, lastName, age, occupation, salary) {
    // Calls parent's constructor
    super(firstName, lastName, age, occupation);

    this.#_salary = salary;
  }

  set salary(salary) {
    this.#_salary = salary;
  }

  get salary() {
    return this.#_salary;
  }

  logSalary() {
    console.log(this.#_salary);
  }
}

const extendedPersonInstance = new ExtendedPerson('Jake', 'Myers', 30, 'Movie Director', 200000);

// extendedPersonInstance.#_salary;

extendedPersonInstance.logSalary(); // 200000