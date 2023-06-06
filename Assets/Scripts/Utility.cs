using System;
public static class Utility {
    public static string CapitalizeFirst(string input) {
        char[] array = input.ToCharArray();
        array[0] = Char.ToUpper(array[0]);
        return new string(array);
    }

    public static string Format(string input) {
        input = CapitalizeFirst(input.ToLower());

        char[] array = input.ToCharArray();
        for (int i = 0; i < array.Length; i++) {
            if (array[i] == '_') {
                array[i] = ' ';
            }
        }
        
        return input;
    }

    public static string FormatAllLower(string input) {
        input = input.ToLower();

        char[] array = input.ToCharArray();
        for (int i = 0; i < array.Length; i++) {
            if (array[i] == '_') {
                array[i] = ' ';
            }
        }
        
        return input;
    }
}