# TableauSDKWrapper For CSharp
Tableau SDK Wrapper classes for CSharp developers.<br>
This is only a sample of wrapper classes so feel free to clone & modify for your application with your own risk.

## Requirements
To use wrapper classes, please download Tableau SDK for Windows;<br>
https://onlinehelp.tableau.com/current/api/sdk/en-us/help.htm <br>
(To use Hyper Beta, visit Beta Program https://www.tableau.com/products/coming-soon)

## Namespace and Class
- TableauSDKWrapper.Extract: Extract APIs
- TableauSDKWrapper.Hyper: Hyper Extract APIs (Beta2)
- TableauSDKWrapper: Server APIs, Exception and utilities

## Samples
Please build TableauSDKWrapper and samples, locate Tableau SDK to PATH location or local bin folder to execute.
- Sample: Sample with Extract API and Server API<br>
  Creates .tde file and upload to Tableau Server.
- HyperSample: Sample with Hyper Extract API<br>
  Creates .hyper file.<br>

## Notes
This wrapper is developed with following environments and only tested on 64 bit environment.
- SDKWrapper Extract, Server, Exception, and Utils: .NET Standard 1.4, Tableau SDK 64bit 10.3.6
- SDKWrapper Hyper: .NET Standard 1.4, Tableau SDK 64bit 10.5 Beta2
- Sample: .NET Framework 4.5.2
- HyperSample: .NET Framework 4.5.2

