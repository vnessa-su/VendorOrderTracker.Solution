# Vendor and Order Tracker

#### Vendor order tracker for Pierre's Bakery.

#### By Vanessa Su

## Description

This page allows for Pierre's Bakery to add Vendors to a list and add Orders to those vendors. It includes a splash page that links to the Vendor List and Add Vendor pages. On the Vendor List page, clicking on a vendor name will take you to its page with a list of orders. Clicking on an order will take you to a page with the order details.

## User Story

* View splash page with a welcome message and links to view vendor list or add a new vendor
* Select `Vendor List` link to view the current list of vendors
* Select `Add New Vendor` link to add a vendor to the list
* Submitting new vendor redirects to splash page
* Select vendor on `Vendor List` page to see orders belonging to that vendor
* Select `Add Order` link to add an order associated with the vendor
* Submitting new order redirects to vendor page
* Select order on the vendor page to see order details

## Technologies Used

* C#
* ASP.NET&#8203; Core
* Razor
* MSTest
* VS Code

## Setup/Installation Requirements

### Prerequisites
* [.NET](https://dotnet.microsoft.com/)
* A text editor like [VS Code](https://code.visualstudio.com/)

### Installation
1. Clone the repository: `git clone https://github.com/vnessa-su/VendorOrderTracker.Solution.git`
2. Navigate to the `\VendorOrderTracker.Solution` directory
3. Open with your preferred text editor to view the code base
* #### Run the Program
1. Navigate to the `\VendorOrderTracker` directory
2. Run `dotnet restore`
3. Run `dotnet build`
4. Start the program with `dotnet run`
5. Open http://localhost:5000/ in your preferred browser
* #### Run the Tests
1. Navigate to the `\VendorOrderTracker.Tests` directory
2. Run `dotnet restore`
4. Start the tests with `dotnet test`

## Known Bugs

* Adding the same vendor or order again will just add a repeat of that vendor or order to the list

## Contact Information

For any questions or comments, please reach out through GitHub.

## License

[MIT License](license)

Copyright (c) 2021 Vanessa Su