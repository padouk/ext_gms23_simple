# ext_gms23_simple
Simple Extentension project for Game Maker Studio 2.03

## Requirements
The main commander is Visual Studio 2019
- Expected to build Win32 and Win64 on local
- Expected to build Unbuntu64 on remote, feel free to provision an AWS or AZURE cheapass burstable or a local vm
- Expected to build macosx on remote, feel free to provision a www.macincloud.com bare metal instance. ** you will need the USD$5 monthly package for ssh connection
- Expected to build HTML5 as emscript on local

## Windows
We build win32 and x64 version. By default the x64 version is used and we assume you
had the checkbox checked for x64 runtime in GMS.

You will need Visual Studio 2019

## HTML5
We build using emscriptent 2.0.1
follow those instructions: https://emscripten.org/docs/getting_started/downloads.html
and make sure you have the environment variable EMSCRIPTEN_SDK=C:\Tools\emsdk\upstream\emscripten

## Macosx
Provision a www.macincloud.com
Make sure it is known by visual studio code

## Ubundutu
