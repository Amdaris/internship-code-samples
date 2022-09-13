const NameSubmissionForm = () => {
  return (
    <form className="name-submission-form">
      <label htmlFor="name">
        Your Name
      </label>
      <input
        id="name"
        type="text"
        name="name"
        placeholder="Enter your name"
      />
      <button type="submit">
        Submit
      </button>
    </form>
  );
};

export default NameSubmissionForm;





