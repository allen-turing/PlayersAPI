# PlayerAPI

## NBA Player API

### Data source
Data is downloaded from Kaggle as csv and stored in nbaplayerdb in MySql

### Install MySql
Use a docker instance in wsl or Linux or windows docker desktop and install an instance of mysql
Connect to the instance using MySql workbench

### Steps to transform data from csv to mysql nbaplayerdb
1. crate the database nbaplayerdb `create database nbaplayerdb;`
2. right click on nbaplayerdb and select `table data import wizard`
3. browse the file path and select the file
4. the table will be created with the same name as file name and data will auto imported to that table



### REST API in ASP Dotnet Core to get information about NBA Players

Run the asp dotnet core application using visual studio as IIS Profile or command line using `dotnet run` or run it in docker container
use the localhost:port of the server running for the api call, eg web api is running on localhost:44384 in IIS Profile using visual studio

Add the MySql connection string in appsetting.json for local setup or use key vault if needed or secret.json file

### REST end points
`https://localhost:44384/api/players/{playerId}` -> fetches the player data for that particular Id

`https://localhost:44384/api/players` -> fetches all players data (this is time intensive and memory expensive when data set is large)

`https://localhost:44384/api/players/stream` -> fetches all players data as async stream this is efficient

EfCore with MySql is used as ORM for CRUD operation
