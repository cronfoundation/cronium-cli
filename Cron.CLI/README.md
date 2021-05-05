# Cronium-cli

### Before starting:
```
cd ~/
git clone https://github.com/cronfoundation/cronium-cli.git
cd cronium-cli

mkdir -p ${NODE_PATH:-/opt/cryptocean/cryptocean-cronium-cli}/data/
cp ~/cronium-cli/Cron.CLI/config.json ${NODE_PATH:-/opt/cryptocean/cryptocean-cronium-cli}/
cp ~/cronium-cli/Cron.CLI/protocol*.json ${NODE_PATH:-/opt/cryptocean/cryptocean-cronium-cli}/
cp ~/cronium-cli/Cron.CLI/wallet.json ${NODE_PATH:-/opt/cryptocean/cryptocean-cronium-cli}/
cp ~/cronium-cli/Cron.CLI/docker-stack.yml ${NODE_PATH:-/opt/cryptocean/cryptocean-cronium-cli}/
```

### Edit config files
```
nano ${NODE_PATH:-/opt/cryptocean/cryptocean-cronium-cli}/config.json
nano ${NODE_PATH:-/opt/cryptocean/cryptocean-cronium-cli}/protocol.json
```

### Run through Docker Compose

`Localhost:`
```
cd ~/cronium-cli/Cron.CLI
docker-compose -f docker-stack.yml --compatibility pull && docker-compose -f docker-stack.yml --compatibility up -d
```

`Production:`
```
cd ${NODE_PATH:-/opt/cryptocean/cryptocean-cronium-cli}/
export \
DOCKER_IMAGE=cronglobal/cryptocean-cronium-cli:latest \
DOCKER_CPUS_LIMIT=1 \
DOCKER_MEMORY_LIMIT=1024M \
\
&& docker-compose -f docker-stack.yml --compatibility pull && docker-compose -f docker-stack.yml --compatibility up -d
```
