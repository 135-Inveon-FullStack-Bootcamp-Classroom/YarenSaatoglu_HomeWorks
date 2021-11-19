let items=[];

window.onload= function(){
    if(JSON.parse(localStorage.getItem("todo-items"))!=null){
        items=JSON.parse(localStorage.getItem("todo-items"));
        display();
    }
    document.querySelector(".time").value= new Date();
}
function addItem(){
    if(document.querySelector(".input-text").value.trim()!=""){
        items.push(document.querySelector(".input-text").value.trim());
        if(localStorage.getItem("todo-items")==null){
            localStorage.setItem("todo-items",JSON.stringify(items));
        }
        else{
            localStorage.setItem("todo-items",JSON.stringify(items));
        }
        display();
        document.querySelector(".input-text").value="";
    }
}
function display(){
    document.querySelector(".list").innerHTML="";
    for(let i=0;i<items.length;i++){
        document.querySelector(".list").innerHTML+= "<center><div class='item'>"+ items[i]+"<i class='bi bi-check-lg' onClick='taskDone("+i+")'><i/> <i class='bi bi-trash' onClick='taskDelete("+i+")'><i/></div></center>";
    }
}
function taskDelete(index){
    items.splice(index,1);
    if(localStorage.getItem("todo-items")==null){
        localStorage.setItem("todo-items",JSON.stringify(items));
    }
    else{
        localStorage.setItem("todo-items",JSON.stringify(items));
    }
    display();
}
function taskDone(index){
    if(items[index].includes("<strike>")){
        items[index]= items[index].replace("<strike>","");
        items[index]= items[index].replace("</strike>","");
    }
    else{
        items[index]="<strike>"+items[index]+"</strike>";
    }
    if(localStorage.getItem("todo-items")==null){
        localStorage.setItem("todo-items",JSON.stringify(items));
    }
    else{
        localStorage.setItem("todo-items",JSON.stringify(items));
    }
    display();
    
}