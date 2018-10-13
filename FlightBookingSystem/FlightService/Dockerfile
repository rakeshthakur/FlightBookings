FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["*.csproj", "./"]
RUN dotnet restore

#Copy remaining files
COPY . .
RUN dotnet build -c Release -o /app
RUN dotnet publish -c Release -o /app

#Create image using runtime base image
FROM microsoft/dotnet:2.1-aspnetcore-runtime AS final
WORKDIR /app
EXPOSE 80
ENV ConnectionString="Server=tcp:flightbookingservice.database.windows.net,1433;Initial Catalog=FlightBookingService;Persist Security Info=False;User ID=casestudy;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
COPY --from=build /app .
ENTRYPOINT ["dotnet", "FlightService.dll"]