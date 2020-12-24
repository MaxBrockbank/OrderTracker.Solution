<h1 align="center">~Pierre's Vendor and Order Tracker~</h1>
<div align="center">
<img src="https://github.com/MaxBrockbank.png" width="200px" height="auto" >
</div>
<p align="center">Authored by Max Brockabnk</p>
<p align="center">Updated on Dec 18, 2020</p>

# Description

A web application made in C# used to track for our fictional character Pierre to tracker the orders different vendors have made to his bakery. It was a practice in creating a UI with ASP.NET Core MVC, using objects within objects and unit testing with MSTest.

## Required Technologies
* C#
* Text Editor

## Set-up Instructions
1. Clone this repo to your local computer.
2. Open it up in your text editor.
3. In your terminal navigate from the root directory to the `OrderTracker.Tests` sub-directory.
4. Run the command `dotnet restore` to create the obj directories and allow for using the testing tools. Then run the command `dotnet test` in this same directory to run unit testing.
5. In your temrinal navigate from the `OrderTracker.Test` sub-directory to its sibling directory `OrderTracker` which is the production version of our project.
6. Run the command `dotnet run` to build and run the program.

## Technologies Used
* C# / .NET
* MSTest

## Specs
<details>

<summary> Checkout Specs</summary>

| Test  | Input | Output  |
| :--- | :---: |  :---:  |

Order Tests

|Test the Order Constructor by making sure it is of type Order| "one string", "two strings"| new Order object|
|Test the GetAll method that it can retrieve a static list of all of the Order objects| | List of Order objects|
|Test the Find method that it can retrieve a specific Order object given an integer of its ID| 3 | the 4th Order object made|

Vendor Tests
|Test the Vendor constructor by making sure it is of type Vendor| "one string", "two strings"| new Vendor object|
|Test the GetAll method that it can retrieve a static list of all the Vendor objects| | List of Vendor objects|
|Test the Find method that it can retrieve a specific vendor object given an integer of its ID| 3 | the 4th Vendor object created|
|Test that the AddOrder method can add an Order object to Orders list when passed an Order object| Order object| vendorObject.Orders has new Order object in it |
</details>


## Known Bugs
* UI not accessile or intuitive
* User cannot remove a Vendor or an order from a vendor (yet)

## Legal
* Copyright © 2020 Max Brockbank
* This software is licensed under the MIT license