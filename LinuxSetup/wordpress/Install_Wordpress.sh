sudo docker pull wordpress:latest
sudo docker run\
    -e WORDPRESS_DB_USER=wpuser\
    -e WORDPRESS_DB_PASSWORD=password\
    -e WORDPRESS_DB_NAME=wpdb\
    -p 8081:80\
    -v ~/wordpress/html:/var/www/html\
    --link wordpressdb:mysql\
    --name wpcontainer\
    -d wordpress

echo "Now the website is at http://locahost:8081"
