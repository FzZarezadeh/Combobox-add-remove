![ComboBox Manager Icon](https://copilot.microsoft.com/th/id/BCO.7a2b1f4d-3d9a-4c9e-9f4a-2a1d3a7c9e8f.png)

🧾 ComboBox Manager with Date & Time Display

A Windows Forms application written in C# that allows users to dynamically add and remove items from a ComboBox, while also displaying the current date and time. This project is perfect for beginners learning form events, control manipulation, and basic UI feedback.

---

📦 Features

- Dynamic ComboBox Control:
  - Add items to the ComboBox using a text input and the "Add" button.
  - Remove selected items using the "Remove" button.
  - Prevents empty input and unselected removal with warning messages.

- Date & Time Display:
  - Shows the current system time and date in labels when the form loads.
  - Uses DateTime.Now with ToLongTimeString() and ToLongDateString() for formatting.

- User Feedback:
  - Displays warning messages using MessageBox when input is missing or no item is selected.

---

🛠 Technologies Used

- Language: C#
- Framework: .NET Framework (Windows Forms)
- IDE: Visual Studio
- UI Components: ComboBox, Button, Label, MessageBox, DateTimePicker

---

🚀 How to Run

1. Clone or download the repository.
2. Open the solution in Visual Studio.
3. Build and run the project.
4. Use the text box to enter a value and click "Add" to insert it into the ComboBox.
5. Select an item from the ComboBox and click "Remove" to delete it.
6. View the current date and time displayed on the form.

---

📁 Project Structure

`
ComboBoxManager/
├── Form1.cs              // Main form logic for ComboBox and date/time display
├── Form1.Designer.cs     // UI layout and control definitions
├── Program.cs            // Application entry point
`

---

💡 Educational Value

This project helps you practice:

- Handling form events (Load, Click)
- Manipulating ComboBox items dynamically
- Displaying system time and date
- Providing user feedback with MessageBox
- Basic input validation
