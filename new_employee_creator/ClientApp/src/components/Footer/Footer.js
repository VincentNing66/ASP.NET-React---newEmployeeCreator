import React from 'react';
import classes from './Footer.module.css'

const Footer = () => {
    return (
        <div className={classes.footer}>
            <div className={classes.offices}>
            AU Free Phone 1800 305 175<br/>
            NZ Free Phone 0800 33 55 66<br/><br/>
                <a href="https://www.securedsigning.com/">https://www.securedsigning.com/</a>
            </div>
            <div className={classes.offices}>
                Level 5, 11 Queens Road,
                Melbourne Vic 3000 Australia <br /><br />
                <a href="https://www.securedsigning.com.au/">https://www.securedsigning.com.au/</a>
            </div>
            <div className={classes.offices}>
                Building 2, 5 Ceres Ct. Albany,
                PO Box 35902, Browns Bay,
                Auckland, New Zealand<br/><br/>
                <a href="https://www.securedsigning.co.nz/">https://www.securedsigning.co.nz/</a>
            </div>
        </div>
    );
}

export default Footer;