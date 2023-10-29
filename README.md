# Max Payne Tools

A library for interacting with Max Payne 1 game assets.\
Currently only supports the LDB format (level data).

## Usage - WIP

`MaxPayneTools`\
This is the main library of the project, which handles reading data and exposing it as easily readable and editable variables. Designed to be drag-n-drop into any project.

`MaxPayneTools.CLI`\
A command line tool that mostly serves as a usage example - **currently WIP**

## Future plans

- Handling RAS packages (currently requires the user to unpack them manually)
- Exporting meshes as GLTF
- Handling textures, materials
- Support for files other than levels (characters, items, etc.)

## Credits

- [m0nstr0](https://github.com/m0nstr0) - Data type/file format spec, Autodesk Maya plugin for doing basically the same thing as this project; this wouldn't be possible without the information they shared [here](https://github.com/m0nstr0/max_payne_ldb_importer/tree/master/docs/specification)
- [NotNite](https://github.com/NotNite) - Project structure assistance and baby's first C# project troubleshooting
