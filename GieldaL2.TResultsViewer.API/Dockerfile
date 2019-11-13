#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:2.1-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["GieldaL2.TResultsViewer.API/GieldaL2.TResultsViewer.API.csproj", "GieldaL2.TResultsViewer.API/"]
COPY ["GieldaL2.TResultsViewer.DB/GieldaL2.TResultsViewer.DB.csproj", "GieldaL2.TResultsViewer.DB/"]
RUN dotnet restore "GieldaL2.TResultsViewer.API/GieldaL2.TResultsViewer.API.csproj"
COPY . .
WORKDIR "/src/GieldaL2.TResultsViewer.API"
RUN dotnet build "GieldaL2.TResultsViewer.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GieldaL2.TResultsViewer.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GieldaL2.TResultsViewer.API.dll"]