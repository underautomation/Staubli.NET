# Staubli Communication SDK

[![UnderAutomation Staubli communication SDK](https://raw.githubusercontent.com/underautomation/Staubli.NET/refs/heads/main/.github/assets/banner.png)](https://underautomation.com)

[![NuGet](https://img.shields.io/nuget/dt/UnderAutomation.Staubli?label=NuGet%20Downloads&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.Staubli/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-3.5+-blueviolet)](#)
[![.NET Standard](https://img.shields.io/badge/.NET_Standard-2.0+-blueviolet)](#)
[![.NET Core](https://img.shields.io/badge/.NET_Core-2.0+-blueviolet)](#)
[![.NET Versions](https://img.shields.io/badge/.NET-5_6_8_9-blueviolet)](#)

### 🤖 Effortlessly Communicate with Staubli Robots

The **Staubli Communication SDK** provides high-level access to industrial Staubli robots via the native SOAP protocol. Designed for automation engineers, researchers, and integrators, this SDK supports full motion control, I/O access, system monitoring, and application management.

🔗 **More Information:** [Documentation](https://underautomation.com/Staubli/documentation)  
🔗 Available also for **[🟨 LabVIEW](https://github.com/underautomation/Staubli.vi)** & **[🐍 Python](https://github.com/underautomation/Staubli.py)**

---

## 🚀 TL;DR

✅ Seamlessly connect to Staubli controllers using native SOAP.  
✅ Control movements, read/write I/Os, monitor status, and manage applications.  
✅ No additional licenses or Staubli software needed.

**Highlights:**

- ⚡ Real-time SOAP communication
- 🛠️ Works with .NET Framework, Core, Standard
- 🔁 Full motion lifecycle & kinematics
- 📡 Access to physical & logical I/Os
- 📦 Project & task management (VAL 3)

---

## 📥 Download Example Applications

Explore precompiled examples from the [GitHub Releases](https://github.com/underautomation/Staubli.NET/releases)

### ✅ Windows Forms Showcase

🔹 **Download:** [📥 UnderAutomation.Staubli.Showcase.Forms.exe](https://github.com/underautomation/Staubli.NET/releases/latest/download/UnderAutomation.Staubli.Showcase.Forms.exe)

---

## ✨ Features

### 🔌 Connection

```csharp
var controller = new StaubliController();
var parameters = new ConnectionParameters("192.168.0.1");

parameters.Soap.Enable = true;
parameters.Soap.User = "default";
parameters.Soap.Password = "default";

controller.Connect(parameters);
```

---

### 🔍 System Information

- Get robots connected (`GetRobots()`)
- Get controller parameters (`GetControllerParameters()`)
- Retrieve DH parameters (`GetDhParameters()`)

```csharp
Robot[] robots = controller.Soap.GetRobots();
Parameter[] controllerParams = controller.Soap.GetControllerParameters();
DhParameters[] dh = controller.Soap.GetDhParameters(robot: 0);
```

---

### 📍 Position & Joints

- `GetCurrentJointPosition()`
- `GetCurrentCartesianJointPosition()`

```csharp
CartesianJointPosition pos = controller.Soap.GetCurrentCartesianJointPosition(robot: 0);
double[] joints = pos.JointsPosition;
```

---

### 🧠 Kinematics

- Forward Kinematics: `ForwardKinematics()`
- Inverse Kinematics: `ReverseKinematics()`

```csharp
IForwardKinematics fk = controller.Soap.ForwardKinematics(0, joints);
IReverseKinematics ik = controller.Soap.ReverseKinematics(0, joints, fk.Position, fk.Config, range);
```

---

### ⚙️ Motion Control

- Power: `SetPower(true/false)`
- Motion types: `MoveL`, `MoveJC`, `MoveJJ`, `MoveC`
- Motion lifecycle: `StopMotion`, `ResetMotion`, `RestartMotion`

```csharp
controller.Soap.SetPower(true);
controller.Soap.MoveL(0, targetFrame, motionDesc);
```

---

### 📡 I/O Management

- List physical I/Os: `GetAllPhysicalIos()`
- Read: `ReadIos(...)`
- Write: `WriteIos(...)`

```csharp
PhysicalIo[] ios = controller.Soap.GetAllPhysicalIos();
PhysicalIoWriteResponse[] res = controller.Soap.WriteIos(new[] { "out1" }, new[] { 1.0 });
```

---

### 📦 Application Management

- Load project: `LoadProject("Disk://myProject.pjx")`
- List applications: `GetValApplications()`
- Stop/unload apps: `StopApplication()`, `StopAndUnloadAll()`

```csharp
controller.Soap.LoadProject("Disk://project.pjx");
ValApplication[] apps = controller.Soap.GetValApplications();
controller.Soap.StopAndUnloadAll();
```

---

### 🔁 Task Lifecycle

- List tasks: `GetTasks()`
- Control: `TaskKill`, `TaskSuspend`, `TaskResume`

```csharp
ControllerTask[] tasks = controller.Soap.GetTasks();
controller.Soap.TaskKill(tasks[0].Name, tasks[0].CreatedBy);
```

---

## ✅ Compatibility

- **Controllers:** CS8, CS9
- **OS:** Windows, Linux, macOS
- **.NET Versions:** Framework 3.5+, .NET Core 2.0+, .NET 5/6/8/9

---

## 📜 License

**⚠️ Commercial license required**
🔗 [View EULA](https://underautomation.com/Staubli/eula)

---

## 🤝 Contributing

You're welcome to:

- Submit issues & PRs
- Share feature suggestions
- Help improve documentation

👉 [Contribute on GitHub](https://github.com/underautomation/Staubli.NET)

---

## 📬 Need Help?

- 📚 [Documentation](https://underautomation.com/Staubli/documentation)
- 📩 [Contact Support](https://underautomation.com/contact)

---

[⭐ Star the repo if useful](https://github.com/underautomation/Staubli.NET/stargazers)
[👁️ Watch for updates](https://github.com/underautomation/Staubli.NET/watchers)
