import { useState } from 'react';

const isValidEmail = (email) => {
  return String(email)
    .toLowerCase()
    .match(/^\S+@\S+\.\S+$/);
};

const FormValidationExample = () => {
  const [hasValidationError, setHasValidationError] = useState(false);
  const [email, setEmail] = useState('');

  const handleInputChange = (e) => {
    if (hasValidationError) setHasValidationError(false);
    setEmail(e.target.value);
  };

  const handleFormSubmit = (e) => {
    // Prevent page refresh, which is default browser behaviour
    e.preventDefault();

    if (!isValidEmail(email)) {
      setHasValidationError(true);
      return;
    }

    console.log('Form submitted successfully!');
  };

  return (
    <form
      className="email-form"
      onSubmit={(e) => handleFormSubmit(e)}
    >
      <input
        type="text"
        value={email}
        onChange={(e) => handleInputChange(e)}
      />
      {hasValidationError && (
        <span className="validation-error">The email address is not a valid one.</span>
      )}
      <button type="submit">
        Submit Form
      </button>
    </form>
  );
};

export default FormValidationExample;


