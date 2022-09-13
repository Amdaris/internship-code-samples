import { useForm } from "react-hook-form";

const ReactHookFormBasicExample = () => {
  const { register, handleSubmit, watch, formState } = useForm();

  const handleFormSubmission = (data) => {
    console.log(data);
  };

  // Log the value of the 'sample-input' input field each time it changess
  console.log(watch('sample-input'));
  
  return (
    <form onSubmit={handleSubmit(handleFormSubmission)}>
      {/* Register the component to React Hook Form */}
      <input
        type="text"
        {...register('sample-input', { required: true })}
      />
      {/* Errors will be returned in case the validation for a particular input fails */}
      {formState.errors['sample-input'] && <span>This field is required.</span>}
      <button type="submit">Submit</button>
    </form>
  );
};

export default ReactHookFormBasicExample;

