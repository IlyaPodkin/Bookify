import React from "react";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./styles/main.css";
import Authorization from "./components/Authorization";
import Registration from "./components/Registration"

function App() {
  return (
    <div className="main">
      <Router>
        <Routes>
          <Route path="/registration" element={<Registration />} />
          <Route path="/authorization" element={<Authorization />} />
          {/* <Route path="/" element={<Registration />} /> */}
        </Routes>
      </Router>
    </div>
  );
}

export default App;
