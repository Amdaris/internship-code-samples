import { Alert, Button, Grid, TextField } from "@mui/material";
import { useState } from "react";
import { useForm } from "react-hook-form";

const requiredFieldRule = {
  required: {
    value: true,
    message: 'Field is required',
  }
};

const ReactHookFormMaterialUI = () => {
  const [showAlert, setShowAlert] = useState(false);
  const { register, handleSubmit, formState: { errors } } = useForm();

  const handleFormSubmission = () => {
    // The code here will only be executed if form inputs are valid
    setShowAlert(true);
  };
  
  return (
    <>
      {showAlert && (
        <Alert>Form submitted successfully!</Alert>
      )}
      <form onSubmit={handleSubmit(handleFormSubmission)}>
        <Grid
          container
          alignItems="center"
          justify="center"
          direction="column"
        >
          <Grid item>
            <TextField
              type="text"
              error={!!errors['first-name']}
              helperText={errors['first-name']?.message}
              {...register('first-name', { ...requiredFieldRule })}
              placeholder="Your first name"
            />
          </Grid>
          <Grid item>
            <TextField
              type="text"
              error={!!errors['last-name']}
              helperText={errors['last-name']?.message}
              {...register('last-name', { ...requiredFieldRule })}
              placeholder="Your last name"
            />
          </Grid>
          <Grid item>
            <Button
              type="submit"
              variant="contained"
              size="l"
            >
              Submit
            </Button>
          </Grid>
        </Grid>
      </form>
    </>
  );
};

export default ReactHookFormMaterialUI;