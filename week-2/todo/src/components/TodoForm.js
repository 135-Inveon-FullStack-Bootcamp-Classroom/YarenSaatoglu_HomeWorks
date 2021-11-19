import React from 'react';

function TodoForm({inputValue,setInputValue,buttonClick}) {
    return (
        <div>
            <input className="input-text" value={inputValue} onChange={(e)=>setInputValue(e.target.value)} required placeholder="Bu gün neler yapıyorum..."/>
            <button className="add-button" onClick={buttonClick}>Add</button>
        </div>
    );
}

export default TodoForm

