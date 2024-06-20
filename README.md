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
