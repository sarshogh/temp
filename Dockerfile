FROM  mcr.microsoft.com/dotnet/sdk:5.0

COPY . /app
RUN dotnet build ./app/src -o ./output
RUN dotnet test ./app/tests
