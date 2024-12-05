import React, {useState} from 'react';
import {BottomNavigation, BottomNavigationAction, Paper} from '@mui/material';
import {FaHome, FaUser, FaRegUser, FaFilm, FaHistory} from 'react-icons/fa';
import {MOBILEBAR_HEIGHT} from "../constants/constants.ts";
import {useNavigate} from "react-router-dom";

function BottomNavBar({isLoggedIn}: { isLoggedIn: boolean }) {
  const [value, setValue] = useState(0); // State to track the selected tab
  const navigate = useNavigate();

  const handleNavigation = (event: React.SyntheticEvent, newValue: number) => {
    setValue(newValue);
    if (newValue === 0) navigate("/login");
    if (newValue === 1) navigate("/");
    if (newValue === 2) navigate("/");
    if (newValue === 3) navigate("/profile");
  }
  return (
    <Paper
      sx={{position: 'fixed', bottom: 0, left: 0, right: 0, height: MOBILEBAR_HEIGHT,}}
      elevation={3}
    >
      <BottomNavigation
        showLabels
        value={value}
        onChange={handleNavigation}

      >

        {/* Login/Profile */}
        <BottomNavigationAction
          label={isLoggedIn ? "Profile" : "Login"}
          icon={isLoggedIn ? <FaUser/> : <FaRegUser/>}
        />

        {/* Movie Recommendation */}
        <BottomNavigationAction
          label="Movies"
          icon={<FaFilm/>}
        />

        {/* History */}
        <BottomNavigationAction
          label="History"
          icon={<FaHistory/>}
        />

        {/* Profile */}
        <BottomNavigationAction
          label="Profile"
          icon={<FaUser/>}
        />

      </BottomNavigation>
    </Paper>
  );
}

export default BottomNavBar;

