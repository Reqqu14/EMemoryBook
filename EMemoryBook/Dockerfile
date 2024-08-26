#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["EMemoryBook/EMemoryBook.csproj", "EMemoryBook/"]
COPY ["EMemoryBook.Infrastructure/EMemoryBook.Infrastructure.csproj", "EMemoryBook.Infrastructure/"]
COPY ["EMemoryBook.Domain/EMemoryBook.Domain.csproj", "EMemoryBook.Domain/"]
COPY ["EMemoryBook.Application/EMemoryBook.Application.csproj", "EMemoryBook.Application/"]
RUN dotnet restore "EMemoryBook/EMemoryBook.csproj"
COPY . .
WORKDIR "/src/EMemoryBook"
RUN dotnet build "EMemoryBook.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EMemoryBook.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN mkdir -p /app/certyficates
COPY EMemoryBook/certyficates/aspnetapp.pfx /app/certyficates/aspnetapp.pfx

ENTRYPOINT ["dotnet", "EMemoryBook.dll"]
