# Staubli Communication SDK

[![UnderAutomation Staubli communication SDK](https://raw.githubusercontent.com/underautomation/Staubli.NET/refs/heads/main/.github/assets/banner.png)](https://underautomation.com)

[![NuGet](https://img.shields.io/nuget/dt/UnderAutomation.Staubli?label=NuGet%20Downloads&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.Staubli/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-3.5+-blueviolet)](#)
[![.NET Standard](https://img.shields.io/badge/.NET_Standard-2.0+-blueviolet)](#)
[![.NET Core](https://img.shields.io/badge/.NET_Core-2.0+-blueviolet)](#)
[![.NET Versions](https://img.shields.io/badge/.NET-5_6_8_9-blueviolet)](#)

### 🤖 Effortlessly Communicate with Staubli robots

The **Staubli SDK** enables seamless integration with Staubli robots for automation, data exchange, and remote control. Ideal for industrial automation, research, and advanced robotics applications.

🔗 **More Information:** [https://underautomation.com/Staubli](https://underautomation.com/Staubli)  
🔗 Also available for **[🟨 LabVIEW](https://github.com/underautomation/Staubli.vi)** & **[🐍 Python](https://github.com/underautomation/Staubli.py)**

---

[⭐ Star if you like it !](https://github.com/underautomation/Staubli.NET/stargazers)

[👁️ Watch to be notified of latest updates !](https://github.com/underautomation/Staubli.NET/watchers)

---

## 🚀 TL;DR (Too Long; Didn’t Read)

A powerful and efficient .NET library for communicating with Staubli industrial robots using the SOAP native protocol. Enables seamless connectivity, motion control, and data acquisition.

✅ No additional installations or Staubli options are required to use this SDK.

**Key Benefits:**

- 📡 **Fast & Reliable**: Leverage high-speed SOAP communication for real-time control.
- 🛠️ **Easy Integration**: Works with .NET projects, compatible with VB.NET and C#.
- 🤖 **Advanced Features**: Supports status monitoring, alarm handling, job selection, and more.
- 🌎 **Cross-Platform**: Works with Windows/Linux using .NET Core.

---

## 📥 Download Example Applications

Explore the **Staubli SDK** with fully functional example applications and precompiled binaries for various platforms. [See Github releases](https://github.com/underautomation/Staubli.NET/releases)

### 🔹 Windows Forms Application (Full Feature Showcase)

A Windows Forms application demonstrating all the features of the library.

📌 **Download:** [📥 UnderAutomation.Staubli.Showcase.Forms.exe](https://github.com/underautomation/Staubli.NET/releases/latest/download/UnderAutomation.Staubli.Showcase.Forms.exe)

---

## Features ✨

### Connect to the Robot

```csharp
// Connect to the robot
var robot = new StaubliRobot();
robot.Connect("192.168.0.1");

// Ensure robot is connected
bool isConnected = robot.HighSpeedEServer.Connected;
```

## 🔍 Compatibility

✅ **Supported Robots:** CS8, CS9
✅ **Operating Systems:** Windows, Linux, macOS  
✅ **.NET Versions:** .NET Framework (≥3.5), .NET Standard, .NET Core, .NET 5/6/8/9

---

## 📢 Contributing

We welcome contributions! Feel free to:

- Report issues via [GitHub Issues](https://github.com/underautomation/Staubli.NET/issues)
- Submit pull requests with improvements
- Share feedback & feature requests

---

## 📜 License

**⚠️ This SDK requires a commercial license.**  
🔗 Learn more: [UnderAutomation Licensing](https://underautomation.com/Staubli/eula)

---

## 📬 Need Help?

If you have any questions or need support:

- 📖 **Check the Docs**: [Documentation](https://underautomation.com/Staubli/documentation)
- 📩 **Contact Us**: [Support](https://underautomation.com/contact)
