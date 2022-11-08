#!/bin/bash
$1
$2
$3
$4

ifconfig $1:$2 $3 netmask $4
