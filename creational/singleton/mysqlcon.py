import mysql.connector

class DatabaseConnection:
    _instance = None

    def __init__(self, host, user, password, database):
        self.host = host
        self.user = user
        self.password = password
        self.database = database
        self.connection = None

    @classmethod
    def instance(cls, host, user, password, database):
        if cls._instance is None:
            cls._instance = cls(host, user, password, database)
        return cls._instance

    def connect(self):
        if not self.connection:
            self.connection = mysql.connector.connect(
                host=self.host,
                user=self.user,
                password=self.password,
                database=self.database
            )
            print("Connected to database.")

    def close(self):
        if self.connection:
            self.connection.close()
            self.connection = None
            print("Disconnected from database.")

    def execute_query(self, query):
        cursor = self.connection.cursor()
        cursor.execute(query)
        rows = cursor.fetchall()
        cursor.close()
        return rows

# Example usage of Singleton for connecting to a MySQL database:
db_connection = DatabaseConnection.instance("localhost", "username", "password", "mydatabase")
db_connection.connect()

# Execute a query
query = "SELECT * FROM users"
result = db_connection.execute_query(query)
print("Query Result:", result)

# Close the connection
db_connection.close()

# Attempt to create another connection with the same database details
another_db_connection = DatabaseConnection.instance("localhost", "username", "password", "mydatabase")
another_db_connection.connect()

# Execute the query again
result = another_db_connection.execute_query(query)
print("Query Result (Second Connection):", result)

# Close the connection again
another_db_connection.close()
