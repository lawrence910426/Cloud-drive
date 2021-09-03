#!/bin/bash

echo "Database at:" $(sudo docker inspect -f '{{ .NetworkSettings.IPAddress }}' wordpressdb)
mysql -u wpuser -h $(sudo docker inspect -f '{{ .NetworkSettings.IPAddress }}' wordpressdb) -p

