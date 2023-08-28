```
docker build -t counter-image -f Dockerfile .
docker create --name core-counter counter-image
docker start core-counter
docker ps
docker attach --sig-proxy=false core-counter
docker stop core-counter
docker rm core-counter
docker ps
```