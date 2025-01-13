/*
A feladat a github-on olvasható!
 
A fejlesztő csapat munkája után elkészült két osztály UML diagramja. Ön azt a feladatot kapta, hogy fejlessze ki az osztályokat!

A Position osztályba az adattagok private elérhetőségük legyenek! Ekkor a feladat megoldása, csak akkor lehetséges, ha a Position osztályt még két metódussal továbbfejleszti! A feladata, hogy jöjjön rá, hogyan kell ezt megoldani!

Minden kiírást a ToConsole metódusokban valósítson meg!

Munkája ellenőrzéseként használja a következő kódot:

Position position = new Position(2,-1);
position.ToConsole();
Warrior warrior = new Warrior("Peter the Iron Man", position);
warrior.ToConsole();
warrior.MoveHorizontal(3);
warrior.MoveVertical(-2);
warrior.ToConsole();

A kód kimenete a következő kell legyen:
(2,-1)
Peter the Iron Man, position (2,-1)
Peter the Iron Man, position (5,-3)
 */

using System;

namespace WarriorProject
{
    public class Position
    {
        private int x;
        private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void ToConsole()
        {
            Console.WriteLine($"({x}, {y})");
        }
    }
    public class Warrior
    {
        private string name;
        private Position position;
        public Warrior(string name, Position p)
        {
            this.name = name;
            position = p;
        }
        public void MoveHorizontal(int distance)
        {
            position.X += distance;
        }
        public void MoveVertical(int distance)
        {
            position.Y += distance;
        }
        public void ToConsole()
        {
            Console.WriteLine($"{name}, position ({position.X},{position.Y})");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, -1);
            position.ToConsole();
            Warrior warrior = new Warrior("Peter the Iron Man", position);
            warrior.ToConsole();
            warrior.MoveHorizontal(3);
            warrior.MoveVertical(-2);
            warrior.ToConsole();
        }
    }
}
