import { useState } from 'react';

const FormStateHandlingExample1 = () => {
  const [inputValue1, setInputValue1] = useState('');
  const [inputValue2, setInputValue2] = useState('');
  const [inputValue3, setInputValue3] = useState('');

  return (
    <form>
      <input
        value={inputValue1}
        onChange={(e) => setInputValue1(e.target.value)}
      />
      <input
        value={inputValue2}
        onChange={(e) => setInputValue2(e.target.value)}
      />
      <input
        value={inputValue3}
        onChange={(e) => setInputValue3(e.target.value)}
      />
    </form>
  );
};

export default FormStateHandlingExample1;

