ARG VARIANT=7.0-bullseye-slim
FROM mcr.microsoft.com/dotnet/sdk:${VARIANT}
ENV PATH $PATH:/home/vscode/.dotnet:/home/vscode/.dotnet/tools

RUN git config --global --add safe.directory /workspaces/docker-remote-env

RUN git config --global user.name "Anton"
RUN git config --global user.email "khdevnet@gmail.com"
