# USBDeviceList-Windows-CSharp
USBデバイスを複数台抜き差しするとポート番号やらデバイス番号やらが変わるので、「このUSBデバイスを使いたい」というときはIDで指定する。そのIDを調べるツールです。開発環境が無くても、最近のWindowsなら下記Buildの項に従ってコマンドライン入力すると作れるはず(Windows10でしか試していない)。
## Target
Windows10 ( or lower may be )
## Function
List bellow informations
* Device ID
* PNP Device ID
* Description
## Build
with cmd.com
> C:\Windows\Microsoft.NET\Framework\v3.5\csc.exe /platform:anycpu /target:exe USBDeviceList.cs
## Use
with cmd.com
> USBDeviceList.exe
