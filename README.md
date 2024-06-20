Functionality of Google Forms in a Windows Desktop App:

For the Desktop App, there are 3 interconnected components - MainForm.vb, CreateSubmissionForm.vb and ViewSubmissionForm.vb

    - MainForm.vb has 2 buttons, "View Submissions" and "Create New Submission".
    - Clicking the "View Submissions" button opens up a form ("CreateSubmissionForm.vb") to view previous submissions made by the user. 
        - "View Submissions" form has two buttons - "Previous" and "Next". 
        - By default, the "View Submissions" form displays the first entry. previous and next buttons let the user go through all form entries one by one.
    - Clicking the "Create New Submission" button opens up a form to create submissions.
        - It has editable fields for Name, Email, Phone Number, a GitHub repo link. This form also has a button that resumes and pauses a stopwatch.
        - The stopwatch does not reset from 0 everytime it is paused.

The Backend (backend > src > app.ts) is an Express App made with TypeScript and using a JSON file as a database to store submissions.

    - The backend has 3 endpoints:
        - /ping - A GET request that always returns True
        - /submit - A POST request with parameters "name", "email", "phone", "github_link" and "stopwatch_time"
        - /read - A GET request with query parameter "index" which is a 0-index for reading the (index+1)th form submission.

If the files are not organized properly, try to download the zip file (slidelytask2.zip) directly and use it.

To run the Backend, make sure the backend folder is placed as follows: bin > Debug > backend. Start by running the server (npm start) in a terminal and when the server is listening (Server is running on http://localhost:3000), run the frontend in visual studio. db.json (backend > src > db.json) acts as the database by storing the form's data.

Use SlidelyFormApp > MainForm.vb, ViewSubmissions.vb and createSubmissionForm.vb and backend > src > app.ts

UpdatedViewSubmissionsForm.vb and updatedapp.ts - above and beyond (have inbuilt buttons to delete forms, search forms using the email id provided). heads up - if the design file doesn't open (due to some duplication error), click on ignore and continue and proceed with running the files.

Some of the working images for reference:

![0b17573f6003d9839f0b18f4af5f6d6db8ae17b4](https://github.com/maximistic/SlidelyFormApp/assets/110153672/292acaad-e3c3-4048-84b0-74e749f7f782)
![3cf3415dbb4bc151131c7f651c445b7383dbd231](https://github.com/maximistic/SlidelyFormApp/assets/110153672/17fc0523-1a1d-4e2d-8893-5098cf1452f5)
![bced5601761d3b04d7f0f5bd4ffe8b72d2d015ab](https://github.com/maximistic/SlidelyFormApp/assets/110153672/1afa98ca-7f7a-4b02-8e60-81931bc248de)
![e7904dcde7efe233a04c483537afdbdb2ca5144d](https://github.com/maximistic/SlidelyFormApp/assets/110153672/7199bd3b-fc92-4ea5-af95-ff2c9ec82b56)

Some images after updates (above and beyond):
![c2b8afddd07b6bb3048f36c0a1d78fa48eca918f](https://github.com/maximistic/SlidelyFormApp/assets/110153672/b73f1fc7-02fe-4947-b4cb-8b9e1ae6aa5f)
![b4a4c0a3e8bfd8bd824aba83a0e2dfab1c221ae6](https://github.com/maximistic/SlidelyFormApp/assets/110153672/0b04983e-84b4-4de0-b2f5-32417acd0895)
![1bf66bf1edbc12a4d1f34c87895cdfe49d8a8557](https://github.com/maximistic/SlidelyFormApp/assets/110153672/182223ec-d21d-487f-b0e6-13604fa817a3)

