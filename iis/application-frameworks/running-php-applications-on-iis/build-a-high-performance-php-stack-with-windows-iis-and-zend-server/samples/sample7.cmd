mysql> LOAD DATA INFILE 'G:\\books.csv' INTO TABLE books
    -> FIELDS TERMINATED BY ',' IGNORE 1 LINES
    -> (author, title, price);
Query OK, 28 rows affected (0.00 sec)
Records: 28  Deleted: 0  Skipped: 0  Warnings: 0