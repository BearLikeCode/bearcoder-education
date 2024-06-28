import React, { useEffect, useState } from "react";
import "./App.css";
import { PopularMovies } from "./queries/api";

function App() {
  const [popularMovies, setPopularMovies] = useState();

  useEffect(() => {
    getPopMovies();
  }, []);

  const getPopMovies = async () => {
    await PopularMovies().then((data) => {
      setPopularMovies(data.data.results);
    });
  };

  return (
    <div style={{ display: "flex", flexFlow: "row wrap", padding: 20 }}>
      {popularMovies?.map((item) => (
        <div
          key={item.id}
          style={{
            padding: 20,
            border: "1px solid grey",
            width: 500,
          }}
        >
          <img
            src={`https://image.tmdb.org/t/p/w500/${item.backdrop_path}`}
            alt={item.original_title}
          />
          <h2>{item.original_title}</h2>
          <p style={{ textAlign: "justify" }}>{item.overview}</p>
        </div>
      ))}
    </div>
  );
}

export default App;
