const getLastArrayElement = <T>(arr: Array<T>) => arr[arr.length - 1];

const lastElm = getLastArrayElement<number>([1, 2, 3]);

const lastElm2 = getLastArrayElement<string>(['a', 'b', 'c']);

// TypeScript will automatically infer the Array type based due to the Generic definition
const lastElm3 = getLastArrayElement(['d', 'e', 'f']);

const lastElmError = getLastArrayElement<string>(['g', 'h', 10]);

// TypeScript will automatically infer the Array type based due to the Generic definition
const lastElmOfInferredArray = getLastArrayElement(['g', 'h', 10]);

const makeTuple = <T, U>(x: T, y: U): [T, U] => {
  return [x, y];
};

const tuple = makeTuple('a', 6);

const tuple2 = makeTuple([1, 2], { prop1: 1, prop2: 'b' })