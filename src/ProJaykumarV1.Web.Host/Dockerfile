FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/ProJaykumarV1.Web.Host/ProJaykumarV1.Web.Host.csproj", "src/ProJaykumarV1.Web.Host/"]
COPY ["src/ProJaykumarV1.Web.Core/ProJaykumarV1.Web.Core.csproj", "src/ProJaykumarV1.Web.Core/"]
COPY ["src/ProJaykumarV1.Application/ProJaykumarV1.Application.csproj", "src/ProJaykumarV1.Application/"]
COPY ["src/ProJaykumarV1.Core/ProJaykumarV1.Core.csproj", "src/ProJaykumarV1.Core/"]
COPY ["src/ProJaykumarV1.EntityFrameworkCore/ProJaykumarV1.EntityFrameworkCore.csproj", "src/ProJaykumarV1.EntityFrameworkCore/"]
WORKDIR "/src/src/ProJaykumarV1.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ProJaykumarV1.Web.Host", "src/ProJaykumarV1.Web.Host"]
COPY ["src/ProJaykumarV1.Web.Core", "src/ProJaykumarV1.Web.Core"]
COPY ["src/ProJaykumarV1.Application", "src/ProJaykumarV1.Application"]
COPY ["src/ProJaykumarV1.Core", "src/ProJaykumarV1.Core"]
COPY ["src/ProJaykumarV1.EntityFrameworkCore", "src/ProJaykumarV1.EntityFrameworkCore"]
WORKDIR "/src/src/ProJaykumarV1.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ProJaykumarV1.Web.Host.dll"]
