# 🧾 MiniContaBill

## 📖 About the Project

**MiniContaBill** is a desktop accounting and economic analysis application developed in **C#**, using **.NET Framework 4.8** and **Windows Forms**.


The application combines several economic and accounting tools in a single desktop application, including company configuration, depreciation calculations, cost and profit analysis, demand and supply analysis, employee management, salary calculations and dividend calculations.

The project also includes reusable DLLs, unit tests, design patterns, charts, JSON persistence and extensive software documentation.

---

## 🎯 Main Features

### 🏢 Company Configuration

The application allows the user to create and configure a company.

Three company types are supported:

- **SRL**
- **PFA**
- **SA**

The user can configure information such as:

- company name;
- turnover;
- fixed capital;
- working capital;
- number of shares;
- share value;
- debts.
---

## 📊 Dashboard

After configuring the company, the application provides a central dashboard from which the user can access the main modules:

- 💰 Capital
- 📈 Cost & Profit
- ⚖️ Demand & Supply
- 👥 Employees & Salaries

The dashboard also displays the currently selected company and allows navigation between the different modules.

---

# 💰 Capital & Depreciation

The Capital module provides calculations for the depreciation of company assets.

The user can enter:

- initial asset value;
- useful lifetime;
- residual value.

Three depreciation methods are implemented:

### 📏 Straight-Line Depreciation

Calculates an equal depreciation amount for each year.

### 📈 Progressive Depreciation

The depreciation amount increases from one year to another.

### 📉 Declining-Balance Depreciation

The depreciation amount decreases over time based on the remaining value of the asset.

The results are displayed in the application and can also be represented graphically.

The depreciation logic is implemented separately in the `Amortizari` project.

---

# 📈 Cost & Profit

The Cost & Profit module contains several economic calculations.

The user can calculate:

- 💰 Profit amount
- 📊 Profit rate
- 🏭 Total production cost
- 📦 Average production cost
- 💵 Final price
- 🧾 VAT
- 🏦 Profit tax
- 🎯 Break-even point

# ⚖️ Demand & Supply

The Demand & Supply module provides examples for different types of economic elasticity.

The project contains strategies for:

📉 Demand
 - elastic demand;
 - inelastic demand;
 - rigid demand;
 - unit elastic demand.
📈 Supply
 - elastic supply;
 - inelastic supply;
 - unit elastic supply;
 - other implemented supply examples.

 # 👥 Employees & Salaries

 The Employees & Salaries module allows the company to manage its employees.

 For each employee, the application stores:

 - ID;
 - name;
 - position;
 - gross salary;
 - department.
📝 Employee Management

The application supports:

➕ Adding employees
✏️ Updating employees
🗑️ Deleting employees
📋 Displaying employees in a table

Validation is performed when adding or updating employees, including checks for:

 - valid IDs;
 - valid salaries;
 - duplicate IDs;
 - duplicate employee names.
 - 
💰 Salary Calculations

The application can calculate:

 - average gross salary;
 - total gross salaries;
 - net salary;
 - total employer cost.

 💵 Dividends

The project also contains a separate Dividente component.

It provides calculations related to:

 - total expenses;
 - company profit;
 - dividends;
 - dividend value per share.

This functionality is particularly relevant for companies of type SA, where the application also handles shares.

🎨 Design Patterns

Two main design patterns were implemented in the project.

🏗️ Builder Pattern

The Builder Pattern is used for creating different types of companies.

🔀 Strategy Pattern

The Strategy Pattern is used in the Demand & Supply module.

🧪 Testing

The project contains a dedicated testing project: ##MiniContaBillTests##

The tests use MSTest and focus mainly on testing the reusable business logic independently from the graphical interface.

🛠️ Technologies

The main technologies and libraries used in the project are:

💻 C#
⚙️ .NET Framework 4.8
🎨 ReaLTaiizor
📊 ScottPlot
💾 System.Text.Json
📦 Newtonsoft.Json
🧪 MSTest
📈 Windows Forms Charting

👥 Team Collaboration

The project was developed together with:

Bran Ioana-Andreea
Chiuariu Silviu
Negoita Petru
Zabara Sonia

The final application combines the work of all four team members across the different modules.

# ▶️ Running the Project

## 📋 Prerequisites

Before running **MiniContaBill**, make sure you have:

- 🪟 Windows 10 or Windows 11
- 🧰 Visual Studio 2019 or 2022
- ⚙️ .NET Framework 4.8 Developer Pack
- 📦 NuGet package support

The project uses **Windows Forms** and **.NET Framework 4.8**, so it is intended to run on Windows.

---

## 📥 1. Clone the Repository

Open a terminal and run:

```bash
git clone https://github.com/SilviuChiuariu/ProiectMiniContabil.git
cd ProiectMiniContabil
```


## 🖥️ 2. Open the Project

After cloning the repository, open the solution file:

```text
miniContabil.sln
```

📦 3. Restore NuGet Packages

After opening the solution, restore the required NuGet packages.

From Visual Studio, you can use:

Tools → NuGet Package Manager → Restore NuGet Packages

The project uses packages such as:

ReaLTaiizor
MSTest
.NET Framework libraries
