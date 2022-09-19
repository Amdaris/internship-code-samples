import useFetchData from '../hooks/useFetchData';

const Tasks = () => {
  const requestConfig = {
    url: 'https://jsonplaceholder.typicode.com/todos',
    method: 'GET',
  };

  const {
    data: tasks,
    loading,
    error
  } = useFetchData(requestConfig);

  return (
    <div className="tasks-container">
      {!!loading && <p>Loading Data...</p>}
      {!!error && (
        <p style={{ color: 'red' }}>
          There was an issue loading the data: {error.message}
        </p>
      )}
      {!!tasks && !!tasks.length && tasks.map((task) => (
        <div className="task">
          <h4>{task.title}</h4>
        </div>
      ))}
    </div>
  );
};

export default Tasks;

