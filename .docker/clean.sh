#!/bin/bash

docker container rm $(docker container ls -a --format {{.ID}}) -f
docker volume rm $(docker volume ls --format {{.Name}}) -f
docker image rm $(docker image ls --format {{.ID}}) -f
