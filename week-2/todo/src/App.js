import './App.css';
import {useState} from "react";
import TodoForm from "./components/TodoForm";
import TodoList from "./components/TodoList";
function App() {

  const [inputValue, setInputValue] = useState("");
  const [todos, setTodos]=useState([{}]);
  //useState(localStorage.getItem('todos') === null ? [{}] : JSON.parse(localStorage.getItem('todos')));
  //Bunu yazdığımda hata alıyorum bir türlü düzeltemedim o yüzden local storage da sorun var 
  const [id,setId]=useState(0);

  //localStorage.getItem(todos)

  const buttonClickAdd=()=>{
    const newItem= {
      id:id,
      text:inputValue,
      date: new Date(),
      state: true
    };
    setTodos([...todos,newItem]);
    setId(()=>(id+1));
    localStoreTodo(newItem);
  }
  const localStoreTodo = (todo) => {
    localStorage.setItem('todos', JSON.stringify(todo));
  };

  return (
    <div className="App">
      <TodoForm inputValue={inputValue} setInputValue={setInputValue} buttonClick={buttonClickAdd}/>
      <TodoList todos={todos} setTodos={setTodos}/>
    </div>
  );
}

export default App;
