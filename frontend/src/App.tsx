import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './bowler/BowlerData';
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <div className="App">
      <Header />
      <BowlerList />
    </div>
  );
}

export default App;
