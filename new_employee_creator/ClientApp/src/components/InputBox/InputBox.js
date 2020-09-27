import React from 'react';
import classes from './InputBox.module.css'


const inputBox = (props) => {
    return (
        <div >
            <label className={classes.inp}>
                <input type="text" pattern="[0-9]*" value={props.content} placeholder="&nbsp;" onChange={props.change} />
                <span className={classes.label}>{props.text}</span>
                <span className={classes.focusBg}></span>
            </label>
        </div>
    );
}

export default inputBox;