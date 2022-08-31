const doSomething = () => {
  throw new Error('An issue');
};

try {
  try {
    doSomething();
  } catch (err) {
    console.log('There was this error: ', err);
    throw err;
  }
} catch (err) {
  console.log('Logged the error');
}

