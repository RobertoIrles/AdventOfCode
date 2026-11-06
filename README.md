# Advent of Code Solutions

Colección de soluciones para los retos anuales de [Advent of Code](https://adventofcode.com/), diseñadas con un enfoque en código limpio, algoritmos eficientes y cobertura mediante pruebas automatizadas.

![.NET CI](https://github.com/RobertoIrles/AdventOfCode/actions/workflows/dotnet-ci.yml/badge.svg)

## Progreso

| Año | Lenguaje | Días Completados | Estrellas |
| :---: | :---: | :---: | :---: |
| 2015 | C# (.NET 9) | 04/25 | 08/50 |

---

## Estructura del Proyecto

* **`csharp/Common/`**: Librería de utilidades.
* **`csharp/YearYYYY/`**: Soluciones de cada año, con su respectivo proyecto de pruebas unitarias (`xUnit`).

---

## Cómo ejecutar las soluciones

### Requisitos previos
* [.NET SDK](https://dotnet.microsoft.com/download) (versión 9.0 o superior)

### Ejecutar un día específico
```bash
cd csharp/Year2023
dotnet run -- 1
```

### Ejecutar todos los tests
```bash
dotnet test csharp/
```