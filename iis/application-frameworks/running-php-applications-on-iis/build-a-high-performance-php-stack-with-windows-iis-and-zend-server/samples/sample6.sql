mysql> CREATE DATABASE library;
Query OK, 1 row(s) affected (0.01 sec)

mysql> USE library;
Database changed

mysql> CREATE TABLE books (
    -> id INT(4) AUTO_INCREMENT PRIMARY KEY,
    -> author VARCHAR(255),
    -> title VARCHAR(255),
    -> price VARCHAR(30)
    -> );
Query OK, 0 rows affected (0.05 sec)