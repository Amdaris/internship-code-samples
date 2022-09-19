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

        const { data } = await axios(requestConfig);

        setRequestState({
          ...requestState,
          data,
          loding: false,
        });
      } catch (err) {
        setRequestState({
          ...requestState,
          loading: false,
          error: err,
        });
      }
    };

    fetchData();
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  return requestState;
};

export default useFetchData;