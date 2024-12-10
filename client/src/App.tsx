import {Container} from "@mui/material"
import BottomNavBar from "./components/BottomNavBar"
import Login from "./pages/Login"
import Register from "./pages/Register"
import Movies from "./pages/Movies.tsx";
import {BrowserRouter as Router, Routes, Route} from "react-router-dom";
import Questionnaire from "./pages/Questionnaire.tsx";
import EmotionsResult from "./pages/EmotionsResult.tsx";
import Profile from "./pages/Profile.tsx";
import ProtectedRoute from "./components/ProtectedRoute.tsx";
import GeneratedMovieWrapper from "./pages/GeneratedMovieWrapper.tsx";
import UserHistory from "./pages/UserHistory.tsx";

function App() {

  return (
    <Container maxWidth="sm">
      <Router>
        <Routes>
          <Route
            element={<ProtectedRoute/>}
          >
            <Route path="/" element={<Movies/>}/>
            <Route path="/questionnaire" element={<Questionnaire/>}/>
            <Route path="/results" element={<EmotionsResult/>}/>
            <Route path="/movies/generateMovie/emotions/:haveEmotions" element={<GeneratedMovieWrapper/>}/>
            <Route path="/profile" element={<Profile/>}/>
            <Route path={"/history"} element={<UserHistory/>}/>
          </Route>

          <Route path="/login" element={<Login/>}/>
          <Route path="/register" element={<Register/>}/>
        </Routes>
        <BottomNavBar isLoggedIn={false}/>
      </Router>
    </Container>
  )
}

export default App
