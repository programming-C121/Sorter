## Sorter

### Problema

Queremos comparar la eficiencia de distintos algoritmos de ordenación, pero las colecciones pueden estar en distintas
estructuras de datos o tener comportamientos distintos.

### ¿Queremos implementar cada método de ordenación para cada estructura de datos?

Por supuesto que no, sería poco DRY (Don't Repeat Yourself) de nuestra parte.

### Solución

Hacemos un wrapper para la estructura de datos, ISortable, con los métodos necesarios para ordenar y solo tenemos que
implementar nuestro método Sort para saber ordenar un ISortable.

Las interfaces `ISortable` e `ISorter` están definidad en `Sorter/Interfaces`. En `Sorter/Sortables` y `Sorter/Sorters`
se encuentran ejemplos de implementaciones de estas.

### Propuesta

1. Implementar Insertion Sort.
2. Generalizar la estructura de clases para que ordene cualquier estructura de datos de tipo genérico T (implementando
   el Isorteable para esa estructura de datos por supuesto).
3. Extender la funcionalidad para permitir ordenar por distintos criterios.