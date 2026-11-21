import React from "react";
function NameCard(props) {
    return (
        <div className="card">
            {
                props.names.map((name, index) => (
                    <div className="name-card" key={index}>
                        <h2>{name}</h2>
                    </div>        
                ))
            }
        </div>
    );
}
export default NameCard;