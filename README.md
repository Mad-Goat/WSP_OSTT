Windows Surface Pro - On-screen touch toggle app
==================
By Mad-Goat.<br>
Version 0.1

*(Only tested on Surface Pro 3)*

Description:
------------------
This is a simple on-screen touch toggle app for windows surface pro.<br>
It's written in Visual basic and command line script<br>
Functionality is dead simple. 3 buttons:<br>
AOT Toggle wich toggles the programs always on top functionality,<br>
Touch toggle wich turns on and off touch,<br>
and Exit wich simply exits the program.<br>

Use scenario:
------------------
Say you're a digital artist of some kind and for some reason, you're<br>
using a surface pro to draw of digital sculpt on. While you work<br>
you might feel a need to activate and deactivate the touch functionality<br>
of the screen quite often. As far as I know Microsoft has no program capable<br>
of doing this at this date. So instead of finding some third party software<br>
to do the job I decided to make an app dedicated to doing only this.<br>

Dependancies:
------------------
DevCon.exe part of WDK (Windows Driver Kit)<br>
Link: https://developer.microsoft.com/en-us/windows/hardware/windows-driver-kit<br>

General usage:
------------------
App has to run with Admin privileges as it works by deactivating the touch<br>
screen hardware through WDK's DevCon.exe wich needs admin access to run.<br>

Limitations:
------------------
This app is only tested on surface pro 3 and its suspected that one would<br>
have to change the pen Device ID the program search for to make it work with<br>
other versions of the surface pro. If anyone wants to use the program on a<br>
different surface pro version feel free to drop an issue in the project, and<br>
I will try to fix it, though I may need a bit of information about said<br>
hardware to fix it.

*License: GPLv2.0*