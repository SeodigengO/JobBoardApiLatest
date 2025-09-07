git clone https://github.com/SeodigengO/JobBoardApiLatest.git
cd JobBoard
2. Configure your database connection in the .env file
"ConnectionStrings": {
  "DefaultConnection": ""
}
3. Apply EF Core migrations
dotnet ef database update --project Repository --startup-project API
4. Run the API
