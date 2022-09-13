const EventHandlingExample = () => {
  return (
    <form onSubmit={(e) => {
      e.preventDefault();
      console.log('Form Submitted!', e);
    }}>
      <input
        type="text"
        name="sample_text"
        onChange={(e) => {
          console.log('Input value has changed. New value:', e.target.value);
        }}
      />
      <button type="submit">Submit Form</button>
    </form>
  );
};

export default EventHandlingExample;


