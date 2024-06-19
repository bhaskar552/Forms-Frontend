# Forms Desktop App

## Description

This is the desktop application for the Forms App. It is built with Visual Basic and runs on Windows.

## Features

- View Submissions
- Create New Submissions
- Stopwatch functionality
- Edit Submissions
- Delete Submissions
- Tooltips for better user understanding
- MessageBox alerts for clear messages

## Keyboard Shortcuts

- `Ctrl + V`: View Submissions
- `Ctrl + N`: Create New Submission
- `Ctrl + P`: Previous Submission (on View Submissions page)
- `Ctrl + N`: Next Submission (on View Submissions page)
- `Ctrl + T`: Toggle Stopwatch (on Create Submission page)
- `Ctrl + S`: Submit (on Create Submission page)
- `Ctrl + S`: To submit edited records(on View Submissions page)
- `Ctrl + D`: Delete Submission (on View Submissions page)

## Running the App
1. Before Starting the App make sure the backend is running locally in the system. The Backend can be found here https://github.com/bhaskar552/Forms-Backend
1. Open the solution file in Visual Studio.
2. Build and run the application.

The application will start with the main form, allowing you to navigate to view, search, edit, delete, or create submissions.

## Tooltips and MessageBox

- Tooltips have been added to each field for better understanding.
- MessageBox alerts provide clear messages about the operations being performed.

## Workflow of the App

The Desktop App provides a user-friendly interface for managing form submissions. Here's a detailed workflow of the application:

Starting the Application

Upon launching the application, the Form1 is displayed. This form includes buttons for navigating to different functionalities: "View Submissions," "Create New Submission,"

Creating a New Submission

Click the "Create New Submission" button or use the shortcut Ctrl + N.
The CreateSubmissionForm opens, presenting fields for Name, Email, Phone Number, GitHub repository link, and a stopwatch.
Tooltips provide guidance on what to enter in each field.
The stopwatch can be started and paused using the "Toggle Stopwatch" button (Ctrl + T).
After filling in the details, click the "Submit" button or use the shortcut Ctrl + S.
A MessageBox confirms that the form has been submitted successfully.

Viewing Submissions

Click the "View Submissions" button or use the shortcut Ctrl + V.
The ViewSubmissionsForm opens, displaying the first submission by default.
Navigate through the submissions using the "Previous" (Ctrl + P) and "Next" (Ctrl + N) buttons.
Edit a submission by clicking the "Submit" button after editing any records (Ctrl + S). A MessageBox confirms successful editing.
Delete a submission by clicking the "Delete" button (Ctrl + D). A MessageBox confirms successful deletion.



Tooltips: Every field and button has a tooltip to assist users in understanding its purpose.
MessageBox Alerts: Informative messages are displayed using MessageBox to confirm actions like submission, editing, and deletion.
Backend Integration

The app interacts with a backend server (built using Express and TypeScript) for data persistence.
Form data is submitted to the backend, and submissions are fetched from the backend to display in the app.
The backend includes endpoints for submitting, reading, editing, deleting, and searching submissions.
