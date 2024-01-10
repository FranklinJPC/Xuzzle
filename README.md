# Xuzzle and Xamari

Con este proyecto adquirimos conocimientos con la tecnología Xamari y su desarrollo.

## Implementación y Cambios

El archivo que se modificó fue el siguiente `Tile.cs`:

Este código es parte de una aplicación Xamarin.Forms que parece estar construyendo
un juego de rompecabezas (puzzle) llamado "XamagonXuzzle".
El código define una clase Tile que representa una pieza del rompecabezas. Aquí hay una explicación del código:

### Diccionario de Nombres de Imágenes (ImageNames):

- Se define un diccionario estático dentro de la clase Tile. Este diccionario asocia las coordenadas de fila y columna de una pieza del rompecabezas con el nombre de un archivo de imagen. Cada pieza del rompecabezas se identifica con una combinación de fila y columna, y el nombre de la imagen se utiliza para cargar la imagen correspondiente más adelante.
![image](https://github.com/FranklinJPC/Xuzzle/assets/113868310/556f5682-1234-40d2-9321-fd18295f1dde)


### Constructor (`Tile(int row, int col)`):

- El constructor toma como parámetros las coordenadas de fila (row) y columna (col) de la pieza del rompecabezas que se está creando.
- Se utiliza el diccionario ImageNames para obtener el nombre de la imagen asociada a la posición dada.
- Se crea una nueva instancia de ContentView llamada TileView, que contiene un Image con la imagen correspondiente cargada desde el archivo. Se utiliza un margen (Padding) de 1 para dar un pequeño espacio alrededor de la imagen.
![image](https://github.com/FranklinJPC/Xuzzle/assets/113868310/6361f05b-0d02-40ec-9973-fd4db51cdada)


### Diccionario de Vistas (Dictionary):

- Se utiliza un diccionario estático dentro de la clase Tile para mapear las vistas (View) a las instancias de Tile. Esto se hace para poder obtener la instancia de Tile correspondiente a una vista más adelante en la aplicación.
![image](https://github.com/FranklinJPC/Xuzzle/assets/113868310/48d34bc3-e14c-4a65-862a-ec6ece136516)


### Propiedades Públicas:

- Row y Col: Propiedades públicas para obtener y establecer las coordenadas de fila y columna de la pieza del rompecabezas.
- TileView: Propiedad pública que proporciona acceso a la vista (ContentView) que representa la pieza del rompecabezas.
![image](https://github.com/FranklinJPC/Xuzzle/assets/113868310/0dd0f9a5-b02e-4334-88b7-0d0d20b87faa)


