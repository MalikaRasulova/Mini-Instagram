FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Mini-Instagram/MiniInstagram/MiniInstagram.csproj", "Mini-Instagram/MiniInstagram/"]
RUN dotnet restore "MiniInstagram/MiniInstagram.csproj"
COPY . .
WORKDIR "/src/MiniInstagram"
RUN dotnet build "MiniInstagram.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MiniInstagram.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MiniInstagram.dll"]
