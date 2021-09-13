# milonga-generator

<div align='center'>

![Release en GitHub](https://img.shields.io/github/v/release/gonza7aav/milonga-generator?label=release&color=informational)
![Licencia del repositorio](https://img.shields.io/github/license/gonza7aav/milonga-generator?label=licencia&color=informational)

[![Read me in English](https://img.shields.io/badge/Read%20me%20in-English-brightgreen)](README.en.md)

</div>

Una aplicación de escritorio para crear playlist de milongas.

> Normalmente la **milonga**, entendida como evento, tiene un repertorio que consiste en tango, milonga y vals criollo, que se agrupan en «_tandas_» de entre tres y cinco bailes, separadas por pequeñas piezas o fragmentos de música ligera llamadas «_cortinas_».
>
> Cada _tanda_ consta de un solo tipo de estos ritmos, y es norma habitual agruparlos por orquestas, año de grabación, con cantantes o no, por compositores, modernos, etc.
> <sup>[\[1\]](<https://es.wikipedia.org/wiki/Milonga_(evento)>)</sup>

## 🚧 Requisitos

- _[.NET Framework 3.5](https://dotnet.microsoft.com/download/dotnet-framework/net35-sp1)_

## 🛠️ Instalación

1. Descargar la última versión en [Releases](https://github.com/gonza7aav/milonga-generator/releases)

2. Descomprimir el archivo descargado

3. Instalar la aplicación ejecutando `setup.exe`

## 🚀 Ejecución

Primero debes agregar las _tandas_, una lista desplegable nos irá mostrando que carpetas han sido agregadas. También tienes que seleccionar cuántas _tandas_ tendrá la playlist (recuerda que no puedes elegir más que las agregadas!) y cuántas piezas tendrá cada _tanda_. Si una _tanda_ no posee la cantidad necesaria de canciones, el programa nos lo notificará mediante un error al intentar crear la playlist.

En la sección de _cortinas_, puedes optar por su incorporación o no. Si lo haces, tendrás que especificar de qué carpeta elegirlas y si quieres usar siempre la misma pieza o diferentes.

Todos estos ajustes pueden ser guardados, y luego cargados para no tener que ir repitiendo la configuración cada vez que creemos una playlist.

Si todo es correcto se nos habilitará el botón de "Generar Playlist" que creará un archivo `.m3u` en la ubicación que hemos especificado. Este archivo contiene el orden en que se deben reproducir las canciones, pero no posee las canciones. Es decir, requiere que sea reproducido en equipos que tengan la misma ubicación de las _tandas_ y _cortinas_ que la computadora donde fue generado.

## 💬 Preguntas Frecuentes

1. Terminé de configurar las opciones, ¿Por qué el botón "Generar Playlist" está desactivado?

   Para que se pueda generar una playlist, los ajustes deben cumplir con lo siguiente:

   1. Debe haber 1 o más _tandas_ agregadas
   2. Debe haber al menos 1 _tanda_ por playlist, pero la cantidad no puede ser mayor a las agregadas
   3. Cada _tanda_ debe tener al menos una pieza
   4. Los valores ingresados en los dos campos anteriores deben ser numéricos
   5. Si se incorporan _cortinas_, se debe haber seleccionado la ubicación de las mismas

2. Tengo un archivo de configuración de la versión 1.0 ¿Es compatible con la versión 2.0?

   No. Al haber agregado más opciones para personalizar las playlist tuvimos que reducir su compatibilidad.

## 📝 Licencia

Copyright © 2021 _Aguirre Gonzalo Adolfo_.
Este proyecto se encuentra bajo la licencia _[MIT](LICENSE)_.
