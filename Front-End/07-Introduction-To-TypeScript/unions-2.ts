/*
  Note: The void type is equivalent to not returning anything from a function
*/

const printIdInUppercase = (id: string | number): void => {
  // The uppercase method only exists on string elements
  const uppercaseId = id.toUpperCase();

  console.log(uppercaseId);
};

const printIdInUppercase2 = (id: string | number): void => {
  let uppercaseId: string;
  
  if (typeof id === 'string') {
    uppercaseId = id.toUpperCase();
  } else {
    uppercaseId = id.toString().toUpperCase();
  }

  console.log(uppercaseId);
};