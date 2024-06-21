# SlidelyFormApp
Replicating the functionality of Google Forms in a Windows Desktop App

## Overview
A Sleek Windows Forms application that brings the Functionality of a basic Google Forms right to your Desktop. This app lets you effortlessly create, view, search, and delete submissions with ease, capturing  essential details such as Name, Email, Phone Number, GitHub Repo Link, and Stopwatch Time, all with a user-friendly interface.

## Components

**1. The Desktop App - has 3 interconnected components => MainForm.vb, CreateSubmissionForm.vb, and ViewSubmissionForm.vb**

1. **MainForm.vb** is the entry point to the Desktop App and has 2 buttons: "View Submissions" and "Create New Submission".
    **View Submission** displays the first form if available, else an empty form.
    **Create New Submission** Displays and empty editable form that collects details from the user.

    <img src="https://github.com/maximistic/SlidelyFormApp/assets/110153672/1afa98ca-7f7a-4b02-8e60-81931bc248de" alt="MainForm" width="400" height="300">
    
2. **ViewSubmissionForm.vb** is opened on clicking the "View Submissions" button in the MainForm.vb to view previous submissions made by the user.
    **Buttons:**
    * Search (Ctrl + S)   - used to search forms by the user email id
    * Previous (Ctrl + P) - used to navigate to the previous form if it exists
    * Next (Ctrl + N)     - used to navigate to the next form if it exists
    * Delete (Ctrl + D)   - used to delete the current form from the database

    <img src="https://github.com/maximistic/SlidelyFormApp/assets/110153672/b73f1fc7-02fe-4947-b4cb-8b9e1ae6aa5f" alt="ViewSubmissionsForm" width="400" height="300"> 

    * **ViewSubmissionsForm.vb** form has four buttons - "Previous", "Next", "Search", and "Delete".

        <img src="https://github.com/maximistic/SlidelyFormApp/assets/110153672/182223ec-d21d-487f-b0e6-13604fa817a3" alt="ViewButtons" width="300" height="200">
        <img src="https://github.com/maximistic/SlidelyFormApp/assets/110153672/0b04983e-84b4-4de0-b2f5-32417acd0895" alt="ViewDetails" width="300" height="200">
    
    * By default, the "View Submissions" form displays the first entry. The "Previous" and "Next" buttons let the user go through all form entries one by one.

3. Clicking the "Create New Submission" button opens up a form to create submissions.
    **Buttons:**
    * Toggle Stopwatch (Ctrl + T)   - used to search forms by the user email id
    * Submit (Ctrl + S) - used to navigate to the previous form if it exists

    **Fields**
    * Name 
    * Email - email@gmail.com
    * Phone number - **********
    * Github Link - Github.com/user
    
    <img src="https://github.com/maximistic/SlidelyFormApp/assets/110153672/17fc0523-1a1d-4e2d-8893-5098cf1452f5" alt="CreateSubmissionForm" width="400" height="300">

    * It has editable fields for Name, Email, Phone Number, and a GitHub repo link. This form also has a button that resumes and pauses a stopwatch.

        <img src="https://github.com/maximistic/SlidelyFormApp/assets/110153672/7199bd3b-fc92-4ea5-af95-ff2c9ec82b56" alt="Stopwatch" width="300" height="200">
    
    * The stopwatch does not reset from 0 every time it is paused.


 **2.The Backend (backend > src > app.ts) is an Express App made with TypeScript and using a JSON file as a database to store submissions.**

* The backend has 3 endpoints:
    1. /ping - A GET request that always returns True
    2. /submit - A POST request with parameters "name", "email", "phone", "github_link" and "stopwatch_time"
    3. /read - A GET request with query parameter "index" which is a 0-index for reading the (index+1)th form submission.

## Prerequisites
1. Visual Studio with .NET Framework
2. Newtonsoft.Json (NuGet packages)
3. Node js

## How to Install and use this project

1. Clone the Repository
    * git clone https://github.com/maximistic/SlidelyFormApp.git
    * cd SlidelyFormApp
2. Open SlidelyFormAPP and click on FormApp.sln (which opens up a Visual Studio Window), Restore NuGet packages (Newtonsoft.Json specifically) and build the solution.
3. Open up MainForm.vb, CreateSubmissionForm.vb and ViewSubmissionsForm.vb
4. If ViewSubmissionsForm.vb returns an error while opening, click on "Ignore and Continue" followed by "Yes"
5. Before running the desktop app, setup the node js dependencies as:
        npm install
        npm install express body-parser @types/express @types/body-parser @types/node
6. Once all the dependencies are set, navigate to bin > Debug > backend and run the following command to start the backend server 
        npm start
7. Once the Backend is up and running and the server is listening (Server is running on http://localhost:3000), run the Desktop App in visual studio.
8. db.json (backend > src > db.json) acts as the database for storing the form's data.

## Features 
1. Navigate Between Create and View Submissions 
2. Create New Submissions 
3. View existing Submissions
4. Search Submissions by their Email address
5. Delete Submissions from the database
6. Stop Watch

## Keyboard Shortcuts
1. Ctrl + V : VIEW SUBMISSIONS
2. Ctrl + N : CREATE NEW SUBMISSION/ NEXT 
3. Ctrl + S : SEARCH/ SUBMIT
4. Ctrl + P : PREVIOUS
5. Ctrl + D : DELETE
6. Ctrl + T : TOGGLE STOPWATCH