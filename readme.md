El tipo `string` es un **tipo por referencia**
Esto significa que cuando trabajamos con una variable de tipo string, lo que realmente tenemos es una referencia/puntero a un lugar en la memoria donde se almacena el valor real de la cadena.

El tipo `string` en C# tiene varias secuencias de escape, las cuales son:
- `\\` : Barra invertida
- `\'` : Comilla simple
- `\"` : Comilla doble
- `\0` : Carácter nulo
- `\a` : Alerta (campana)
- `\b` : Retroceso
- `\f` : Avance de página
- `\n` : Nueva línea
- `\r` : Retorno de carro
- `\t` : Tabulación horizontal
- `\v` : Tabulación vertical

Estas secuencias de escape permiten representar caracteres especiales dentro de las cadenas de texto.

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
### `@` (Verbatim string literal)
El carácter `@` antes de una cadena de texto convierte a esta en una cadena textual literal. Esto significa que se interpretan literalmente los caracteres especiales y los caracteres de escape, permitiendo cadenas multilínea y uso directo de caracteres como `\` sin necesidad de escape.
El carácter $ antes de una cadena de texto permite la interpolación de cadenas, es decir, insertar expresiones dentro de la cadena que serán evaluadas y convertidas a su representación en texto.