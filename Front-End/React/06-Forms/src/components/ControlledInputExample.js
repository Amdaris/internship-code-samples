import { useState, useEffect } from 'react';

const ControlledInputExample = () => {
  const [inputValue, setInputValue] = useState('');

  useEffect(() => {
    console.log('The value of the input has changed: ', inputValue);
  }, [inputValue]);

  return (
    <input
      type="text"
      value={inputValue}
      onChange={(e) => setInputValue(e.target.value)}
    />
  );
};

export default ControlledInputExample;





