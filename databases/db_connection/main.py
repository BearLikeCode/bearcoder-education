import mysql.connector

config = {
	'user': 'root',
	'password': '',
	'host': 'localhost',
	'database': 'Exotic_or_Rare_Goods_Store'
}

try:
	connection = mysql.connector.connect(**config)
	if (connection.is_connected()):
		print('Connected to MySQL database')
except mysql.connector.Error as err:
	print('Error: {err}')
