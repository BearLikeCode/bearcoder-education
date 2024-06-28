import axios from "axios";

export const PopularMovies = async (payload) => {
  return await axios.get(
    `https://api.themoviedb.org/3/discover/movie?include_adult=false&include_video=false&language=en-US&page=1&sort_by=popularity.desc`,
    {
      headers: {
        Authorization: `Bearer ${process.env.REACT_APP_API_ACCESS_TOKEN}`,
      },
    }
  );
};
