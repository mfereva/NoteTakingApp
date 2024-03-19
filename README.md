NoteTakingApp
=============

NoteTakingApp is a simple Windows Forms application for taking and managing notes.

Features
--------

- Create new notes
- View existing notes
- Update note content
- Delete notes

Getting Started
---------------

### Prerequisites

- Visual Studio (version X.X or higher)
- SQL Server Management Studio (SSMS)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/your-username/NoteTakingApp.git
   ```

2. Open the solution file (`NoteTakingApp.sln`) in Visual Studio.

3. Build the solution to restore dependencies.

4. Open SQL Server Management Studio (SSMS) and create a database named `NoteDB`.

5. Run the SQL script (`NoteDB_Script.sql`) located in the `DatabaseScripts` directory to create the necessary `Notes` table.

6. Update the connection string in the `app.config` file with your SQL Server instance and database name:

   ```xml
   <connectionStrings>
     <add name="NoteDBConnectionString" connectionString="Data Source=YOUR_SERVER_NAME;Initial Catalog=NoteDB;Integrated Security=True" providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

7. Press F5 to run the application.

Usage
-----

1. Launch the application.
2. Click on the "Create" button to create a new note.
3. Enter the title and content for the note.
4. Click the "Save" button to save the note.
5. To update a note, click on the note title in the list view.
6. To delete a note, click on the note title in the list view and then click the "Delete" button.

