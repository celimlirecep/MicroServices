#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Reservation.API/Reservation.API.csproj", "Reservation.API/"]
COPY ["Reservation.Services/Reservation.Services.csproj", "Reservation.Services/"]
COPY ["Reservation.Infrastructure/Reservation.Infrastructure.csproj", "Reservation.Infrastructure/"]
COPY ["Reservation.Models/Reservation.Models.csproj", "Reservation.Models/"]
RUN dotnet restore "Reservation.API/Reservation.API.csproj"
COPY . .
WORKDIR "/src/Reservation.API"
RUN dotnet build "Reservation.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Reservation.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Reservation.API.dll"]