import {useState, useContext} from 'react';
import React from 'react';
import {CalContext} from '../CalContext';

const styles={
    keyContainer:{
        width:"24.2%",
        height:"16%",
        backgroundColor:"#070707",
        border:"1px solid #4f4f4f",
    },
    keyText:{
        color:"white",
        textAlign:"center",
        fontSize:20,
    },
};

function KeyButton({label, isBlue, isNumber,operator}) {
    const {handleKeyClick }= useContext(CalContext);
    const [hovered, setHovered]=useState(false);

    const isHoveredStyle = hovered ? {backgroundColor:"#6d6d6d"}:{};
    const isNumberStyle = isNumber ?{backgroundColor:"#101010"}:{};
    const isBlueStyle= isBlue ? {backgroundColor:"#0063b1"}:{};
    const isOperator = operator ? {backgroundColor:"#2f2f2f"}:{};

    return (
        <div style={{
            ...styles.keyContainer,
            ...isOperator,
            ...isNumberStyle,
            ...isBlueStyle,
            ...isHoveredStyle,
            }} 
            onMouseEnter={()=>setHovered(true)}
            onMouseLeave={()=> setHovered(false)}
            onClick={()=>handleKeyClick(isNumber,label, operator)}
            >
            
            <div style={styles.keyText}>{label}</div>
        </div>
    )
}

export default KeyButton
