#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#3080 HTTP , 3443 HTTPS
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 3080

RUN apt-get update
RUN apt-get install unzip -y
RUN wget https://eforexcel.com/wp/wp-content/uploads/2020/09/5m-Sales-Records.zip
RUN unzip 5m-Sales-Records.zip
RUN mv '5m Sales Records.csv' sales_records.csv

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GRPCExample.csproj", "."]
RUN dotnet restore "./GRPCExample.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "GRPCExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GRPCExample.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GRPCExample.dll"]