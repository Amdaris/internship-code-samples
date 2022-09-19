import { Routes, Route, Navigate } from 'react-router-dom';
import './App.css';
import Home from './views/Home';
import Task from './views/Task';
import Tasks from './views/Tasks';

const PrivateRoute = ({ children }) => {
  const isAuthenticated = !!localStorage.getItem("auth-token");

  return isAuthenticated ? children: <Navigate to={-1} />;
};

function App() {
  return (
    <div className="App">
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="tasks" element={<Tasks />} />
        <Route path="tasks/:taskId" element={<Task />} />

        <Route
          path="super-secret-route"
          element={
            <PrivateRoute>
              {<div>This is super secret.</div>}
            </PrivateRoute>
          }
        />


      </Routes>
    </div>
  );
}

export default App;


