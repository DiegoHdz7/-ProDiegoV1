FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/ProDiegoV1.Web.Host/ProDiegoV1.Web.Host.csproj", "src/ProDiegoV1.Web.Host/"]
COPY ["src/ProDiegoV1.Web.Core/ProDiegoV1.Web.Core.csproj", "src/ProDiegoV1.Web.Core/"]
COPY ["src/ProDiegoV1.Application/ProDiegoV1.Application.csproj", "src/ProDiegoV1.Application/"]
COPY ["src/ProDiegoV1.Core/ProDiegoV1.Core.csproj", "src/ProDiegoV1.Core/"]
COPY ["src/ProDiegoV1.EntityFrameworkCore/ProDiegoV1.EntityFrameworkCore.csproj", "src/ProDiegoV1.EntityFrameworkCore/"]
WORKDIR "/src/src/ProDiegoV1.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ProDiegoV1.Web.Host", "src/ProDiegoV1.Web.Host"]
COPY ["src/ProDiegoV1.Web.Core", "src/ProDiegoV1.Web.Core"]
COPY ["src/ProDiegoV1.Application", "src/ProDiegoV1.Application"]
COPY ["src/ProDiegoV1.Core", "src/ProDiegoV1.Core"]
COPY ["src/ProDiegoV1.EntityFrameworkCore", "src/ProDiegoV1.EntityFrameworkCore"]
WORKDIR "/src/src/ProDiegoV1.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ProDiegoV1.Web.Host.dll"]
