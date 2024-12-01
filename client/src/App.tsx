import {Container} from "@mui/material"
import BottomNavBar from "./components/BottomNavBar"
import Login from "./pages/Login"
import Register from "./pages/Register"
import Movies from "./pages/Movies.tsx";
import {BrowserRouter as Router, Routes, Route} from "react-router-dom";


function App() {
  return (
    <Container maxWidth="sm">
      <Router>
        <Routes>
          <Route path="/login" element={<Login/>}/>
          <Route path="/register" element={<Register/>}/>
          <Route path="/" element={<Movies/>}/>
        </Routes>
        <BottomNavBar isLoggedIn={false}/>
      </Router>
    </Container>
  )
}

export default App
