

#run rabbitmq
docker run --name some-rabbit  rabbitmq:3-management


#first build demo
```
docker run demo1-console-app

docker build . -t demo1-console-app -f Dockerfile
docker images
```

#multi stage demo
```
docker build . -t demo2-console-app -f Dockerfile.multi
docker images
```


# demo layering 
```
docker build . -f Dockerfile.layers  -t demo3-console-app
dive demo3-console-app
```

# demo layering solution
```
docker build . -f Dockerfile.layerssol  -t demo4-console-app
dive demo4-console-app
```

# demo dotnet on alpine
```
docker build . -f Dockerfile.alpine  -t demo5-console-app
dive demo4-console-app
```

# demo update to dotnet 2.2
```
docker build . -f Dockerfile-2.2 -t demo-console-6
```


# demo push and tag
```
docker tag demo-console-6 geoffreysamper/demo-console-6:v1
docker push geoffreysamper/demo-console-6:v1

``` 

# demo run a rabbitmq bridge network vs host network
```
# run rabbitmq in bridge
docker run --hostname my-rabbit --name some-rabbit rabbitmq:3-management

# run rabbitmq in bridge expose the internal port on 8080
docker run -d --hostname my-rabbit --name some-rabbit -p 8080:15672 rabbitmq:3-management

# run in host network
docker run --hostname my-rabbit --network host --name some-rabbit  rabbitmq:3-management 
```

# demo Volumes
```
#create volume
docker volume create myvol

# run an nginx
docker run --name demo9 -d --mount source=myvol,target=/myvol nginx
# start a bash interactive inside the container
docker exec -it demo9 bash
# must be run in container
cd /myvol && touch hello.txt && echo "hello i survived and I was running in demo9" >> /myvol/state.txt
# remove container
docker stop demo9 a&& docker rm demo9
#run a new container 9.1
docker run --name demo9.1 -it --mount source=myvol,target=/myvol nginx
# start bash interative in a container
docker exec -it demo9 bash
#display content of file
cat /myvol/state.txt

```
