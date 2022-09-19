import { useParams, useNavigate } from "react-router-dom";
import useFetchData from "../hooks/useFetchData";

const Task = () => {
  const navigate = useNavigate();

  // Retrieving the param by the name from the router config
  const { taskId } = useParams();

  if (!taskId) {
    // There isn't a `taskId` parameter in the URL
    // So we'll redirect the user to the tasks page
    navigate('/tasks');
  }

  const requestConfig = {
    // Retrieving the task with the id of `taskId`
    url: `https://jsonplaceholder.typicode.com/todos/${taskId}`,
    method: 'GET',
  };

  const { data, loading, error } = useFetchData(requestConfig);

  return (
    <div className="individual-task-container">
      {!!loading && <p>Loading task information...</p>}
      {!!error && (
        <p style={{ color: 'red' }}>
          There was an issue loading the task information: {error.message}
        </p>
      )}
      {!!data && <h4>{data.title}</h4>}
    </div>
  );
};

export default Task;


