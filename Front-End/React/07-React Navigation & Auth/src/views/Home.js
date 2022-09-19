import { Link } from "react-router-dom";

const Home = () => {
  return (
    <div>
      <h1>Welcome to the home page</h1>
      <p>
        Go to <Link to="tasks">Tasks</Link>.
      </p>
    </div>
  );
};

export default Home;

