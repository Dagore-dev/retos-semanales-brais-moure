# Los números perdidos

Dado un array de enteros ordenado y sin repetidos crea una función que calcule y retorne todos los que faltan entre el mayor y el menor. Lanza un error si el array de entrada no es correcto.

## Ejemplos
 - `{ 1, 1, 5, 6, 7 }` => `ArgumentException`
 - `{ 6, 5, 1, 7 }` => `ArgumentException`
 - `{ 1, 3, 6, 7 }` => `{ 2, 4, 5 }`
 - `{}` => `{}`
 - `{ 1 }` => `{}`
 - `{ 1, 2 }` => `{}`
 - `{ 1, 4 }` => `{ 2, 3 }`