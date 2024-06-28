let express = require("express");
let {
  main,
  getAllUsers,
  updateUser,
  getUser,
  createUser,
  deleteUser,
} = require("../controllers/users.controller");
const User = require("../models/Users.model");
let router = express.Router();

router.get("/", getAllUsers);

router.get("/:id", getUser);

router.put("/:id", updateUser);

router.post("/new", createUser);

router.delete("/:id", deleteUser);

module.exports = router;
