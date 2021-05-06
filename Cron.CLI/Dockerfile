FROM microsoft/dotnet:2.2-sdk 
 
# Install dependencies: 
RUN apt-get update && apt-get install -y \ 
    libleveldb-dev \ 
    sqlite3 \ 
    libsqlite3-dev \ 
    libunwind8-dev \ 
    wget \ 
    expect \ 
    zip \ 
    nano 
 
# Copy project data 
RUN mkdir -p /tmp/cronium-git-cli /opt/cronium-cli 
COPY . /tmp/cronium-git-cli 

# Set directory for build 
WORKDIR /tmp/cronium-git-cli 
 
# Build the project 
RUN dotnet restore 
RUN dotnet publish -c Release -o /opt/cronium-cli 

# Set working directory 
WORKDIR /opt/cronium-cli 

# Activate plugins
ADD Plugins /opt/cronium-cli/Plugins 
RUN cp SyncBlocks.dll ApplicationLogs.dll CoreMetrics.dll ImportBlocks.dll RpcNep5Tracker.dll \ 
    RpcSecurity.dll RpcSystemAssetTracker.dll RpcWallet.dll StatesDumper.dll \ 
    /opt/cronium-cli/Plugins/

# Cleanups 
RUN apt-get -y autoremove && apt-get clean && rm -rf /var/lib/apt/lists/* /tmp/* /var/tmp/* 
 
# Start Cronium CLI 
ENTRYPOINT dotnet Cron.CLI.dll $NODE_ARGS