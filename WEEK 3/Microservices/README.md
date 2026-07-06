# JWT Authentication Project
Run:
1. dotnet restore
2. dotnet run
Login: POST /api/Auth/login
Body:
{"username":"admin","password":"admin123"}
Use returned Bearer token for protected endpoints.
