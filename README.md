# Aura Operating System
## [Official Website (aura-team.com)](http://aura-team.com)
## Join us on [Slack](https://join.slack.com/t/aura-systems/shared_invite/enQtMjQ2ODgyMjgwNTY2LTFmYWY1ZDljNGNjZjRjODUyZWI2ODY0ZmMxNzljMmJjODI4YjRiZGIzN2JhNjAyNzdhOTI0MTgwNjhjNzQ4ZTM)!
A Cosmos based Operating System developped in C# made by Alexy DA CRUZ (GeomTech) and Valentin Charbonnier (valentinbreiz).

## Current features
Please read the [Aura Progression](https://github.com/aura-systems/Aura-Operating-System/projects/4) or our [Roadmap](https://github.com/aura-systems/Aura-Operating-System/projects/3) to know what will be added soon.

* PS2 Keyboard
* ATA IDE / AHCI Driver
* PCI Device Scan
* Restart + ACPI Shutdown.
* Basic command interpreter.
* FAT32 + Virtual FileSystem.
* Multilanguage support.
* Exception with screen of death.
* Extended ASCII support.
* Multi users (with MD5 encryption for passwords)
* Text Editor (Liquid Editor).
* Get RAM, get time.

## Screenshots

Login:

![Aura Operating System](https://image.noelshack.com/fichiers/2017/43/2/1508857711-aura1.png)

Shell:

![Aura Operating System](https://image.noelshack.com/fichiers/2017/47/5/1511551694-1.png)

![Aura Operating System](https://image.noelshack.com/fichiers/2017/47/5/1511551696-2.png)

![Aura Operating System](https://image.noelshack.com/fichiers/2017/47/5/1511551820-3.png)

## Want to try Aura?
Download VMWare [at this address](https://my.vmware.com/en/web/vmware/free#desktop_end_user_computing/vmware_workstation_player/12_0). Install and run it.

Now click on "Create a new virtual machine", select the iso file downloaded on [this page](https://github.com/aura-systems/Aura-Operating-System/releases) and click the "Next" button.

Now click on "Other" for "Guest operating system" and "Other" for version, click "Next" again, select "Store virtual disk as a single file" and select "Finish". 

The Virtual File System won't work so go to "C:\Users\username\Documents\Virtual Machines\Other" and replace the "Other.vmdk" by [this file](https://github.com/CosmosOS/Cosmos/raw/master/Build/VMWare/Workstation/Filesystem.vmdk).

Now you can select Aura (Other) and click on "Play Virtual Machine".

## How to compile Aura sources ?
First, clone [our modified version of Cosmos](https://github.com/aura-systems/Cosmos), run the "install-VS2017.bat" file and wait until the installation is done. 

Now clone [this repository](https://github.com/aura-systems/Aura-Operating-System) then inside the folder Aura OS, run Aura OS.sln and select "build" once Visual Studio 2017 has loaded.

If you have an error like "A project with an Output type of Class Library cannot be started directly", right click on "Aura_OSBoot" and select "Set as startup project", now click again on "build"!
