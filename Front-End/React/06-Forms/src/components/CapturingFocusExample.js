const CapturingFocusExample = () => {
  return (
    <input
      type="text"
      onFocus={(e) => {
        console.log('Element is in focus. Element:', e.target);
      }}
      onBlur={(e) => {
        console.log('Element is out of focus. Element:', e.target);
      }}
    />
  );
};

export default CapturingFocusExample;
