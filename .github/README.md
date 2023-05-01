# Fees Management

**DISCLAIMER:** This is Work In Progess, functionality and features may be broken or still under development.

Simple login and reports generation for a single student, an entire class or the entire school when requested.

## Folder Structure

The projects contains two types of folders. These are GitHub folders and System folders.

### Github Files

Folder | Description
---|---
.github | Contains github configuration files (including this **README.md** file) and is safe to delete.

### System Files

These are the files in the FeesManagement directory

Folder | Description
---|---
Components | Contains all the custom designs
Properties | Automatically created with SharpDevelop
Utils | Contains custom utility functions that help with validation
Views | This is where all views are kept

## How it works

The system does not make use of an SQL Database but rather stores it's data temporarily in memory using **Lists** and **Dictionaries**. 

Lists can be described as 1D Arrays of one type while Dictionaries are Objects that map data using a unique.

These data types have been initialized in the **Reports** form under Views and they look something like this:

```cs
// initialize
public Dictionary<string,School> Schools = new Dictionary<string,School>();

// create a new school
Schools["Junior High"] = new School();

// add a new student
Schools["Junior High"].Add(Student);

// Student & School are classes
// defined in the Models folder
```

Custom functionality for searching students has been written in the (Schools) models file(s) in a less confusing way though it can be refactored.

## Icons Used

All icons in this project were downloaded from [icons8](//Icons8.com)
