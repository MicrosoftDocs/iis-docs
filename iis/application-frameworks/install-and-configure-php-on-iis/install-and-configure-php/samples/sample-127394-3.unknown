<?php
session_start();
$counter = isset($_SESSION['counter']) ? $_SESSION['counter'] : 0;
$counter++;
print "You have visited this page $counter times during this session";
$_SESSION['counter'] = $counter;
?>