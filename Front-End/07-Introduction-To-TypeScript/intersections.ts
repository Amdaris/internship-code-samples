type Person = {
  firstName: string;
  lastName: string;
};

type PersonWithAge = Person & {
  age: number;
};

const personWithAge: PersonWithAge = {
  firstName: 'Mike',
  lastName: 'Ross',
  age: 27,
};

const anotherPerson: Person = {
  firstName: 'John',
  lastName: 'Appleseed',
  age: 30, // Will throw an error as the `Person` type doesn't have any `age` references
};