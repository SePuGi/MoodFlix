import {Box, Button} from "@mui/material";

type MovieButtonsProps = {
  refresh: () => void;
}

function MovieButtons({refresh}: MovieButtonsProps) {
  return (
    <Box sx={{display: 'flex', justifyContent: 'center', gap: 2, mt: 3}}>
      <Button variant="outlined" color="secondary" onClick={refresh}>
        Refresh
      </Button>
    </Box>
  )
}

export default MovieButtons;