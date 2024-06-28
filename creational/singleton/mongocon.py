import pymongo

class DatabaseConnection:
    _instance = None

    def __init__(self, host, port, username, password, database):
        self.host = host
        self.port = port
        self.username = username
        self.password = password
        self.database = database
        self.connection = None

    @classmethod
    def instance(cls, host, port, username, password, database):
        if cls._instance is None:
            cls._instance = cls(host, port, username, password, database)
        return cls._instance

    def connect(self):
        if not self.connection:
            self.connection = pymongo.MongoClient(
                host=self.host,
                port=self.port,
                username=self.username,
                password=self.password,
                authSource=self.database
            )
            print("Connected to MongoDB.")

    def close(self):
        if self.connection:
            self.connection.close()
            self.connection = None
            print("Disconnected from MongoDB.")

    def execute_query(self, collection_name, query):
        db = self.connection[self.database]
        collection = db[collection_name]
        result = collection.find(query)
        return result

# Example usage of Singleton for connecting to a MongoDB database:
db_connection = DatabaseConnection.instance("localhost", 27017, "username", "password", "mydatabase")
db_connection.connect()

# Execute a query
collection_name = "users"
query = {"age": {"$gt": 25}}  # Example query to find users older than 25
result = db_connection.execute_query(collection_name, query)
print("Query Result:")
for doc in result:
    print(doc)

# Close the connection
db_connection.close()

# Attempt to create another connection with the same database details
another_db_connection = DatabaseConnection.instance("localhost", 27017, "username", "password", "mydatabase")
another_db_connection.connect()

# Execute the query again
result = another_db_connection.execute_query(collection_name, query)
print("Query Result (Second Connection):")
for doc in result:
    print(doc)

# Close the connection again
another_db_connection.close()
