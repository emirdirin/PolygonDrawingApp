# PolygonDrawing

**PolygonDrawing** is a simple Windows Forms application developed in C# for drawing and rotating polygons using user input.

## Features

- Draws a polygon using:
  - Center coordinates (X, Y)
  - Edge length
  - Number of edges
  - Rotation angle
- Displays the polygon in a PictureBox
- Lists vertex coordinates in a ListBox
- Allows rotating the polygon clockwise
- Includes a button to generate random values for all inputs

## Classes

### `Point2D`
- Holds Cartesian coordinates (x, y)
- Supports conversion between Cartesian and polar coordinates

### `Polygon`
- Holds center (`Point2D`), edge length, and number of edges
- Calculates vertex coordinates
- Supports polygon rotation

## Default & Random Value Ranges

| Field            | Default | Range       |
|------------------|---------|-------------|
| X, Y Coordinates | 0       | 0–3         |
| Edge Length      | 4       | 3–9         |
| Edge Count       | 5       | 3–10        |
| Rotation Angle   | 30°     | 0–359       |
