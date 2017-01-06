# WSP_OSTT
Windows Surface Pro - On screen touch toggle app

Desctiption:
This is a simple on screen touch toggle app for windows surface pro.
Its written in Visual basic and commandline script
Functionality is dead simple. 3 buttons:
AOT Toggle wich toggles the programs always on top functionality,
Touch toggle wich turns on and off touch,
and Exit wich simply exits the program.

Use scenario:
Say youre a digital artist of some kind and for some reason youre
using a surface pro to draw of digital sculpt on. While you work
you might feel a need to activate and deactivate the touch functionality
of the screen quite often. As far as I know Microsoft has no program capable
of doing this at this date. So instead of finding some third party software
to do the job I decided to make a app dedicated for doing only this.

Dependancies
DevCon.exe part of WDK (Windows Driver Kit)
Link: https://developer.microsoft.com/en-us/windows/hardware/windows-driver-kit

General usage:
App has to run with Admin privilages as it works by deactivating the touch
screen hardware through WDK's DevCon.exe wich needs admin access to run.

License: GPLv2.0
