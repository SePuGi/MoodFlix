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

export default UserHistory;