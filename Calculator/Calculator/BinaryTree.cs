using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTreeMath
{
    // Lớp MyStack - Ngăn xếp
    public class MyStack<T>
    {
        private class Nodes
        {
            public T Data;
            public Nodes Next;
            public Nodes(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Nodes top;
        private int count;

        public MyStack()
        {
            top = null;
            count = 0;
        }

        public void Push(T item)
        {
            Nodes newNode = new Nodes(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return top.Data;
        }

        public bool IsEmpty() => count == 0;

        public int Count => count;
    }
    
    // Lớp cơ bản Node để đại diện cho nút trong cây
    public class Node
    {
        public string Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(string value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public double Answer { get; private set; }  // Lưu trữ kết quả hiện tại
        public double PreAnswer { get; private set; }  // Lưu trữ kết quả trước đó
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }
        private bool IsOperator(char c)
        {
            return "+-*/".Contains(c); // Hoặc bạn có thể sử dụng một mảng hoặc một bộ sưu tập các toán tử
        }
        private int Precedence(char v)
        {
            switch (v)
            {
                case '*':
                case '/':
                    return 2;
                case '+':
                case '-':
                    return 1;
                default:
                    return 0;
            }
        }

        // Xây dựng cây từ biểu thức toán học
        public Node BuildTree(string expression)
        {
            MyStack<Node> nodes = new MyStack<Node>();
            MyStack<char> operators = new MyStack<char>();
            int parenCount = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                if (char.IsDigit(c))
                {
                    StringBuilder number = new StringBuilder();
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        number.Append(expression[i]);
                        i++;
                    }
                    i--;
                    nodes.Push(new Node(number.ToString()));
                }
                else if (c == '(')
                {
                    parenCount++;
                    operators.Push(c);
                }
                else if (c == ')')
                {
                    parenCount--;
                    if (parenCount < 0)
                        throw new ArgumentException("Mismatched parentheses");
                    while (operators.Peek() != '(')
                    {
                        Node right = nodes.Pop();
                        Node left = nodes.Pop();
                        char op = operators.Pop();
                        Node newNode = new Node(op.ToString())
                        {
                            Left = left,
                            Right = right
                        };
                        nodes.Push(newNode);
                    }
                    operators.Pop(); // Loại bỏ '('
                }
                else if (IsOperator(c))
                {
                    while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(c))
                    {
                        Node right = nodes.Pop();
                        Node left = nodes.Pop();
                        char op = operators.Pop();
                        Node newNode = new Node(op.ToString())
                        {
                            Left = left,
                            Right = right
                        };
                        nodes.Push(newNode);
                    }
                    operators.Push(c);
                }
            }

            while (operators.Count > 0)
            {
                Node right = nodes.Pop();
                Node left = nodes.Pop();
                char op = operators.Pop();
                Node newNode = new Node(op.ToString())
                {
                    Left = left,
                    Right = right
                };
                nodes.Push(newNode);
            }

            Root = nodes.Pop();
            return Root;
        }
        // Phương thức tính toán và cập nhật Answer và PreAnswer
        public double Evaluate(Node node)
        {
            if (node == null)
                return 0;

            // Nếu là nút lá (toán hạng)
            if (node.Left == null && node.Right == null)
                return double.Parse(node.Value);

            // Đệ quy tính giá trị của các nút con
            double leftValue = Evaluate(node.Left);
            double rightValue = Evaluate(node.Right);

            // Áp dụng toán tử
            switch (node.Value)
            {
                case "+":
                    return leftValue + rightValue;
                case "-":
                    return leftValue - rightValue;
                case "*":
                    return leftValue * rightValue;
                case "/":
                    if (rightValue == 0)
                        throw new DivideByZeroException("Lỗi chia cho 0.");
                    return leftValue / rightValue;
                default:
                    throw new InvalidOperationException("Toán tử không hợp lệ.");
            }
        }
    }


}