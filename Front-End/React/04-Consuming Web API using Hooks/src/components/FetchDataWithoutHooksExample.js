import axios from 'axios';
import { useState, useEffect } from 'React';

const FetchDataWithoutHooksExample = () => {
  const [data, setData] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      const response = await axios.get('https://jsonplaceholder.typicode.com/posts');

      setData(response.data);
    };

    fetchData();
  }, []);

  return (
    <div className="posts-container">
      {data.map((post) => (
        <div className="post">
          <h4>{post.title}</h4>
          <p>{post.body}</p>
        </div>
      ))}
    </div>
  );
};

export default FetchDataWithoutHooksExample;

