require("dotenv").config();
const express = require("express");
const axios = require("axios");

const app = express();
const port = process.env.PORT;
const serversEnv = process.env.API_SERVERS;

const servers = serversEnv.split(";");
let currentServerIndex = 0;

app.get("/", async (req, res) => {
  try {
    const currentServer = servers[currentServerIndex];
    currentServerIndex = (currentServerIndex + 1) % servers.length;

    const response = await axios.get(currentServer);
    res.send(response.data);
  } catch (error) {
    // console.error(`Error while forwarding request: ${error.message}`);
    res.status(500).send("Internal Server Error");
  }
});

app.listen(port, () => {
  console.log(`Load balancer listening at http://localhost:${port}`);
});
