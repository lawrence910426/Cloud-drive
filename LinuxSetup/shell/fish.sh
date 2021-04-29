sudo apt-add-repository ppa:fish-shell/release-3
sudo apt-get update
sudo apt-get install fish
chsh -s /usr/local/bin/fish
omf install bobthefish

git clone https://github.com/ryanoasis/nerd-fonts
./nerd-fonts/install.sh
rm -r nerd-fonts
