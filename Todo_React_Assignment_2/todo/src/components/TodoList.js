import React from 'react';

function TodoList({todos, setTodos}) {
    const buttonClickDone=(id)=>{
        let updateTodos= todos.map(todo=> {
            if(todo.id===id){
                todo.state = !todo.state;
            }
            return todo;
        });
        setTodos(updateTodos);
        localStorage.setItem('todos', JSON.stringify(updateTodos));
    }
    const buttonClickDelete=(id)=>{
        const newTodo=[...todos.filter((filterItem)=> filterItem.id !== id)];
        setTodos(newTodo);
        localStorage.setItem('todos', JSON.stringify(newTodo));
    }
    return (
        <div>
            <ul className="list">
                {todos.map((item)=>item.state?(<li className="item" key={item.id}>{item.text}<button className="buttonList" onClick={() => buttonClickDone(item.id)}>Done</button>
                 <button className="buttonList" onClick={() => buttonClickDelete(item.id)}>Delete</button></li>):
                 (<li className="item" key={item.id}><del>{item.text}</del> <button className="buttonList" onClick={() => buttonClickDone(item.id)}>Done</button>
                 <button className="buttonList" onClick={() => buttonClickDelete(item.id)}>Delete</button></li>))}
            </ul>
        </div>
    )
}

export default TodoList
