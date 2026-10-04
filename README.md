# 🎨 Institute of Fine Arts

> A role-based ASP.NET Core platform for managing competitions, student artwork, evaluations, awards, and institute workflows in one place.

## ✨ Overview

**Institute of Fine Arts** is a web-based management platform designed around the day-to-day workflow of an art institute.

Instead of handling competitions, student submissions, evaluations, and institute records through disconnected manual processes, the platform brings them together into a single role-based system.

The project combines two ideas:

- **Art Institute Management System**
- **Student Art & Competition Management Platform**

Each user gets a different experience based on their role: **Student, Staff/Teacher, Manager, or Admin**.

## 👥 Roles at a Glance

| Role | Main Responsibility |
|---|---|
| 🎨 **Student** | Participate in competitions, submit artwork, and view evaluations |
| 👨‍🎨 **Staff / Teacher** | Manage competitions, review submissions, evaluate creativity, and add remarks |
| 🧑‍💼 **Manager** | Monitor institute information and view records |
| 👑 **Admin** | Manage users, monitor staff activity, and oversee the platform |

## 🔐 Demo Accounts

These accounts are already connected to **pre-populated data**, so you can explore the platform immediately without creating everything from scratch.

| Role | Email | Password |
|---|---|---|
| 🎨 Student | `walter@gmail.com` | `w12345678` |
| 👨‍🎨 Teacher / Staff | `michael@gmail.com` | `m12345678` |
| 🧑‍💼 Manager | `john@gmail.com` | `j12345678` |
| 👑 Admin | `admin@finearts.com` | `admin12345678` |

> **Tip:** Log in with different roles to see how the same platform changes according to the user's responsibilities.

# 🧭 How the Platform Works

### 🎨 Student Journey

```text
Login
  ↓
Student Dashboard
  ↓
Explore Competitions
  ↓
Choose an Ongoing Competition
  ↓
Submit Painting
  ↓
Staff Reviews Submission
  ↓
Creativity Level / Grade + Remarks
  ↓
Student Views Evaluation
```

Students can view competitions, submit artwork, add a name, description and poem/quotation/creative text, select a competition, view submissions and details, see evaluations, grades, remarks, and awards where available.

### 👨‍🎨 Staff / Teacher Journey

```text
Staff Login
  ↓
Staff Dashboard
  ↓
Manage Competitions
  ↓
View Student Submissions
  ↓
Open Painting
  ↓
Evaluate Creativity
  ↓
Assign Grade
  ↓
Add Remarks
  ↓
Save / Update Evaluation
```

Staff can create, update and delete competitions where permitted, view student submissions, review artwork and accompanying creative text, assign creativity levels/grades, add remarks, update evaluations, and manage awards and relevant institute activities.

### 🧑‍💼 Manager Experience

The Manager has a **monitoring-oriented role** rather than the same editing authority as Admin or Staff. The Manager can view students, staff, competitions, awards, painting submissions, staff marks/remarks, and other relevant institute information.

### 👑 Admin Experience

The Admin acts as the central management authority. Admin can manage users, students and staff, update or delete users where appropriate, view submissions, monitor staff activities and system activity, manage institute data, and oversee the platform.

### Staff Activity

Relevant staff activities can be displayed to the Admin through the Admin Dashboard, helping the Admin monitor activity across the institute.

# 🏆 Competition Management

Competitions are one of the core workflows of the platform. A competition can contain a title, description, start date, end date, status, banner/image, and award information where applicable.

```text
Upcoming
   ↓
Ongoing
   ↓
Completed / Past
```

Students use the competition area to discover opportunities and submit artwork for available competitions.

# 🖼️ Painting Submission & Evaluation

Students can submit artwork together with supporting creative information:

- Painting image
- Painting name
- Description
- Poem / quotation / creative text
- Competition
- Submission date
- Evaluation
- Creativity level / grade
- Staff remarks

```text
Student Submission
       ↓
Competition Association
       ↓
Staff Review
       ↓
Creativity Evaluation
       ↓
Grade / Level
       ↓
Remarks
       ↓
Student Views Result
```

