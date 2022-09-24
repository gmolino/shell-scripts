# shell-scripts
shell-scripts para /usr/bin/ y ~rc

## dockerip
Retorna todos los contenedores iniciados y ip address.

``` mermaid
flowchart LR
A[Hard] -->|Text| B(Round)
B --> C{Decision}
C -->|One| D[Result 1]
C -->|Two| E[Result 2]
```
``` mermaid
gantt
    section Section
    Completed :done,    des1, 2014-01-06,2014-01-08
    Active        :active,  des2, 2014-01-07, 3d
    Parallel 1   :         des3, after des1, 1d
    Parallel 2   :         des4, after des1, 1d
    Parallel 3   :         des5, after des3, 1d
    Parallel 4   :         des6, after des4, 1d
```

## cs
Cambia de directorio con `cs <dir>` para salvar la ruta.    
Regresa a la ruta almacenada con `cs`.    
El fichero *~/.cs* almacena la ruta.   
*Función en bash para incluir en .zshrc.*   

## ldocker
Ejecuta el último `docker start <containers>` independientemente del número de contedores.    
*Función en bash para incluir en .zshrc.*   

## alias
+ **update**: Actualiza sin confirmación sistemas ARCH Linux

## homeoffice
Partiendo de una fecha dada en la variable *firstdate* recorre el calendario en periodos 8 días, obviando los fines de semana, y devuelve el último y el futuro.
