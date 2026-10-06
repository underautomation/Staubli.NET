## Files of the controller

New file client `controller.File`, and standalone `FileClient`: list, upload, download, create, rename and delete the files and folders of the controller. Each method has a synchronous and an asynchronous version (`...Async`, with a `CancellationToken`, not on .NET Framework 3.5 and 4.0). Errors throw a `FileException`.

- Real controller: the client uses the FTP server of the controller. Set `parameters.File.Enable = true`, and the FTP user and password (`default` and `default` by default, port 21).
- Controller emulated by Staubli Robotics Suite: the emulator has no FTP server. Give the path of the `.controller` file of the emulated controller as address: the client reads and writes the files in the folder of this file, which has the same tree as the FTP server of a real controller. The paths are the same.

```csharp
var parameters = new ConnectionParameters("192.168.0.254"); // or @"C:\...\MyCell\Controller1\Controller1.controller"
parameters.File.Enable = true;
parameters.File.User = "default";
parameters.File.Password = "default";

var controller = new StaubliController();
controller.Connect(parameters);

foreach (FileItem item in controller.File.GetListing("/usr/usrapp"))
    Console.WriteLine($"{item.FullName} {item.Type} {item.Size}");

controller.File.UploadFileToController(@"C:\Data\points.dat", "/usr/usrapp/myApp/points.dat");
byte[] content = controller.File.DownloadBytesFromController("/usr/usrapp/myApp/myApp.pjx");
```

The `File.Enable` parameter is `false` by default: the connection of existing programs does not change.

## Send a VAL 3 application

`UploadApplicationToController(localAppFolder)` copies the folder of a VAL 3 application, with its sub-folders, to `/usr/usrapp/<application>` on the controller. When the application exists on the controller, its folder is replaced. The VAL 3 applications are in `/usr/usrapp` (`FileClientBase.USER_APP_FOLDER`), and `/usr/usrapp/myApp/myApp.pjx` is the project `Disk://myApp/myApp.pjx` of the SOAP methods.

```csharp
controller.Soap.StopAndUnloadAll();
controller.File.UploadApplicationToController(@"C:\MyApps\myApp");
controller.Soap.LoadProject("Disk://myApp/myApp.pjx");
```

## Connection to the emulator of Staubli Robotics Suite

- The address can be the path of the `.controller` file of a controller emulated by Staubli Robotics Suite. The SDK connects to this computer, or to the computer of a UNC path. A path that is not a `.controller` file throws an `ArgumentException`.
- The default SOAP port is now `0` (automatic). On a real controller, the SDK uses 851, as before. On an emulated controller, it reads the SOAP port in the network configuration of the emulated controller (`usr\configs\network.cfx`), and uses 851 when it is not found. When 851 was used as a fallback and the connection fails, the message of the exception says it.
- `SoapClient.Connect` accepts the same addresses and the port 0.

```csharp
var controller = new StaubliController();
controller.Connect(@"C:\Users\me\Documents\Staubli\SRS\MyCell\Controller1\Controller1.controller");
Console.WriteLine(controller.Soap.Port); // port of the emulated controller
```
