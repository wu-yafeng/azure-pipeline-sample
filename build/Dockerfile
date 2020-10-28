#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
ARG source
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY ${source} .
ENTRYPOINT ["dotnet", "AspNetCoreApp.dll"]