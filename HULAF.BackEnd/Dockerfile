FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:sdk AS build
WORKDIR /src

COPY *.sln ./
COPY HULAF.DataAccess/*.csproj ./HULAF.DataAccess/
COPY HULAF.Domain/*.csproj ./HULAF.Domain/
COPY HULAF.WebApi/*.csproj ./HULAF.WebApi/

RUN dotnet restore

COPY . .
WORKDIR /src/HULAF.DataAccess
RUN dotnet build -c Release -o /app

WORKDIR /src/HULAF.Domain
RUN dotnet build -c Release -o /app

WORKDIR /src/HULAF.WebApi
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HULAF.WebApi.dll"]