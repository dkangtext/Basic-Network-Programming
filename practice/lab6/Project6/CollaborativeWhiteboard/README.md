# Collaborative Whiteboard

## Overview
The Collaborative Whiteboard is a real-time drawing application that allows multiple users to connect and interact with a shared whiteboard. Users can draw, erase, and save their work while seeing updates from other connected clients in real-time.

## Features
- Real-time collaboration: Multiple users can draw on the whiteboard simultaneously.
- Drawing tools: Select from various drawing tools, colors, and brush sizes.
- Client management: View connected clients and their statuses.
- Save functionality: Save the current state of the whiteboard as an image (PNG or JPG).
- Network communication: Efficient client-server communication for updates and drawing synchronization.

## Getting Started

### Prerequisites
- .NET Framework (version required)
- Visual Studio or any compatible IDE

### Installation
1. Clone the repository:
   ```
   git clone <repository-url>
   ```
2. Open the solution file `CollaborativeWhiteboard.sln` in your IDE.
3. Restore the NuGet packages if necessary.
4. Build the solution.

### Running the Application
1. Start the server by running the `Program.cs` file.
2. Connect clients using the `ConnectionDialog` to join the whiteboard.
3. Use the drawing tools to create and modify drawings on the whiteboard.

## Usage
- Use the toolbar to select drawing tools and colors.
- Click and drag on the whiteboard to draw.
- Use the eraser tool to remove unwanted drawings.
- Save your work using the save option in the menu.

## Contributing
Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.