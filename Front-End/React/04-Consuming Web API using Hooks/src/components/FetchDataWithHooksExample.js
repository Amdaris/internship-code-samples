import React from 'react';
import useFetchData from '../hooks/useFetchData';

const FetchDataWithHooksExample = () => {
  // Axios Request Config
  const requestConfig = {
    url: 'https://jsonplaceholder.typicode.com/posts',
    method: 'GET',
  };

  const posts = useFetchData(requestConfig);

  return (
    <div className="posts-container">
      {posts.map((post) => (
        <div className="post">
          <h4>{post.title}</h4>
          <p>{post.body}</p>
        </div>
      ))}
    </div>
  );
};

export default FetchDataWithHooksExample;











