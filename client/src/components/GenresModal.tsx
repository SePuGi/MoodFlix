import {List} from '@mui/material';
import {useFetchGenresQuery} from "../features/api/preferencesApi.ts";
import {useSelector} from "react-redux";
import {RootState} from "../app/store.ts";
import {useState} from "react";
import {GenreNotPreferred} from "../types/preferences.ts";
import {useUpdateUserGenresMutation} from "../features/api/userApi.ts";
import PreferencesModal from "./PreferencesModal.tsx";
import PreferenceModalItem from "./PreferenceModalItem.tsx";
import ErrorPageLoading from "./errors/ErrorPageLoading.tsx";
import LoadingPage from "./LoadingPage.tsx";

type GenresModalProps = {
  open: boolean;
  onClose: () => void;
};

function GenresModal({open, onClose}: GenresModalProps) {
  const {data: allGenres, isError, isLoading} = useFetchGenresQuery();
  const [updateUserGenres, {isLoading: updateIsLoading}] = useUpdateUserGenresMutation();

  const userGenres = useSelector((state: RootState) => state.userPreferences.genres)
    .map((genre): GenreNotPreferred => ({
      ...genre,
      isPreferred: false
    }));

  const [genresNotPreferred, setGenresNotPreferred] = useState<GenreNotPreferred[]>(userGenres);

  const handleToggle = (genre: { id: number, name: string }, isNotPreferred: boolean) => {
    if (isNotPreferred) {
      setGenresNotPreferred(
        [...genresNotPreferred, {
          genreId: genre.id,
          genreName: genre.name,
          isPreferred: false
        }]);
    } else {
      const updatedGenres = genresNotPreferred.filter((g) => genre.id !== g.genreId);
      setGenresNotPreferred(updatedGenres);
    }
  };

  const handleSave = async () => {
    await updateUserGenres(genresNotPreferred);
    alert('Genres updated successfully');
  };

  const checkSelected = (genreId: number) => {
    return genresNotPreferred.some((userGenre) => userGenre.genreId === genreId);
  }

  if (isLoading) {
    return <LoadingPage/>
  }

  if (isError) {
    return <ErrorPageLoading message={'Failed to load genres'}/>
  }

  const title = 'Manage your Genres';
  const description = 'Select the genres you DO NOT like to get better recommendations';

  return (
    <PreferencesModal
      open={open}
      onClose={onClose}
      isLoading={updateIsLoading}
      handleSave={handleSave}
      title={title}
      description={description}
    >
      <List>
        {allGenres?.map(({genreId, genreName}) => (
          <PreferenceModalItem
            key={genreId}
            id={genreId}
            name={genreName}
            checkSelected={checkSelected}
            handleToggle={handleToggle}
          />
        ))}
      </List>
    </PreferencesModal>
  );

}

export default GenresModal;
