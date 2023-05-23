using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Property {
    static Dictionary<string, List<GameObject>> dictionary = new Dictionary<string, List<GameObject>>();

    public static void Add(string key, GameObject member) {
        if (dictionary.ContainsKey(key)) {
            List<GameObject> value;
            dictionary.TryGetValue(key, out value);
            value.Add(member);
        } else {
            List<GameObject> value;
            dictionary.TryGetValue(key, out value);
            value = new List<GameObject>();
            value.Add(member);
        }
    }

    public static void Remove(string key, GameObject member) {
        if (dictionary.ContainsKey(key)) {
            List<GameObject> value;
            dictionary.TryGetValue(key, out value);
            value.Remove(member);
        } else {
            Debug.Log("Cannot remove from Property: " + key + ", as it does not exist.");
        }
    }

    public static GameObject[] GetAll(string key) {
        List<GameObject> value;
        dictionary.TryGetValue(key, out value);
        return value.ToArray();
    }

}