The original project requirements describe staff evaluation in terms such as **Best, Better, Good, Moderate, Normal**, or **Disqualified**, together with remarks about positive points, negative points, and areas for improvement.

# 🥇 Awards

The platform also supports awards. Awards can be created and managed, associated with students, connected with completed competitions, and displayed as part of student achievements.

# 📸 Screenshots

> Add your actual screenshots to the `screenshots/` folder using the filenames below. These are placeholders and do not assume the images already exist.

## 🏠 Home Page
<!-- Add Home Page screenshot here -->
![Home Page](screenshots/home.png)

## 🔑 Login Page
<!-- Add Login Page screenshot here -->
![Login Page](screenshots/login.png)

## 🎨 Student Dashboard
<!-- Add Student Dashboard screenshot here -->
![Student Dashboard](screenshots/student-dashboard.png)

## 👨‍🎨 Staff / Teacher Dashboard
<!-- Add Staff Dashboard screenshot here -->
![Staff Dashboard](screenshots/staff-dashboard.png)

## 🧑‍💼 Manager Dashboard
<!-- Add Manager Dashboard screenshot here -->
![Manager Dashboard](screenshots/manager-dashboard.png)

## 👑 Admin Dashboard
<!-- Add Admin Dashboard screenshot here -->
![Admin Dashboard](screenshots/admin-dashboard.png)

## 🏆 Competitions
<!-- Add Competitions screenshot here -->
![Competitions](screenshots/competitions.png)

## 🖌️ Painting Submission
<!-- Add Painting Submission screenshot here -->
![Painting Submission](screenshots/painting-submission.png)

## 🔎 Painting Details / Evaluation
<!-- Add Painting Details screenshot here -->
![Painting Details](screenshots/painting-details.png)

## 🖼️ Student Paintings / Gallery
<!-- Add Student Paintings screenshot here -->
![Student Paintings](screenshots/student-paintings.png)

## 🥇 Awards
<!-- Add Awards screenshot here -->
![Awards](screenshots/awards.png)

## 📋 Staff Activity
<!-- Add Staff Activity screenshot here -->
![Staff Activity](screenshots/staff-activity.png)

# 🚀 How to Explore the Platform

1. Start the application.
2. Open the login page.
3. Sign in using one of the demo accounts above.
4. Explore the corresponding dashboard.
5. Follow that role's workflow.
6. Log out.
7. Sign in with another role.
8. Compare the available information and actions.

### Recommended Exploration

```text
Admin
  ↓
Staff / Teacher
  ↓
Student
  ↓
Manager
```

# 🛠️ Technology Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC |
| Language | C# |
| ORM | Entity Framework Core |
| Database | SQL Server |
| Authentication | ASP.NET Core Identity |
| Authorization | Role-Based Authorization |
| UI | Razor Views |
| Frontend | HTML, CSS, JavaScript |
| UI Framework | Bootstrap |
| Icons | Font Awesome |
| File Handling | File I/O |

The interface is database-driven, with dynamic content displayed through Razor views. Artwork and competition images are handled through file uploads.

# 🏗️ Project Structure

```text
Institute-Of-Fine-Arts/
├── Controllers/
├── Models/
├── Views/
├── Data/
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── Uploads/
└── appsettings.json
```

The application follows the **ASP.NET Core MVC** pattern, with Entity Framework Core handling database access and ASP.NET Core Identity providing authentication and role-based access.

# 💡 Why This Project?

The original institute workflow relied heavily on manual records, making it difficult and time-consuming to retrieve competition and student-submission information.

The proposed digital system brings competitions, paintings, evaluations, awards, and user responsibilities into one platform.

Building the project also involved real application concerns such as role-based workflows, Identity authentication, database relationships, dynamic Razor views, file uploads, competition management, painting evaluation, dashboards, runtime debugging, and UI consistency.

# 👨‍💻 Developer

**Abdul Haseeb**

`C#` • `ASP.NET Core` • `Entity Framework Core` • `SQL Server` • `HTML` • `CSS` • `JavaScript`

> Built to bring the creative workflow of an institute into one beautiful, role-based platform.
