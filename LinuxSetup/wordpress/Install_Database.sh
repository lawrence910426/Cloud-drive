#!/bin/bash

sudo docker pull mariadb
mkdir ~/wordpress
mkdir ~/wordpress/database
mkdir ~/wordpress/html
sudo docker run\
    -e MYSQL_ROOT_PASSWORD=root-password\
    -e MYSQL_USER=wpuser\
    -e MYSQL_PASSWORD=password\
    -e MYSQL_DATABASE=wpdb\
    -v ~/wordpress/database:/var/lib/mysql\
    --name wordpressdb\
    -d mariadb

