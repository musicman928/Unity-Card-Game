using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stack<T> {
    List<T> list;

    public Stack() {
        list = new List<T>();
    }

    public Stack(T[] array) {
        list = new List<T>();
        for (int i = 0; i < array.Length; i++) {
            Push(array[i]);
        }
    }

    public void Push(T item) {
        list.Insert(0, item);
    }

    public T Pop() {
        T temp = list[0];
        list.RemoveAt(0);
        return temp;
    }

    public T Peek() {
        return list[0];
    }

    public void Reverse() {
        
        list.Reverse();
    }

    public List<T> GetList() {
        return list;
    }

    public void Clear() {
        list.Clear();
    }

    
}