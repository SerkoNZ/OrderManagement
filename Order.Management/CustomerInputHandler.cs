﻿using Order.Management.ToyBlocks;
using System;
using System.Collections.Generic;

namespace Order.Management
{
    public class CustomerInputHandler
    {
        // Get customer Info
        public (string customerName, string address, string dueDate) GetCustomerInfoInput()
        {
            Console.Write("Please input your Name: ");
            string customerName = GetUserInput();

            Console.Write("Please input your Address: ");
            string address = GetUserInput();

            Console.Write("Please input your Due Date: ");
            string dueDate = GetUserInput();

            return (customerName, address, dueDate);
        }

        public List<Shape> GetCustomerOrderInput()
        {
            Square square = OrderSquaresInput();
            Triangle triangle = OrderTrianglesInput();
            Circle circle = OrderCirclesInput();

            var orderedShapes = new List<Shape>();
            orderedShapes.Add(square);
            orderedShapes.Add(triangle);
            orderedShapes.Add(circle);

            return orderedShapes;
        }

        private static Circle OrderCirclesInput()
        {
            Console.Write("\nPlease input the number of Red Circle: ");
            int redCircle = Convert.ToInt32(GetUserInput());

            Console.Write("Please input the number of Blue Circle: ");
            int blueCircle = Convert.ToInt32(GetUserInput());

            Console.Write("Please input the number of Yellow Circle: ");
            int yellowCircle = Convert.ToInt32(GetUserInput());

            Circle circle = new Circle(redCircle, blueCircle, yellowCircle);

            return circle;
        }

        private static Square OrderSquaresInput()
        {
            Console.Write("\nPlease input the number of Red Squares: ");
            int redSquare = Convert.ToInt32(GetUserInput());

            Console.Write("Please input the number of Blue Squares: ");
            int blueSquare = Convert.ToInt32(GetUserInput());

            Console.Write("Please input the number of Yellow Squares: ");
            int yellowSquare = Convert.ToInt32(GetUserInput());

            Square square = new Square(redSquare, blueSquare, yellowSquare);
            return square;
        }

        private static Triangle OrderTrianglesInput()
        {
            Console.Write("\nPlease input the number of Red Triangles: ");
            int redTriangle = Convert.ToInt32(GetUserInput());

            Console.Write("Please input the number of Blue Triangles: ");
            int blueTriangle = Convert.ToInt32(GetUserInput());

            Console.Write("Please input the number of Yellow Triangles: ");
            int yellowTriangle = Convert.ToInt32(GetUserInput());

            Triangle triangle = new Triangle(redTriangle, blueTriangle, yellowTriangle);

            return triangle;
        }

        private static string GetUserInput()
        {
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("please enter valid details");
                input = Console.ReadLine();
            }

            return input;
        }
    }
}