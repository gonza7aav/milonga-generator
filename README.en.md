# milonga-generator

<div align='center'>

![GitHub release](https://img.shields.io/github/v/release/gonza7aav/milonga-generator?label=release&color=informational)
![Repository license](https://img.shields.io/github/license/gonza7aav/milonga-generator?label=license&color=informational)

[![Léeme en Español](https://img.shields.io/badge/Léeme%20en-Español-brightgreen)](README.es.md)

</div>

A desktop application to create milonga's playlist

> Usually the **milonga**, as an event, has a repertoire of mainly tango, milonga and vals criollo, that group in «_tandas_» of three or five dances separated by a short musical break called «_cortinas_».
>
> Each _tanda_ has only one of this music style, and there is an informal rule that dictates how to group music by orchestra, recording year, with a singer or not, by composer, modern, etc.
> <sup>[\[1\]](<https://es.wikipedia.org/wiki/Milonga_(evento)>)</sup>

## 🚧 Prerequisites

- _[.NET Framework 3.5](https://dotnet.microsoft.com/download/dotnet-framework/net35-sp1)_

## 🛠️ Install

1. Download the latest [release](https://github.com/gonza7aav/milonga-generator/releases)

2. Unzip the downloaded file

3. Install the application runing `setup.exe`

## 🚀 Usage

First, you need to add the _tandas_, a dropdown list will show the folders that have been added. Also, you have to select how many _tandas_ will have the playlist (remember you can't choose more than the added!) and how many songs will have each _tanda_. If a _tanda_ doesn't have the necessary amount of songs, the program will show an error when trying to create a playlist.

In the _cortinas_ section, you can choose if you want to add them or not. If you do, you must select the path of the songs' folder and if you want to use always the same or a different one.

All these settings can be saved, and then loaded so you don't have to repeat them each time you need a playlist.

With everything correct the "Generar Playlist" button will be enabled, which will create a `.m3u` file in the path you choose. This file has the order of the songs that need to be played, but it doesn't have the playable files. In other words, it must be played in a player with the same location of _tandas_ and _cortinas_ that the computer where it was created.

## 💬 Frequent Questions

1. I finished configuring the options, why is the "Generar Playlist" button disabled?

   To generate a playlist the settings must follow these rules:

   1. There must be 1 or more _tandas_ added
   2. There must be at least 1 _tanda_ each playlist, but the amount can't be greater than the added.
   3. Each _tanda_ must have at least one song
   4. The entered values in the last two inputs must be numeric.
   5. If you opt to add _cortinas_, you must select their path

2. I have a v1.0 config file, Is it compatible with v2.0?

   No. In order to add more options to customize the playlist, we reduce its compatibility

## 📝 License

Copyright © 2021 _Aguirre Gonzalo Adolfo_.
This project is _[MIT](LICENSE)_ licensed.
