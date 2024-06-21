import express, { Application, Request, Response } from "express";
import bodyParser from "body-parser";
import fs from "fs";
import path from "path";

const app: Application = express();
const PORT: number = 3000;

app.use(bodyParser.json());

const dbPath = path.join(__dirname, "db.json");

// Initialize db.json if it does not exist
if (!fs.existsSync(dbPath)) {
    fs.writeFileSync(dbPath, JSON.stringify({ submissions: [] }, null, 2));
}

// Endpoint to check if the server is running
app.get("/ping", (req: Request, res: Response) => {
    res.send(true);
});

// Endpoint to submit a form
// Endpoint to submit a form
app.post("/submit", (req: Request, res: Response) => {
  const { name, email, phone, github_link, stopwatch_time } = req.body;

  if (!name || !email || !phone || !github_link || !stopwatch_time) {
      return res.status(400).send("All fields are required.");
  }

  const newSubmission = { name, email, phone, github_link, stopwatch_time };

  // Read existing submissions
  let data: any;
  try {
      data = JSON.parse(fs.readFileSync(dbPath, "utf-8"));
  } catch (err) {
      data = { submissions: [] }; // Initialize with empty submissions array if file is empty or corrupted
  }

  // Ensure submissions array exists and is an array
  if (!data.submissions || !Array.isArray(data.submissions)) {
      data.submissions = [];
  }

  // Push new submission
  data.submissions.push(newSubmission);

  // Write new submissions back to the JSON file
  fs.writeFileSync(dbPath, JSON.stringify(data, null, 2));

  res.status(201).send("Submission saved.");
});


// Endpoint to read a form submission by index
app.get("/read", (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string);

    const data = JSON.parse(fs.readFileSync(dbPath, "utf-8"));

    if (index < 0 || index >= data.submissions.length) {
        return res.status(404).send("Submission not found.");
    }

    res.status(200).json(data.submissions[index]);
});

// Endpoint to search submission by email
app.get("/search", (req: Request, res: Response) => {
    const { email } = req.query;

    if (!email || typeof email !== "string") {
        return res.status(400).send("Email parameter is required.");
    }

    const data = JSON.parse(fs.readFileSync(dbPath, "utf-8"));
    const submission = data.submissions.find((s: any) =>
        s.email.toLowerCase() === email.toLowerCase()
    );

    if (!submission) {
        return res.status(404).send("Submission not found.");
    }

    res.status(200).json(submission);
});

app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});