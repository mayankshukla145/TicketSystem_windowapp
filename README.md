Support Ticket Management System

Technology: C# WinForms + ASP.NET Web API + SQL Server

🔹 Project Overview

This is a role-based Support Ticket Management System where:

Users can raise support tickets

Admins can assign tickets, update status, and manage users

Complete ticket history and comments are maintained

The project follows a real-world enterprise workflow.

🔹 User Roles
👤 User

Login to system

Create new tickets

View own tickets

View ticket details and history

Add comments on tickets

👨‍💼 Admin

View all tickets

Assign tickets to admins

Change ticket status (Open / In Progress / Closed)

View ticket history

Add comments

Create, update, and delete users

View dashboard summary

🔹 Main Features
🎫 Ticket Management

Auto-generated Ticket Number

Priority based tickets

Status tracking

Assigned admin tracking

🕒 Ticket History

Ticket creation log

Status change history

Comment history

Chronological order

💬 Comments

User & Admin comments

Stored with date and user info

Visible in ticket details

👥 User Management (Admin)

Add new users

Update user role (Admin/User)

Soft delete users

Assign tickets only to active admins

📊 Admin Dashboard

Total Tickets

Total Open Tickets

Total Closed Tickets

🔹 Technology Stack
Frontend

C# WinForms (.NET)

DataGridView, Panels, GroupBoxes

HttpClient for API calls

Backend

ASP.NET Web API

ADO.NET

Stored Procedures

Database

SQL Server

Normalized tables

History & audit tables

🔹 Database Tables

Users

Tickets

TicketStatusHistory

TicketComments

🔹 Important Stored Procedures

sp_CreateUser

sp_GetTicketList

sp_GetTicketDetails

sp_UpdateTicketStatus

sp_AddTicketComment

sp_GetTicketHistory

sp_GetTicketSummary

🔹 Application Flow

User/Admin logs in

Dashboard loads based on role

User creates ticket

Admin assigns ticket and updates status

History and comments are auto-maintained

Dashboard shows live ticket summary

🔹 Security Notes

Role-based UI access

Admin features hidden from normal users

Soft delete used for users

Password hashing can be added for production

🔹 How to Run

Restore SQL Server database

Update connection string in Web.config

Run Web API project

Run WinForms application

Login using Admin or User credentials

🔹 Future Enhancements

Password encryption

Email notifications

Ticket attachments

Search & filters

Export reports
