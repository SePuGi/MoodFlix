import {Box, Typography} from '@mui/material';
import UserHistoryCard from '../components/UserHistoryCard';
import {useGetUserHistoryQuery} from "../features/api/userHistoryApi.ts";
import {useEffect} from "react";

function UserHistory() {
  const {data: history, isLoading, isError, refetch} = useGetUserHistoryQuery();
  console.log(history);

  useEffect(() => {
    refetch();
  }, []);
  const handleRate = (registerId: number, rating: number) => {
    console.log(`Rated movie with registerId ${registerId}: ${rating} stars`);
    // Add logic to save the rating (e.g., send to an API)
  };

  if (isLoading) {
    return <div>Loading...</div>;
  }
  if (isError) {
    return <div>Error</div>;
  }

  return (
    <Box
      sx={{
        padding: 3,
        backgroundColor: 'background.default',
        minHeight: '100vh',
      }}
    >
      <Typography variant="h1" sx={{marginBottom: 3}}>
        View History
      </Typography>

      {history?.map((historyItem) => (
        <UserHistoryCard
          key={historyItem.registerId}
          history={historyItem}
          onRate={handleRate}
        />
      ))}
    </Box>
  );
}

export default UserHistory;

/*
import {useGetUserHistoryQuery} from "../features/api/userHistoryApi.ts";
import {useEffect} from "react";

function UserHistory() {
  const {data: history, isLoading, isError, refetch} = useGetUserHistoryQuery();
  console.log(history);

  useEffect(() => {
    refetch();
  }, []);

  if (isLoading) {
    return <div>Loading...</div>;
  }
  if (isError) {
    return <div>Error</div>;
  }

  return (
    <div>
      <h1>History</h1>
      <div>
        {history?.map((item) => (
          <div key={item.registerId}>
            <h2>{item.movie.title}</h2>
            <p>{new Date(item.registerDate).toDateString()}</p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default UserHistory;*/
