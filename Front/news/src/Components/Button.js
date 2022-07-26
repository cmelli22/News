import React from "react";

const Button = ({ className, text, size, fullwidth }) => {
  return <button className={`button ${className} ${size} ${fullwidth}`}>{text}</button>;
};

export default Button;
