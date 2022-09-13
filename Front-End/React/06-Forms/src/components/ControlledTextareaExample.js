import { useState, useEffect } from 'react';

const ControlledTextareaExample = () => {
  const [textareaValue, setTextareaValue] = useState('');

  useEffect(() => {
    console.log('The value of the textarea has changed: ', textareaValue);
  }, [textareaValue]);

  return (
    <textarea
      type="text"
      value={textareaValue}
      onChange={(e) => setTextareaValue(e.target.value)}
    />
  );
};

export default ControlledTextareaExample;





