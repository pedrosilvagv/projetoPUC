#!/bin/bash


#echo "ifconfig $1:$2 $3 netmask $4" >> /home/projeto/projetoPUC/logs/teste.txt
echo "qual interface?"
read ETHER
sleep 1

echo "qual lab?"
read LAB
sleep 1
sudo ifconfig $ETHER:$LAB down
echo "sudo ifconfig $ETHER:$LAB down" >> /home/projeto/projetoPUC/logs/teste.txt


#sudo ifconfig $1:$2 down
#echo "sudo ifconfig $1:$2 down" >> /home/projeto/projetoPUC/logs/teste.txt