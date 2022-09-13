import React, { useState, useEffect } from 'react';
import './App.css';
import FetchDataWithHooksExample from './components/FetchDataWithHooksExample';

function App() {
  const [documentTitle, setDocumentTitle] = useState('');

  useEffect(() => {
    document.title = documentTitle;
  }, [documentTitle]);

  return (
    <div className="App">
      <input
        type="text"
        placeholder="Enter the new browser tab title"
        value={documentTitle}
        onChange={(e) => setDocumentTitle(e.target.value)}
      />
      <FetchDataWithHooksExample />
    </div>
  );
}

export default App;


