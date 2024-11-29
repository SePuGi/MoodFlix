import {Container} from "@mui/material"
import BottomNavBar from "./components/BottomNavBar"
import Login from "./pages/Login"
import Register from "./pages/Register"
import Movies from "./pages/Movies.tsx";


function App() {
  return (
    <>
      <Container maxWidth="sm" sx={{paddingBottom: '70px'}}>
        {/*<Login />*/}
        {/*<Register />*/}
        <Movies/>
      </Container>
      <BottomNavBar isLoggedIn={false}/>
    </>
  )
}

export default App
