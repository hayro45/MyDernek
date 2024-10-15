# MyDernek

## Project Description
 Association Management in C# Layered Architecture. This project is developed as a term project for our Visual Programming course.
As our associate professor required us to start from scratch and rewrite everything, we were mandated to use Access Database and older ADO.NET and its driver codes instead of .NET Framework or .NET Core and SQL Server. The reason is that Microsoft Access DB can be embedded within the project, enabling mobility.

After providing the necessary information, I am sharing the project report and codes to ensure future students don't face the same challenges I did and to contribute to open source. You can download the project and log in using 11111111111 as the username and 123456 as the password.


## Contents
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Report](#report)
- [Contributors](#contributors)
- [License](#license)

## Features
- Adding members (ID number will be the primary key and unique) 
- Listing members by blood type
- Listing members by city
- Viewing members based on status (active/passive)
- Setting the active/passive status of members
- Setting monthly dues (different dues can be set for each month if desired)
- Viewing the payment status of dues for each member
- Listing members with outstanding dues and saving as PDF
- Sending automatic notification emails to members with outstanding dues with a single button click
- Customizing the content of the emails to be sent
- Listing members who have and have not made payments between specific dates
- Graphically displaying monthly and yearly dues income (using ZedGraph component)
- Graphically displaying member distribution by city (using ZedGraph component)
- Creating installation files (setup, install files) with Install Shield to allow program installation on a computer

![image](https://github.com/user-attachments/assets/d6e46393-8f8c-4dae-b5e6-a4944c7fa3d9) 

## Installation
1. Clone the project:
    ```sh
    git clone <https://github.com/hayro45/MyDernek.git>
    ```
2. Install the necessary dependencies:
    ```sh
    dotnet restore
    ```

## Usage
To run the project:
1. Specify the path to the Access Database in the config file.
2. Log in using `11111111111` as the username and `123456` as 

## Report
For the detailed project report, please refer to [Project Report](https://docs.google.com/document/d/1wS37HH1H-tuGdhoGeTwrrjFjzjFe4_3gjFbuQ4lO7W8/edit?usp=sharing)

**Note:** The project report is written in Turkish and includes only the sections for class diagrams and scenario diagrams.

## Contributors
- [Hayrettin Dal](https://www.linkedin.com/in/hayrettin-dal-94028a182/)

## License
This project is licensed under the MIT License.
