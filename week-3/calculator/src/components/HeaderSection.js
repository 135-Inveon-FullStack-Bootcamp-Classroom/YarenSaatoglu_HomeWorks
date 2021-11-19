import React from 'react'

const styles={
    headerSection:{
        width:"100%",
        height:"8%",
        paddingTop:8,
        paddingLeft:8
    },
    text:{
        color:"#fff",
        fontSize:15,
        margin:5,
    },
}

function HeaderSection() {
    return (
        <div style={styles.headerSection}>
            <span style={styles.text}>Hesap Makinesi</span>
        </div>
    )
}

export default HeaderSection
