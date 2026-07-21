# DotNetCoreFundamentals

# DataPassingInDotNetCore

## Overview

This repository demonstrates different data-passing techniques available in **ASP.NET Core MVC** through a simple **Login** and **Logout** application.

The project showcases how to transfer data between controllers and views using:

* **ViewBag**
* **TempData**
* **Session**

## Features

* Simple Login functionality.
* Dashboard displayed after successful login.
* Username stored in **Session** after login.
* Username displayed on the Dashboard using Session data.
* Logout functionality that clears the Session and redirects the user to the Login page.
* Examples of passing messages using **ViewBag** and **TempData**.

## Project Structure

* **Views/Login/Login.cshtml** – User login page.
* **Views/Login/Logout.cshtml** – Logout page.
* **Views/Dashboard/Index.cshtml** – Dashboard page that displays the logged-in user's name using Session data.

## Data Passing Techniques Demonstrated

### ViewBag

Used to pass data from the Controller to the View for the current request.

### TempData

Used to pass data from one request to another, typically after a redirect.

### Session

Used to store the logged-in user's information across multiple requests until the user logs out or the session expires.

## Workflow

1. User enters login credentials.
2. After successful login, the username is stored in **Session**.
3. The application redirects the user to the Dashboard.
4. The Dashboard displays the username retrieved from Session.
5. When the user clicks **Logout**, the Session is cleared.
6. The user is redirected back to the Login page.

## Technologies Used

* ASP.NET Core MVC
* C#
* Razor Views
* Session State
* ViewBag
* TempData
