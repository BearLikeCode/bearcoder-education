const express = require('express')
const app = express()
const MongoClient = require("mongodb").MongoClient;
const ObjectId = require("mongodb").ObjectId;
const mongoose = require('mongoose');
const cors = require('cors')
const bodyParser = require('body-parser');
require('dotenv').config()

const port = process.env.PORT || 3000;
const uri = process.env.MONGO_URI;

app.use(cors())
app.use(bodyParser.urlencoded({
  extended: false
}))
app.use(express.static('public'))

mongoose.connect(uri, {
  useNewUrlParser: true,
  useUnifiedTopology: true,
  serverSelectionTimeoutMS: 5000,
})

const connection = mongoose.connection;
connection.on('error', console.error.bind(console, 'connection error: '));
connection.once('open', () => {
  console.log("MongoDB database connection established successfully")
})

const Schema = mongoose.Schema;
const userSchema = new Schema({
  username: String,
  log:[{
    description:{ type: String, required: true },
    duration:{ type: Number, required: true },
    date: { type: Date, required: true }
  }]
})
const User = mongoose.model("user", userSchema);

app.get('/', (req, res) => {
  res.sendFile(__dirname + '/views/index.html')
});

app.post('/api/users', async (req, res) => {
  const username = req.body.username;
  
  try {
    // check if its already in the database
    let findOne = await User.findOne({
      username: username
    })
    if (findOne) {
      res.json({
        username: findOne.username,
        _id: findOne._id,
      })
    } else {  
      findOne = new User({
        username: username,
      })
      await findOne.save()
      res.json({
        username: findOne.username,
        _id: findOne._id
      })
    }
  } catch (err) {
    console.error(err)
    res.status(500).json('Server erorr...')
  }
})

app.get('/api/users', async (req, res) => {
  try {
    let users = await User.find();
    if (users) {
      res.json(users)
    }
  } catch (err) {
    console.error(err)
    res.status(500).json('Server erorr...')
  }
})

app.post('/api/users/:_id/exercises', (req, res) => {
  let { description, duration, date } = req.body;
  const userId = req.params._id;
  
  if (!date) date = new Date().toDateString(); 
  else date = new Date(date).toDateString(date);

  const expObj = {
    description,
    duration,
    date
  }
  
  User.findByIdAndUpdate(
    userId, {$push:{log:expObj}},
    {new:true},
    (err,updatedUser)=>{
      if(err) {
        return console.log('update error:',err);
      }
      
      let returnObj ={
        "_id":userId,
        "username":updatedUser.username,
        "date":expObj.date,
      "duration":parseInt(expObj.duration),"description":expObj.description
      }
      res.json(returnObj)
    }
  )
  
})

app.get('/api/users/:_id/logs',(req,res)=>{
  const userId = req.params._id
  const from = req.query.from;
  const to = req.query.to;
  const limit = +req.query.limit;

  User.findById({_id:userId},(err,user)=>{
    if(err) return console.log(err)     

    let log = user.log.map((item)=>{
      return {
        description:item.description,
        duration:item.duration,
        date: new Date(item.date).toDateString()
      }     
    })
    if (from){
      const fromDate = new Date(from)
      log = log.filter(exe => new Date(exe.date)>= fromDate)
    }
    if (to){
      const toDate = new Date(to)
      log = log.filter(exe => new Date(exe.date)<= toDate)
    }
    if(limit){
      log = log.slice(0,limit)
    }

    let count = log.length  
 
    res.send({      
      "username":user.username,
      "count":count,
      "_id":userId,
      "log":log
    })
  })  
})

const listener = app.listen(port, () => {
  console.log('Your app is listening on port ' + listener.address().port)
})
