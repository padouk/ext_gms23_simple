# ext_gms23_simple
Simple Extentension project for Game Maker Studio 2.03

## Requirements
The main commander is Visual Studio 2019
- Expected to build Win32 and Win64 on local
- Expected to build Unbuntu64 on remote, feel free to provision an AWS or AZURE cheapass burstable or a local vm
- Expected to build macosx on remote, feel free to provision a www.macincloud.com bare metal instance. ** you will need the USD$5 monthly package for ssh connection
- Expected to build HTML5 as emscript on local

## Windows (GMS_PLATFORM_WINDOWS)

We build win32 and x64 version. 
By default the x64 version is used and we assume you had the checkbox checked for x64 runtime in GMS.

You will need Visual Studio 2019
Follow setup instruction from GMS

## HTML5 (GMS_PLATFORM_HTML5)
We build using emscriptent 2.0.1
follow those instructions: https://emscripten.org/docs/getting_started/downloads.html
and make sure you have the environment variable EMSCRIPTEN_SDK=C:\Tools\emsdk\upstream\emscripten

## Macosx (GMS_PLATFORM_MACOSX)
Provision a www.macincloud.com
Make sure it is known by visual studio code

## Ubuntu (GMS_PLATFORM_UBUNTU)
Provision a VM
Make sure it is known by visual studio code

## UWP (GMS_PLATFORM_UWP)
We build x64 version in local
You will need proper Visual Studio 2019 setup

https://help.yoyogames.com/hc/en-us/articles/115001100548-Setting-Up-UWP-For-Windows-10-Desktop
https://help.yoyogames.com/hc/en-us/articles/115001256428-Setting-Up-UWP-For-Xbox-One
https://help.yoyogames.com/hc/en-us/articles/115001256408-Setting-Up-UWP-For-Windows-10-Mobile  


## Android (GMS_PLATFORM_ANDROID)
TODO
Install Android Studio: https://developer.android.com/studio
(currently installed: https://redirector.gvt1.com/edgedl/android/studio/install/2020.3.1.25/android-studio-2020.3.1.25-windows.exe)

https://help.yoyogames.com/hc/en-us/articles/115001368727-Setting-Up-For-Android-or-Amazon-Fire


## Amazon Fire (GMS_PLATFORM_AMAZONFIRE)
TODO
Install Android Studio: https://developer.android.com/studio
(currently installed: https://redirector.gvt1.com/edgedl/android/studio/install/2020.3.1.25/android-studio-2020.3.1.25-windows.exe)

https://help.yoyogames.com/hc/en-us/articles/115001368727-Setting-Up-For-Android-or-Amazon-Fire