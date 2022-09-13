import { useState, useEffect } from 'react';
import axios from 'axios';

const useFetchData = (requestConfig) => {
  const [requestState, setRequestState] = useState({
    data: [],
    loading: false,
    error: null,
  });

  useEffect(() => {
    const fetchData = async () => {
      try {
        setRequestState({
          ...requestState,
          loading: true,
        });
  
        const response = await axios(requestConfig);
  
        setRequestState({
          ...requestState,
          data: response.data
        });
      } catch (err) {
        setRequestState({
          ...requestState,
          error: err,
        });
      } finally {
        setRequestState({
          ...requestState,
          loading: false,
        });
      }
    };

    fetchData();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  return requestState;
};

export default useFetchData;



