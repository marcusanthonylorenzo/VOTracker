# Vendor/Order Tracker System
#### By _**Marcus Lorenzo**_
---


| **_Overview_:** |
|---|

### Features:
- User must create a new vendor before placing an order.
- If there are no vendors, there is a notification.
- If there are no orders, there is a notification.
- Once there are orders, it will reference the vendor which was chosen, and a link routing them to the vendors individual page.
- Equally, vendors show a list of orders that have been requested.
- Links of vendors/orders on both sides to check for reference.
- There is no delete function as it is not MVP, as I chose to focus on linear styling/access than add new functions.


#### Technologies Used:
![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![image](https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white)  ![image](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)
![image](https://img.shields.io/badge/GIT-E44C30?style=for-the-badge&logo=git&logoColor=white)

---


| **_Description_:** |
|---|

A barebones order tracking system that needs more styling, but allows both orders and vendor information to flow on both ends.

---

| **_Setup & Installation_:** |
|---|

|   via CLI   |
|---|
| Download install Git Bash (Windows), use the terminal in your text editor, or open Terminal(Mac) 
| Open Git Bash or Terminal and type: `cd desktop` 
| Next, clone `[https://github.com/marcusanthonylorenzo/](https://github.com/marcusanthonylorenzo/VOTracker)` 
| Once completed, open this new directory in your text editor
| To run, in your terminal type `cd VOTracker.Solution/VOTracker`.
| Next, type `dotnet build`, press enter, then type `dotnet watch run`, enter.
| View on LocalHost:5000 or 5001


#### Running Tests:
- To view tests via MSTest, in your CLI go to the `VOTracker.Tests` directory and type `dotnet test`.

#### Known Bugs:
* Large lists of vendors or orders may overflow, but the core functionality is sound.

---

---
| **_License_:** |
|---|

[MIT]()

Copyright (c) 2022 _Marcus Lorenzo_


#### Thanks for viewing!
