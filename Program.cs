using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pila_estatica_con_arreglos
{
    internal class Program
    {

        public class StaticStack<Pila>
        {
            private Pila[] stackArray; // Arreglo para almacenar elementos de la pila
            private int top;        // Índice del elemento superior de la pila
            private int capacity;   // Capacidad máxima de la pila

            // Constructor para inicializar la pila con una capacidad especificada
            public StaticStack(int capacity)
            {
                this.capacity = capacity;
                this.stackArray = new Pila[capacity]; // Inicializamos el arreglo con la capacidad especificada
                this.top = -1; // Inicialmente, la pila está vacía, por lo que top es -1
            }

            // Método para agregar un elemento a la pila (Push)
            public void Push(Pila item)
            {
                if (top < capacity - 1) // Verificamos si hay espacio en la pila
                {
                    top++; // Incrementamos el índice superior
                    stackArray[top] = item; // Agregamos el elemento en la posición superior
                }
                else
                {
                    Console.WriteLine("La pila está llena. No se puede agregar más elementos.");
                }
            }

            // Método para extraer y eliminar un elemento de la pila (Pop)
            public Pila Pop()
            {
                if (top >= 0) // Verificamos si la pila no está vacía
                {
                    Pila item = stackArray[top]; // Obtenemos el elemento en la posición superior
                    top--; // Decrementamos el índice superior para eliminar el elemento
                    return item; // Retornamos el elemento extraído
                }
                else
                {
                    Console.WriteLine("La pila está vacía. No se puede extraer ningún elemento.");
                    return default(Pila); // Retornamos el valor predeterminado del tipo (por ejemplo, null para referencias)
                }
            }

            // Método para consultar el elemento en la cima de la pila (Peek)
            public Pila Peek()
            {
                if (top >= 0) // Verificamos si la pila no está vacía
                {
                    return stackArray[top]; // Retornamos el elemento en la posición superior sin eliminarlo
                }
                else
                {
                    Console.WriteLine("La pila está vacía. No hay elementos para ver.");
                    return default(Pila);
                }
            }

            // Método para verificar si la pila está vacía
            public bool IsEmpty()
            {
                return top == -1;
            }

            // Método para verificar si la pila está llena
            public bool IsFull()
            {
                return top == capacity - 1;
            }

            // Método para obtener la cantidad de elementos en la pila
            public int Count()
            {
                return top + 1;
            }
        }

        class stack
        {
            static void Main(string[] args)
            {
                // Ejemplo de uso de la pila estática
                StaticStack<int> stack = new StaticStack<int>(5);

                stack.Push(1);
                stack.Push(2);
                stack.Push(3);

                Console.WriteLine("Elementos en la pila: " + stack.Count());

                Console.WriteLine("Elemento en la cima de la pila: " + stack.Peek());

                while (!stack.IsEmpty())
                {
                    Console.WriteLine("Elemento extraído de la pila: " + stack.Pop());
                }
            }
        }
    }
}
