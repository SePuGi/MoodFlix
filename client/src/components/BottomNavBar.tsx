// src/components/BottomNavBar.tsx
import {useState} from 'react';
import {BottomNavigation, BottomNavigationAction, Paper} from '@mui/material';
import {FaHome, FaUser, FaRegUser, FaFilm, FaHistory} from 'react-icons/fa';

function BottomNavBar({isLoggedIn}: { isLoggedIn: boolean }) {
  const [value, setValue] = useState(0); // State to track the selected tab

  return (
    <Paper
      sx={{position: 'fixed', bottom: 0, left: 0, right: 0}}
      elevation={3}
    >
      <BottomNavigation
        showLabels
        value={value}
        onChange={(event, newValue) => setValue(newValue)}
      >
        {/* Home */}
        <BottomNavigationAction
          label="Home"
          icon={<FaHome/>}
        />

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
      </BottomNavigation>
    </Paper>
  );
};

export default BottomNavBar;

