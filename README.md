# Registro de Cumpleaños

Una aplicación simple de registro de cumpleaños en C# que permite agregar, mostrar y eliminar cumpleaños registrados.

## Resumen

La aplicación utiliza archivos de texto para almacenar la información de los cumpleaños. Permite al usuario realizar operaciones básicas de administración de cumpleaños, como agregar nuevos cumpleaños, mostrar la lista de cumpleaños registrados y eliminar cumpleaños específicos.

## Uso de Ejemplo

1. Al ejecutar la aplicación, se presenta un menú con las siguientes opciones:
    - **Agregar Cumpleaños (1):** Permite al usuario agregar un nuevo cumpleaños.
    - **Mostrar Cumpleaños Registrados (2):** Muestra la lista de cumpleaños registrados.
    - **Eliminar Cumpleaños (3):** Permite al usuario eliminar un cumpleaños existente.
    - **Salir (4):** Cierra la aplicación.

2. **Agregar Cumpleaños:**
    - El usuario ingresa el nombre y la fecha de cumpleaños.
    - La información se agrega al archivo de registro.

3. **Mostrar Cumpleaños Registrados:**
    - Muestra la lista de cumpleaños almacenados en el archivo.

4. **Eliminar Cumpleaños:**
    - Muestra la lista de cumpleaños registrados.
    - El usuario ingresa el nombre del cumpleaños que desea eliminar.
    - El cumpleaños se elimina del archivo.

5. **Salir:**
    - Cierra la aplicación.

## Estructura de Archivos

- `C:\test`: Directorio principal para almacenar el archivo de registro.
  - `cumpleaños.txt`: Archivo de texto que contiene la información de los cumpleaños registrados.
  - `temporal.txt`: Archivo temporal utilizado durante el proceso de eliminación.
