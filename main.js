require("dotenv").config();
const express = require("express");
const app = express();
const port = process.env.PORT;

app.get("/", (req, res) => {
  console.log(`host ${request.headers.host}`);
  res.send("Hello, World!");
});

app.listen(port, () => {
  console.log(`App listening at http://localhost:${port}`);
});
