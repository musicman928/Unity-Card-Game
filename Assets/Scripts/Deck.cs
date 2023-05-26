using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck<T> {
    Stack<T> stack = new Stack<T>();

    public Deck() {
        
    }

    public T Draw() {
        return stack.Pop();
    }

    public T[] Draw(int amount) {
        List<T> list = new List<T>();

        while(amount > 0) {
            list.Add(Draw());
            amount--;
        }

        return list.ToArray();
    }

    public void Shuffle() {
        List<T> list = stack.GetList();
        Print();
        stack.Clear();
        Print();

    }

    public void Print() {
        Debug.Log(string.Join(",", stack.GetList().ToArray()));
    }
    

}