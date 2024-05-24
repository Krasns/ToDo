Hello,
This is a simple MVC ToDo app.
<br>
<h3>Installation</h3>
<ol>
  <li> Clone the repository: https://github.com/your-username/to-do.git</li>
  <li> Open the solution file (.sln) in Visual Studio 2022(VS 2022).</li>
  <li>To get the database set up:
    <ol>
          <li>In file - appsettings.json, change the DefaultConnection for your one</li>
          <li>VS2022 Has to have - Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools. You can get them throu NuGet Package Manager</li>      
      </ol>
  </li>
  <li> Build the solution (Ctrl+Shift+B).</li>
</ol>
<br>
<h3>Usage</h3>
<ul>
  <li> Run the application.</li>
  <li> Click the "ToDo List" in the top left.</li>
  <li> Add a new ToDo item by clicking the "Add" button.</li>
  <li> Mark a ToDo item as completed by clicking the by clicking the "Complete" button. It will turn the task's background blue and text white.</li>
  <li> Delete a ToDo item by clicking the "Delete" button.</li>
</ul>
