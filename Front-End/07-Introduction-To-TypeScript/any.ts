const printIdInUppercase = (id: any) => {
  // The code below will throw an error if we don't pass
  // a string as the id argument, despite it not showing any issues in the IDE
  const uppercasedId = id.toUppercase();

  console.log(uppercasedId);
};