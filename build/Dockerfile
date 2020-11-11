#This file used by azure-pipeline for building images for all aspnetcore application.

FROM mcr.microsoft.com/dotnet/core/aspnet:5.0-buster-slim AS base
ARG source=.
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY ${source} .
ENTRYPOINT ["dotnet", "AspNetCoreApp.dll"]