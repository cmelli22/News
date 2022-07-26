import React, { useContext } from "react";

const Input = ({ name, label, placeholder, type, required, className, onChangeFunction }) => {

  
  return (
    <div className="card-container ">
      <label className="label">{label}</label>
      <div className="control">
        <input
          name={name}
          className={`${className}`}
          type={type}
          placeholder={placeholder}
          required={required}
          onChange={ onChangeFunction != null ? e => onChangeFunction(e) : () => {}}
        />
      </div>
    </div>
  );
};

export default Input;
