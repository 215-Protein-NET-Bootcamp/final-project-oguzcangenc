FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/CarPartsMarketplace.API/CarPartsMarketplace.API.csproj", "src/CarPartsMarketplace.API/"]
COPY ["src/CarPartsMarketplace.Core/CarPartsMarketplace.Core.csproj", "src/CarPartsMarketplace.Core/"]
COPY ["src/CarPartsMarketplace.Business/CarPartsMarketplace.Business.csproj", "src/CarPartsMarketplace.Business/"]
COPY ["src/CarPartsMarketplace.Entities/CarPartsMarketplace.Entities.csproj", "src/CarPartsMarketplace.Entities/"]
COPY ["src/CarPartsMarketplace.Data/CarPartsMarketplace.Data.csproj", "src/CarPartsMarketplace.Data/"]
RUN dotnet restore "src/CarPartsMarketplace.API/CarPartsMarketplace.API.csproj"
COPY . .
WORKDIR "/src/src/CarPartsMarketplace.API"
RUN dotnet build "CarPartsMarketplace.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CarPartsMarketplace.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet CarPartsMarketplace.API.dll