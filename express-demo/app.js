var express = require("express");
var path = require("path");
var cookieParser = require("cookie-parser");
var logger = require("morgan");
var mongoose = require("mongoose");

var indexRouter = require("./routes/index");
var usersRouter = require("./routes/users");

var app = express();

mongoose
  .connect(
    "mongodb://bearcoder:edhemnetqx@ac-1rgkbwu-shard-00-00.bqhwmpe.mongodb.net:27017,ac-1rgkbwu-shard-00-01.bqhwmpe.mongodb.net:27017,ac-1rgkbwu-shard-00-02.bqhwmpe.mongodb.net:27017/?replicaSet=atlas-i4xoqa-shard-0&ssl=true&authSource=admin"
  )
  .then(() => console.log("Connected!"))
  .catch((e) => console.log(`Error with db: ${e}`));

app.use(logger("dev"));
app.use(express.json());
app.use(express.urlencoded({ extended: false }));
app.use(cookieParser());
app.use(express.static(path.join(__dirname, "public")));

app.use("/", indexRouter);
app.use("/users", usersRouter);

module.exports = app;
