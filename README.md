1.git clone https://github.com/SeodigengO/JobBoardApiLatest.git
2. cd JobBoard
3 . Configure your database connection in the .env file
"ConnectionStrings": {
  "DefaultConnection": ""
}
4. Apply EF Core migrations
dotnet ef database update --project Repository --startup-project API
5. Dotnet run
