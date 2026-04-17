# 📊 Customize Blazor Pivot Table Appearance with Templates & Conditional Formatting

[![License](https://img.shields.io/badge/license-SEE%20LICENSE-blue.svg)](https://www.syncfusion.com/content/downloads/syncfusion_license.pdf)
[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-512BD4.svg)](https://dotnet.microsoft.com/)
[![Blazor WebAssembly](https://img.shields.io/badge/Blazor-WebAssembly-blueviolet.svg)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![Syncfusion](https://img.shields.io/badge/Syncfusion-Blazor%20UI-green.svg)](https://www.syncfusion.com/blazor-components)

> **Master professional Pivot Table customization** with Syncfusion Blazor components. Learn how to apply cell templates, conditional formatting rules, and programmatic styling for enterprise-grade business intelligence dashboards.

---

## 📋 Table of Contents

- [🎯 Quick Overview](#-quick-overview)
- [✨ Key Features](#-key-features)
- [🛠 Technology Stack](#-technology-stack)
- [📋 Prerequisites](#-prerequisites)
- [🚀 Quick Start Guide](#-quick-start-guide)
- [🗂 Project Structure](#-project-structure)
- [💡 Core Concepts](#-core-concepts)
- [🎨 Usage Examples](#-usage-examples)
- [⚙️ Configuration & Customization](#-configuration--customization)
- [❓ FAQ & Troubleshooting](#-faq--troubleshooting)
- [📖 Resources](#-resources)
- [🤝 Contributing](#-contributing)
- [📄 License](#-license)

---

## 🎯 Quick Overview

This repository provides a **production-ready reference implementation** for building customizable Syncfusion Pivot Tables in **Blazor WebAssembly applications**. It demonstrates best practices for:

- **Cell Template Customization** — Apply custom HTML, icons, colors, and interactive elements
- **Conditional Formatting** — Dynamically style cells based on data values
- **Programmatic Styling** — Leverage C# logic for complex formatting rules
- **Performance Optimization** — Client-side rendering with WebAssembly efficiency
- **Enterprise Reporting** — Build professional dashboards for BI and analytics

### Real-World Use Cases

- 📊 Energy sector analytics and reporting dashboards
- 💼 Business intelligence and KPI dashboards
- 📈 Financial analysis and risk reporting
- 🏢 Enterprise data visualization
- 🎓 Educational and training applications

---

## ✨ Key Features

| Feature | Description | Benefits |
|---------|-------------|----------|
| 🎨 **Cell Templates** | Custom HTML rendering in pivot table cells | Create rich, interactive data visualizations |
| 📊 **Conditional Formatting** | Dynamic color rules and styling based on values | Instantly highlight trends and anomalies |
| 💻 **C# Integration** | Server-side logic for complex formatting | Business rule engine for sophisticated analytics |
| ⚡ **WebAssembly** | Client-side rendering with optimal performance | Smooth interactions and reduced server load |
| 🔧 **Syncfusion Components** | Enterprise-grade UI controls | Professional appearance and consistent UX |
| 📦 **Production-Ready** | Best practices and clean architecture | Deploy with confidence to production |
| 🎯 **Multi-Dimensional Analysis** | Rows, columns, values, and filter configuration | Flexible data exploration and pivoting |
| 🌐 **Cross-Browser Support** | Works on all modern browsers | Universal compatibility and accessibility |

---

## 🛠 Technology Stack

| Component | Version | Purpose |
|-----------|---------|---------|
| **.NET** | 8.0+ | Runtime framework |
| **Blazor WebAssembly** | 8.0 | Client-side framework |
| **Syncfusion Blazor** | Latest | UI component library |
| **C# 12** | Latest | Programming language |
| **Razor Components** | 8.0 | UI markup language |

---

## 📋 Prerequisites

Ensure the following are installed on your development machine:

- **Visual Studio 2022** (17.0+) or **Visual Studio Code** with C# support
- **.NET 8.0 SDK** or later ([Download](https://dotnet.microsoft.com/download/dotnet/8.0))
- **Modern Web Browser** (Chrome, Firefox, Edge, Safari) with WebAssembly support
- **Git** (optional, for version control)

### System Requirements

- ✅ Windows 10/11, macOS 10.15+, or Ubuntu 18.04+
- ✅ 4GB RAM minimum (8GB recommended)
- ✅ 500MB free disk space
- ✅ Internet connection for NuGet package restoration

---

## 🚀 Quick Start Guide

### 1️⃣ Clone or Download the Repository

```bash
git clone https://github.com/SyncfusionExamples/Customize-the-appearance-of-a-Blazor-Pivot-Table-Using-Templates-and-Conditional-Formatting
cd Customize-the-appearance-of-a-Blazor-Pivot-Table-Using-Templates-and-Conditional-Formatting
```

### 2️⃣ Open in Visual Studio 2022

1. Launch Visual Studio 2022
2. Select **File → Open → Project/Solution**
3. Navigate to `ConditionalFormatSample.sln`
4. Wait for NuGet package restoration

### 3️⃣ Build the Solution

Using Visual Studio:
- Press `Ctrl+Shift+B` or select **Build → Build Solution**

Using CLI:
```bash
dotnet build
```

### 4️⃣ Run the Application

Using Visual Studio:
- Press `F5` or click **Debug → Start Debugging**

Using CLI:
```bash
dotnet run --project ConditionalFormatSample
```

### 5️⃣ Access the Application

Open your browser and navigate to:
```
https://localhost:7XXX
```

The pivot table will load with:
- Energy sector data visualization
- Conditional formatting applied to power units and revenue
- Interactive cell templates with custom styling

---

## 🗂 Project Structure

```
ConditionalFormatSample/
├── ConditionalFormatSample.sln           # Solution file
├── README.md                              # Documentation
│
├── ConditionalFormatSample/               # Server project
│   ├── Program.cs                         # Application startup
│   ├── appsettings.json                   # Configuration
│   ├── Components/
│   │   ├── App.razor                      # Root component
│   │   ├── Routes.razor                   # Routing configuration
│   │   └── Layout/
│   │       └── MainLayout.razor           # Master layout
│   └── wwwroot/
│       └── bootstrap/                     # CSS frameworks
│
└── ConditionalFormatSample.Client/        # WebAssembly client
    ├── Program.cs                         # Client startup
    ├── _Imports.razor                     # Global imports
    ├── Data/
    │   └── EnergyDetails.cs               # Data model & sample data
    └── Pages/
        └── Counter.razor                  # Sample component
```

### Key Files

- **`EnergyDetails.cs`** — Data model containing energy sector metrics
- **`Program.cs`** — Blazor WebAssembly initialization and Syncfusion service registration
- **`App.razor`** — Root Blazor component with routing configuration

---

## 💡 Core Concepts

### Cell Templates

Cell templates allow you to render custom HTML in pivot table cells:

```csharp
<CellTemplate>
    @{
        var data = context as EnergyDetails;
        if (data != null)
        {
            <div style="background-color: #f0f0f0; padding: 5px;">
                <strong>@data.Revenue</strong>
            </div>
        }
    }
</CellTemplate>
```

### Conditional Formatting Rules

Apply dynamic formatting based on data values:

```csharp
<ConditionalFormatSettings>
    <ConditionalFormatRules>
        <ConditionalFormatRule 
            Measure="Revenue" 
            Condition="GreaterThan" 
            Value1="100" 
            Style="HighValue" />
    </ConditionalFormatRules>
</ConditionalFormatSettings>
```

### Programmatic Styling

Use C# logic to dynamically apply formatting:

```csharp
private string GetCellStyle(double value)
{
    if (value > 150) return "background-color: green; color: white;";
    if (value > 100) return "background-color: yellow; color: black;";
    return "background-color: red; color: white;";
}
```

---

## 🎨 Usage Examples

### Example 1: Basic Pivot Table with Templates

```razor
@using Syncfusion.Blazor.PivotView
@using ConditionalFormatSample

<SfPivotView TValue="EnergyDetails" 
             Height="600px"
             Width="100%">
    <PivotViewDataSourceSettings TValue="EnergyDetails"
                                 ExpandAll="false">
        <PivotViewRows>
            <PivotViewRow Name="Sector"></PivotViewRow>
        </PivotViewRows>
        <PivotViewColumns>
            <PivotViewColumn Name="EnergyType"></PivotViewColumn>
        </PivotViewColumns>
        <PivotViewValues>
            <PivotViewValue Name="PowerUnits" Type="SummaryTypes.Sum"></PivotViewValue>
            <PivotViewValue Name="Revenue" Type="SummaryTypes.Sum"></PivotViewValue>
        </PivotViewValues>
    </PivotViewDataSourceSettings>
</SfPivotView>
```

### Example 2: Adding Conditional Formatting

```razor
<SfPivotView TValue="EnergyDetails" Height="600px">
    <!-- Data source configuration -->
    
    <ConditionalFormatSettings>
        <ConditionalFormatRules>
            <ConditionalFormatRule 
                Measure="Revenue" 
                Condition="GreaterThan" 
                Value1="150" 
                BackgroundColor="#00FF00" 
                FontColor="#000000" />
            <ConditionalFormatRule 
                Measure="Revenue" 
                Condition="LessThan" 
                Value1="50" 
                BackgroundColor="#FF0000" 
                FontColor="#FFFFFF" />
        </ConditionalFormatRules>
    </ConditionalFormatSettings>
</SfPivotView>
```

---

## ⚙️ Configuration & Customization

### Enabling Syncfusion License

Register Syncfusion license in `Program.cs`:

```csharp
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR_LICENSE_KEY");
```

### Adding Custom Data Source

Replace sample data by modifying `EnergyDetails.cs`:

```csharp
public static List<EnergyDetails> GetCustomData()
{
    return new List<EnergyDetails>
    {
        new EnergyDetails 
        { 
            Sector = "Custom Sector",
            PowerUnits = 100,
            Revenue = 150
        }
    };
}
```

### Customizing Styles

Define custom CSS for formatting:

```css
.high-value {
    background-color: #2ecc71;
    color: white;
    font-weight: bold;
}

.low-value {
    background-color: #e74c3c;
    color: white;
}
```

---

## ❓ FAQ & Troubleshooting

**Q: Why is the pivot table not displaying?**  
A: Ensure Syncfusion services are registered in `Program.cs`:
```csharp
builder.Services.AddSyncfusionBlazor();
```

**Q: How do I apply formatting to specific cells?**  
A: Use `ConditionalFormatRules` with appropriate `Measure`, `Condition`, and styling properties.

**Q: Can I use external data sources?**  
A: Yes, replace the `EnergyDetails` model with your own data model and populate from databases or APIs.

**Q: What's the performance impact of templates?**  
A: WebAssembly rendering is performant. For large datasets (10,000+ rows), consider virtual scrolling.

---

## 📖 Resources

- 🔗 **Syncfusion Blazor Pivot Table Docs**: https://blazor.syncfusion.com/documentation/pivot-table/
- 🔗 **Official Demo**: https://blazor.syncfusion.com/demos/pivot-table/overview

---

## 🤝 Contributing

Contributions are welcome! To contribute:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/my-feature`)
3. Commit your changes (`git commit -am 'Add new feature'`)
4. Push to the branch (`git push origin feature/my-feature`)
5. Open a Pull Request

---

## 📄 License

This project is licensed under the **Syncfusion Community License**. See [Syncfusion License](https://www.syncfusion.com/content/downloads/syncfusion_license.pdf) for details.

---

## 🆘 Support

For assistance and inquiries:

- 📧 **Syncfusion Support**: https://www.syncfusion.com/support
- 💬 **Community Forum**: https://www.syncfusion.com/forums
- 🐛 **Report Issues**: https://github.com/SyncfusionExamples/customize-blazor-pivot-table/issues

---
