import { useState } from 'react';
import { Button, TextField } from "@mui/material";

const isValidEmail = (email) => {
  return String(email)
    .toLowerCase()
    .match(/^\S+@\S+\.\S+$/);
};

const FormValidationWithMaterialUIExample = () => {
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
      onSubmit={(e) => handleFormSubmit(e)}
    >
      <TextField
        variant="filled"
        error={hasValidationError}
        helperText={hasValidationError && 'The email address is not a valid one.'}
        value={email}
        onChange={(e) => handleInputChange(e)}
      />
      <Button
        type="submit"
      >
        Submit Form
      </Button>
    </form>
  );
};

export default FormValidationWithMaterialUIExample;


