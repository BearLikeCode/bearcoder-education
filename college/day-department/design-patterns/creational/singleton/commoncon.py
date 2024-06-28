# Import necessary libraries
import mysql.connector
import pymongo

# Define the DatabaseConnection class
class DatabaseConnection:
    _instance = None

    def __init__(self, db_type, **kwargs):
        self.db_type = db_type
        self.connection = None
        self.connection_params = kwargs

    @classmethod
    def instance(cls, db_type, **kwargs):
        if cls._instance is None:
            cls._instance = cls(db_type, **kwargs)
        return cls._instance

    def connect(self):
        if not self.connection:
            if self.db_type == "mysql":
                self.connection = mysql.connector.connect(**self.connection_params)
            elif self.db_type == "mongo":
                self.connection = pymongo.MongoClient(**self.connection_params)
            print("Connected to database.")

    def close(self):
        if self.connection:
            self.connection.close()
            self.connection = None
            print("Disconnected from database.")

    # Add more methods for executing queries, transactions, etc.

# Example usage of Singleton for connecting to MySQL database:
mysql_connection = DatabaseConnection.instance(
    "mysql",
    host="localhost",
    user="username",
    password="password",
    database="mydatabase"
)
mysql_connection.connect()

# Example usage of Singleton for connecting to MongoDB database:
mongo_connection = DatabaseConnection.instance(
    "mongo",
    host="localhost",
    port=27017,
    username="mongo_user",
    password="mongo_password",
    database="my_mongo_db"
)
mongo_connection.connect()

# Close connections
mysql_connection.close()
mongo_connection.close()