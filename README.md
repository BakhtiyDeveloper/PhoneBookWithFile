> # PhoneBookWithFile

## This project creates a simple and convenient interface for managing the phone book. Users can contacts to add, read, remove, search and clear in a Text file or JSON file of their contacts.

---------------------------------------------------------------------------

### Components

* Program.cs: The main entry point of the application. It initializes the services and handles user input.

* IUserInterfaceService: An interface that defines methods for interacting with the user.

* UserInterfaceService.cs: Implements the `IUserInterfaceService` to provide functionality for managing contacts.

* ILoggingService: An interface that defines methods for logging messages.

* LoggingService.cs: Implements the `ILoggingService` to provide logging functionality.


```cs 
'''
IUserInterfaceService userservice = new UserInterfaceService();
ILoggingService loggingService = new LoggingService();

loggingService.LogInformation("========== Welcome to our project ==========");
loggingService.LogInformation("In this project, you can work with contacts in the Phone book file");
loggingService.LogInformation("=======================================================\n\n");

loggingService.LogInformation("========== We have two types of files ==========");
loggingService.LogInformation("Which file you want to work with");
loggingService.LogInformation("-'1'- \"Phone book\" txt file!");
loggingService.LogInformation("-'2'- \"Phone book\" json file!");
loggingService.LogInformation("-'3'- EXIT");
loggingService.LogInformation("=======================================================\n\n");

string userChoose = loggingService.LogInformationAndGetUserValue("Choose one of the files: ");

bool isExit = true;

while (isExit) 
{
    switch (userChoose) 
    {
        case "1":
            Console.Clear();
            userservice.UseWithTxtFile();
            break;

        case "2":
            Console.Clear();
            userservice.UseWithJsonFile();
            break;

        case "3":
            Console.Clear();
            loggingService.LogInformation("Thank you for using our project");
            isExit = false;
            break;
        default:
            loggingService.LogErrorInformation("You pressed the wrong button!");
            break;
    }
}

'''
```

### Usage

1. Welcome Message: Displays a welcome message and brief description of the application's functionalities.

2. File Selection: Prompts the user to choose between working with a text file, a JSON file, or exiting the application.

3. File Operations:

    * For text file operations, it calls `UseWithTxtFile` from `UserInterfaceService`

    * For JSON file operations, it calls `UseWithJsonFile` from `UserInterfaceService`

4. Exit: Users can exit the application by selecting the exit option.

### UserInterfaceService

* UseWithTxtFile(): Manages contacts in a text file, providing options to add, remove, read, search, and clear contacts.

* UseWithJsonFile(): Manages contacts in a JSON file, providing similar options as for text files.

### Result to GIF.

![Result to GIF](/PhoneBookWithFile/Rusult%20to%20GIF/result%20gif2.gif)

