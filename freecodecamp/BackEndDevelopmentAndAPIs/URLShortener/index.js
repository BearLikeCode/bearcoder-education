require('dotenv').config();
const express = require('express');
const MongoClient = require("mongodb").MongoClient;
const ObjectId = require("mongodb").ObjectId;
const mongoose = require('mongoose');
const shortId = require('shortid');
const bodyParser = require('body-parser');
const validUrl = require('valid-url');
const cors = require('cors');
const app = express();

// Basic Configuration
const port = process.env.PORT || 3000;
const uri = process.env.MONGO_URI;

app.use(cors());
app.use(bodyParser.urlencoded({
  extended: false
}))
app.use(express.json())
app.use('/public', express.static(`${process.cwd()}/public`));

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
const urlSchema = new Schema({
  original_url: String,
  short_url: String
})
const URL = mongoose.model("URL", urlSchema);

app.get('/', function (req, res) {
  res.sendFile(process.cwd() + '/views/index.html');
});

app.post('/api/shorturl', async function (req, res) {

  const url = req.body.url;
  const urlCode = shortId.generate()
  
  // check if the url is valid or not
  const expression = /[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)?/gi;
  const regex = new RegExp(expression);

  if (!url.match(regex)) {
    res.json({
      error: 'invalid url'
    })
  } else {
    try {
      // check if its already in the database
      let findOne = await URL.findOne({
        original_url: url
      })
      if (findOne) {
        res.json({
          original_url: findOne.original_url,
          short_url: findOne.short_url
        })
      } else {
        // if its not exist yet then create new one and response with the result
        findOne = new URL({
          original_url: url,
          short_url: urlCode
        })
        await findOne.save()
        res.json({
          original_url: findOne.original_url,
          short_url: findOne.short_url
        })
      }
    } catch (err) {
      console.error(err)
      res.status(500).json('Server erorr...')
    }
  }
})


app.get('/api/shorturl/:short_url?', async function (req, res) {
  try {
    const urlParams = await URL.findOne({
      short_url: req.params.short_url
    })
    if (urlParams) {
      return res.redirect(urlParams.original_url)
    } else {
      return res.status(404).json('No URL found')
    }
  } catch (err) {
    console.log(err)
    res.status(500).json('Server error')
  }
})

app.listen(port, function() {
  console.log(`Listening on port ${port}`);
});
