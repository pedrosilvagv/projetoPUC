#!/bin/bash


echo "1-" $1 >> /home/projeto/projetoPUC/logs/teste.txt
echo "2-" $2 >> /home/projeto/projetoPUC/logs/teste.txt
echo "3-" $3 >> /home/projeto/projetoPUC/logs/teste.txt
echo "4-" $4 >> /home/projeto/projetoPUC/logs/teste.txt


sleep 1
echo "ifconfig $1:$2 $3 netmask $4" >> /home/projeto/projetoPUC/logs/teste.txt
sudo ifconfig $1:$2 $3 netmask $4