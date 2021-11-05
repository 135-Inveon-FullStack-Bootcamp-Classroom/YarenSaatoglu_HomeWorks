import React from 'react';
import KeyButton from './KeyButton';

const styles={
    keysSection:{
        width:"100%",
        height:"65%",
        display:"flex",
        flexWrap:"wrap"
    },
};

function KeysSection() {
    return (
        <div style={styles.keysSection}>
            <KeyButton label="%" operator></KeyButton>
            <KeyButton label="CE" operator></KeyButton>
            <KeyButton label="C" operator></KeyButton>
            <KeyButton label="<-" operator></KeyButton>
            <KeyButton label="1/x" operator></KeyButton>
            <KeyButton label="x²" operator></KeyButton>
            <KeyButton label="√" operator></KeyButton>
            <KeyButton label="/" operator></KeyButton>
            <KeyButton label="7" isNumber></KeyButton>
            <KeyButton label="8" isNumber></KeyButton>
            <KeyButton label="9" isNumber></KeyButton>
            <KeyButton label="x" operator></KeyButton>
            <KeyButton label="4" isNumber></KeyButton>
            <KeyButton label="5" isNumber></KeyButton>
            <KeyButton label="6" isNumber></KeyButton>
            <KeyButton label="-" operator></KeyButton>
            <KeyButton label="1" isNumber></KeyButton>
            <KeyButton label="2" isNumber></KeyButton>
            <KeyButton label="3" isNumber></KeyButton>
            <KeyButton label="+" operator></KeyButton>
            <KeyButton label="+/-"isNumber operator></KeyButton>
            <KeyButton label="0" isNumber></KeyButton>
            <KeyButton label=","isNumber operator></KeyButton>
            <KeyButton label="=" isBlue operator></KeyButton>
        </div>
    )
}

export default KeysSection
