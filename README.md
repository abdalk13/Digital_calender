# Digital Calendar

## Overview

The Digital Calendar is a Windows Forms application built with C#. It allows users to manage events by adding, viewing, and deleting them on specific dates. Dates with events are highlighted on the calendar.

## Features

- **Add Events**: Schedule events on specific dates.
- **View Events**: Display events for a selected date.
- **Delete Events**: Remove events from a selected date.
- **Highlighted Dates**: Dates with events are highlighted in the calendar.

## Getting Started

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/abdalk13/Digital_calender.git
    ```
2. Open the solution file `DigialCalendar.sln` in Visual Studio.
3. Restore NuGet packages:
    ```sh
    dotnet restore
    ```
4. Build the solution:
    ```sh
    dotnet build
    ```
5. Run the application:
    ```sh
    dotnet run
    ```

## Usage

1. **Add Event**:
    - Select a date from the calendar.
    - Enter the event description.
    - Click "Add Event".
2. **View Events**:
    - Select a date from the calendar to see events.
3. **Delete Event**:
    - Select the event from the list and click "Delete Event".

## Code Structure

- **Form1.Designer.cs**: Layout and initialization of Windows Forms controls.
- **Form1.cs**: Main logic for adding, viewing, and deleting events, and highlighting dates.

## Contributing

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -am 'Add feature'`).
4. Push to the branch (`git push origin feature/YourFeature`).
5. Open a Pull Request.

------------------------------------
