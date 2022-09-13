import { useState } from 'react';

const GenericTextField = ({ id, value, handleChange }) => (
  <input
    id={id}
    value={value}
    onChange={(e) => handleChange(e, id)}
  />
);

const FormStateHandlingExample1 = () => {
  const [formState, setFormState] = useState({
    'input_1': '',
    'input_2': '',
    'input_3': '',
  });

  const handleUpdateInputValue = (e, id) => {
    setFormState(prevState => ({
      ...prevState, // Maintain the values of the other input fields
      [id]: e.target.value,
    }));
  }

  const inputValue = (id) => formState?.[id];

  return (
    <form>
      <GenericTextField id={'input_1'} value={inputValue('input_1')} handleChange={handleUpdateInputValue} />
      <GenericTextField id={'input_2'} value={inputValue('input_2')} handleChange={handleUpdateInputValue} />
      <GenericTextField id={'input_3'} value={inputValue('input_3')} handleChange={handleUpdateInputValue} />
    </form>
  );
};

export default FormStateHandlingExample1;

