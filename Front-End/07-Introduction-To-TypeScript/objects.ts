/* const getName = (person: { firstName: string; lastName: string }): string => {
  return person.firstName + ' ' + person.lastName;
}; */

const getName = (person: {
  firstName: string;
  lastName?: string;
}): string => {
  const lastNameOrEmptyString = person.lastName || '';

  const fullName = person.firstName + ' ' + lastNameOrEmptyString;

  return fullName;
};