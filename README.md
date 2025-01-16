# Practice_Polymorphism
This project demonstrates the use of **polymorphism** in C# by calculating the area of different geometric shapes: **Square**, **Rectangle**, and **Triangle**. Each shape inherits from a base class and overrides a method to implement specific behavior where needed.

## Overview
The program uses a base class `BaseClass` and three derived classes:
- `Square`
- `Rectangle`
- `Triangle`

Each class contains properties for `Width` and `Height` and implements the method `CalculateArea()`. The behavior of `CalculateArea()` differs in the `Triangle` class, where the area is calculated as `(Width * Height) / 2`.

## Structure

### BaseClass
The base class contains:
- **Properties**:
  - `Width`: The width of the shape.
  - `Height`: The height of the shape.
- **Methods**:
  - `CalculateArea()`: Calculates the area as `Width * Height`. This is the default behavior for shapes like `Square` and `Rectangle`.

### Derived Classes
1. **Square**:
   - Inherits from `BaseClass`.
   - Uses the base implementation of `CalculateArea()`.

2. **Rectangle**:
   - Inherits from `BaseClass`.
   - Uses the base implementation of `CalculateArea()`.

3. **Triangle**:
   - Inherits from `BaseClass`.
   - Overrides `CalculateArea()` to return `(Width * Height) / 2`.

## Example Code
![image](https://github.com/user-attachments/assets/ac5e0e24-20fc-4ab9-a80e-3fefd3510058)
