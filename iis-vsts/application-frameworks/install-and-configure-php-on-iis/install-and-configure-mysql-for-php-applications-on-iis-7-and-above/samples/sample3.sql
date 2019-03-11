mysql> USE mysql;
Database changed
mysql> UPDATE user SET user='johndoe' WHERE user='root';
Query OK, 1 row affected (0.19 sec)
Rows matched: 1  Changed: 1  Warnings: 0
mysql> FLUSH PRIVILEGES;
Query OK, 0 rows affected (0.23 sec)