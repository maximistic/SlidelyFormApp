# SlidelyFormApp
Replicating the functionality of Google Forms in a Windows Desktop App

## Overview
A Sleek Windows Forms application that brings the Functionality of a basic Google Forms right to your Desktop. This app lets you effortlessly create, view, search, and delete submissions with ease, capturing  essential details such as Name, Email, Phone Number, GitHub Repo Link, and Stopwatch Time, all with a user-friendly interface.

## Components

**1. The Desktop App - has 3 interconnected components => MainForm.vb, CreateSubmissionForm.vb and ViewSubmissionForm.vb**
1. MainForm.vb has 2 buttons, "View Submissions" and "Create New Submission".
![bced5601761d3b04d7f0f5bd4ffe8b72d2d015ab](https://github.com/maximistic/SlidelyFormApp/assets/110153672/1afa98ca-7f7a-4b02-8e60-81931bc248de)
2. Clicking the "View Submissions" button opens up a form ("ViewSubmissionsForm.vb") to view previous submissions made by the user.
![c2b8afddd07b6bb3048f36c0a1d78fa48eca918f](https://github.com/maximistic/SlidelyFormApp/assets/110153672/b73f1fc7-02fe-4947-b4cb-8b9e1ae6aa5f) 
    * ViewSubmissionsForm.vb form has four buttons - "Previous", "Next", "Search" and "Delete".
    ![1bf66bf1edbc12a4d1f34c87895cdfe49d8a8557](https://github.com/maximistic/SlidelyFormApp/assets/110153672/182223ec-d21d-487f-b0e6-13604fa817a3)
    ![b4a4c0a3e8bfd8bd824aba83a0e2dfab1c221ae6](https://github.com/maximistic/SlidelyFormApp/assets/110153672/0b04983e-84b4-4de0-b2f5-32417acd0895)
    * By default, the "View Submissions" form displays the first entry. previous and next buttons let the user go through all form entries one by one.
3. Clicking the "Create New Submission" button opens up a form to create submissions.
![3cf3415dbb4bc151131c7f651c445b7383dbd231](https://github.com/maximistic/SlidelyFormApp/assets/110153672/17fc0523-1a1d-4e2d-8893-5098cf1452f5)
    * It has editable fields for Name, Email, Phone Number, a GitHub repo link. This form also has a button that resumes and pauses a stopwatch.
    ![e7904dcde7efe233a04c483537afdbdb2ca5144d](https://github.com/maximistic/SlidelyFormApp/assets/110153672/7199bd3b-fc92-4ea5-af95-ff2c9ec82b56)
    * The stopwatch does not reset from 0 everytime it is paused.

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

## Some working images for reference:

<!-- ![0b17573f6003d9839f0b18f4af5f6d6db8ae17b4](https://github.com/maximistic/SlidelyFormApp/assets/110153672/292acaad-e3c3-4048-84b0-74e749f7f782) -->








