const User = require("../models/Users.model");

async function createUser(req, res, next) {
  try {
    const { name, surname } = req.body;
    const user = new User({ name, surname });
    await user.save().then(() => res.send(user));
  } catch (e) {
    console.log(`Error model ${e}`);
  }
}

async function getAllUsers(req, res, next) {
  try {
    await User.find({}).then((user) => res.send(user));
  } catch (e) {
    console.log(`Error model ${e}`);
  }
}

async function getUser(req, res, next) {
  try {
    await User.findById(req.params.id).then((user) => res.send(user));
  } catch (e) {
    console.log(`Error model ${e}`);
  }
}

async function updateUser(req, res, next) {
  try {
    const { name, surname } = req.body;
    await User.findByIdAndUpdate(req.params.id, { name, surname }).then(() =>
      res.send(`User ${req.params.id} updated`)
    );
  } catch (e) {
    console.log(`Error model ${e}`);
  }
}

async function deleteUser(req, res, next) {
  try {
    await User.findByIdAndRemove(req.params.id).then((user) =>
      res.send(`User ${req.params.id} deleted`)
    );
  } catch (e) {
    console.log(`Error model ${e}`);
  }
}

module.exports = { createUser, getAllUsers, getUser, updateUser, deleteUser };
