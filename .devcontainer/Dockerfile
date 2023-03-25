FROM mcr.microsoft.com/devcontainers/base:jammy
    
RUN curl -s https://raw.githubusercontent.com/khdevnet/wsl2-env/main/install-dotnet7.sh | bash

RUN curl -s https://raw.githubusercontent.com/khdevnet/wsl2-env/main/install-git.sh | sh

# TODO: Find a way to use wsl git configs
RUN git config --global --add safe.directory /workspaces/httpvsgrpc
