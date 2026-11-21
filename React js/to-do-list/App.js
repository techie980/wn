import { useState } from "react";

function App() {
  const [task, setTask] = useState("");
  const [tasks, setTasks] = useState([]);
  const addTask = () =>{
    if (task.trim() === "") return;
    setTasks([
      ...tasks,
      { text: task, completed: false}
    ]);
    setTask("");
  };

  const toggleTask = (index) => {
    const updatedTasks = [...tasks];

    updatedTasks[index].completed = !updatedTasks[index].completed;

    setTasks(updatedTasks);
  };

  const deleteTask = (index) => {
    const updatedTasks = tasks.filter(
      (_, i) => i !== index
    );

    setTasks(updatedTasks);
  }

  return (
    <div style={{textAlign: "center",marginTop: "40px"}}>
      <h1>To-Do List</h1>

      <input 
        type="text" placeholder="Enter a task" value={task} 
        onChange={(e) =>setTask(e.target.value)}/>

        <button onClick={addTask}>Add Task</button>

        <ul style={{listStyle:"none"}}>
          {tasks.map((item, index) => (
            <li
              key = {index}
              style = {{
                margine:"10px",
                textDecoration: item.completed ? "line-through":"none"
              }}>
                {item.text}

                <button
                  onClick={() => toggleTask(index)}
                  style = {{marginLeft: "10px"}}
                >Complete</button>

                <button
                  onClick={() => deleteTask(index)}
                  style = {{marginLeft: "10px"}}
                >Delete
                </button>
            </li>
          ))}
        </ul>
    </div>
  );
}
export default App;
