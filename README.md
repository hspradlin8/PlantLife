# PlantLife
### A Restaurant and Meal Dietary Guide | NSS Back-End Capstone

I built this application to help new gardeners and inexperienced gardeners to keep track of their plants and their plants health. Users will be able to add their own plants or pick from a list of plants in the succulent family to add to their list. Users can upload images of their plants and track their plants watering needs by using the calendar.   

App was built using C#/.NET Core with Entity Framework using Identity and styled using Bootstrap 4. Relational database was managed using SQL Server.

## Instructions for Cloning and Running the Project Locally
**Note: Visual Studio and SQL Server are required to run this project.**

1. Navigate to the directory where you want to save the project, and run the following command in your terminal:
```
 git@github.com:hspradlin8/PlantLife.git
```
2. To open the solution file in Visual Studio, run the following command: 
```
start Plant Life.sln
```
3. When Visual Studio opens, select **Tools > NuGet Package Manager > Package Manager Console** and run the following command in the Package Manager Console: 
```
Update-Database
```
This command will generate the database and seed it with sample data, including the following user:
* Admina Straytor
  * Email: admin@admin.com
  * Password: Admin8*

4. Start the program and log in as one of the above users
