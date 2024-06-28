require("dotenv").config();
const express = require("express");
const app = express();
const port = process.env.PORT;

app.get("/", (req, res) => {
  res.send(req.headers.host);
});

app.listen(port, () => {
  console.log(`App listening at http://localhost:${port}`);
});
