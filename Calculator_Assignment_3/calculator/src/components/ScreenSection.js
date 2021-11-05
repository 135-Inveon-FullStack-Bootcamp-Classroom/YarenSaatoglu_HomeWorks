import React, {useContext} from 'react';
import {CalContext} from '../CalContext';

const styles={
    screenSection:{
        width:"100%",
        height:"25%",
        display:"flex",
        justifyContent:"center",
        flexDirection:"column",
        alignItems:"flex-end",
    },
    mainText:{
        color:"#fff",
        fontSize:40,
        padding:12,
    },
    captionText:{
        color:"#999",
        fontSize:20,
        padding:12
    }
};

function ScreenSection() {
    const {mainText,currentOperation,lastResult} = useContext(CalContext);
    const renderCaption = () => {

        if (lastResult && currentOperation)
            return (
                <span style={styles.captionText}>
                    {lastResult} {currentOperation === "1/x" || "CE" || "<-" || "x²" || "√"   ? "":  currentOperation }
                </span>
            )
    }

    return (
        <div style={styles.screenSection}>
            {renderCaption()}
            <span style={styles.mainText}> {mainText}</span>
        </div>
    );
}

export default ScreenSection
