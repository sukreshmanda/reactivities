FROM mcr.microsoft.com/dotnet/sdk:8.0 as Build
WORKDIR /src
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 as Runtime
WORKDIR /app
COPY --from=Build /publish .
ENTRYPOINT [ "dotnet" , "API.dll" ]