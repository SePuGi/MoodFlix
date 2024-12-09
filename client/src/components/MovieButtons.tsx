import {MOBILEBAR_HEIGHT} from "../constants/constants.ts";
import {Box, Button} from "@mui/material";

type MovieButtonsProps = {
  add: () => void;
  refresh: () => void;
}

function MovieButtons({add, refresh}: MovieButtonsProps) {
  return (
    <Box sx={{display: 'flex', justifyContent: 'center', gap: 2, mb: MOBILEBAR_HEIGHT, mt: 3}}>
      <Button variant="contained" color="primary"
              onClick={add}>
        Add
      </Button>
      <Button variant="outlined" color="secondary" onClick={refresh}>
        Refresh
      </Button>
    </Box>
  )
}

export default MovieButtons;