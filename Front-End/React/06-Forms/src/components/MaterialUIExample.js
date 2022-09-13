import { TextField } from "@mui/material";
import { useState } from "react";

const MaterialUIExample = () => {
  const [inputValue, setInputValue] = useState('');

  return (
    <TextField
      variant="standard"
      value={inputValue}
      onChange={(e) => setInputValue(e.target.value)}
    />
  );
};

export default MaterialUIExample;
