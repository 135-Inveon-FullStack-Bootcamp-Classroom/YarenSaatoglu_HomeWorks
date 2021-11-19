import React, {useState,createContext} from 'react';

export const CalContext= createContext();

export const CalProvider = ({children})=>{
    const [mainText, setMainText]=useState("0");
    const [resetMainTextNextTime,setResetMainTextNextTime]=useState(true);
   
    const [lastResult, setLastResult]=useState();
    const [currentOperation,setCurrentOperation] =useState();

    const handleKeyClick= (isNumber,label,operator)=>{
        if(isNumber) {
            if(resetMainTextNextTime){
                setMainText(label);
                setResetMainTextNextTime(false);
            }else{ 
                setMainText((mainText)=> {
                    return mainText+label;
                });
            }
        }

        if(operator){
            setResetMainTextNextTime(true);
            setCurrentOperation(label);
            switch (label){
                case "+":
                    if(!lastResult){
                        setLastResult(Number(mainText));
                    }else{
                        setLastResult(Number(mainText) + lastResult);
                    }
                    break;

                case "-":
                    if(!lastResult){
                        setLastResult(Number(mainText));
                    }else{
                        setLastResult(lastResult-Number(mainText));
                    }
                    break;

                case "/":
                    if(!lastResult){
                        setLastResult(Number(mainText));
                    }else{
                        setLastResult(lastResult / Number(mainText));
                    }
                    break;

                case "x":
                    if(!lastResult){
                        setLastResult(Number(mainText));
                    }else{
                        setLastResult(lastResult * Number(mainText));
                    }
                    break;

                case "=":
                    setResetMainTextNextTime(true);
                    setMainText(lastResult);
                    setLastResult();
                    break;

                case "√":
                    setMainText((Math.sqrt(Number(mainText))));
                    break;

                case "<-":
                    if (mainText.length > 1) {
                        setMainText(mainText.slice(0, mainText.length - 1));
                    } else {
                        setMainText("0");
                    }
                    break;

                case "C":
                    setLastResult(0);
                    setResetMainTextNextTime(true);
                    setMainText(0);
                    break;

                case "CE":
                    setLastResult(0);
                    setResetMainTextNextTime(true);
                    setMainText(0);
                    break;

                case "%":
                    setMainText(Number(mainText) / 100);
                    break;

                case "x²":
                    setMainText(Math.pow(Number(mainText), 2));
                    break;

                case "1/x":
                    setMainText((1 / Number(mainText)));
                    break;

                case ",":
                    setMainText(Number(mainText+","));
                    break;
                
                case "+/-":
                    setMainText(Number(mainText)*-1);
                    break;
                default:
                    break;
            }
        }
    };

    return(
        <CalContext.Provider 
        value={{
            mainText,
            setMainText,
            handleKeyClick,
            resetMainTextNextTime,
            setResetMainTextNextTime,
            currentOperation,
            lastResult
        }}>{children}
        </CalContext.Provider>
    );
};