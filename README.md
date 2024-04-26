# PlayerAPI

## NBA Player API

### Data source
Data is downloaded from kaggle as csv and stored in nbaplayerdb in mysql

### Install mysql
Use a docker instance in wsl or linux or windows docker desktop and install an instance of mysql
Connect to the instance using mysql workbench

### Steps to transform data from csv to mysql nbaplayerdb
1. crate the database nbaplayerdb `create database nbaplayerdb;`
2. right click on nbaplayerdb and select `table data import wizard`
3. browse the file path and select the file
4. the table will be create with the same name as file name and data will auto imported to that table



### REST API in ASP Dotnet Core to get information about NBA Players

Run the asp dotnet application using visual studion as IIS or run it in docket container
user the localhost:port number for the api call, eg web api is runnign non localhost:44384

Add the mysql connection string in appsetting for local checkup or use keyvault if needed or secret.json file

### REST end points
`https://localhost:44384/api/players/{playerId}` -> fetches the player data for that particular Id

`https://localhost:44384/api/players` -> fetches all players data

`https://localhost:44384/api/players/stream` -> fetches all players data as async stream

EfCore with msql is used as ORM for CRUD operation
