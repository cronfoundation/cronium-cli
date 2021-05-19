<p align="center">
<a href="https://cron.global">
      <img
      src="https://cryptocean.io/img/logo.svg"
      width="250px" alt="cron-logo">
  </a>
</p>

<p align="center">      
  <a href="https://github.com/cronfoundation/cronium-cli/blob/master/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="License">
  </a>
  <a href="https://github.com/cronfoundation/cronium-cli/releases">
    <img src="https://badge.fury.io/gh/neo-project%2Fneo-node.svg" alt="Current neo-cli version.">
  </a>    
</p>

# Attention! Read it please.
This is new version of readme.md. Now it is in writing stage, draft mode. Please contact support for your questions.

# Prerequisites

* setup docker environment

# Install
Popular scenario
```shell script
cd /opt/cryptocean/cryptocean-cronium-cli-slave-1
export DOCKER_NAME=cryptocean-cronium-cli-slave-1.latest
export DOCKER_IMAGE=cronglobal/cronium-cli:latest
export NODE_RPC_PORT=127.0.0.1:10332:10332
export NODE_P2P_PORT=127.0.0.1:10333:10333
export NODE_WS_PORT=127.0.0.1:10334:10334
export NODE_PATH=/opt/cryptocean/cryptocean-cronium-cli-slave-1
export NODE_ARGS=--rpc
docker pull ${DOCKER_IMAGE} && docker-compose -f docker-stack.yml --compatibility up -d
```


# Logging
Check
`docker logs -f <dockername>`

## Bootstrapping the network.
1. Download Chain.data.zip
2. Cp it to the 
```shell script
# Go to node console
docker attach --detach-keys ctrl-c  cryptocean-cronium-cli-slave-1.latest
# Check state
show state
# Run import (wait 15min+)
bulkimport
```
