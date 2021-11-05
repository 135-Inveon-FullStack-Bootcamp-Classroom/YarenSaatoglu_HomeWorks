import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import { CalProvider } from './CalContext';

ReactDOM.render(
  <React.StrictMode>
    <CalProvider>
    <App />
    </CalProvider>
  </React.StrictMode>,
  document.getElementById('root')
);

