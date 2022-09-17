String[] matrix = { "привет", "пока", "ого", ";-)", ":-(", "ель", "собака", "12443" };
int sizeNewMatrix = 0;
for (int i = 0; i < matrix.Length; i++)
{
    {
        if (matrix[i].Length <= 3) { sizeNewMatrix++; }
    }
}
String[] newMatrix = new String[sizeNewMatrix];
int j = 0;
for (int i = 0; i < matrix.Length; i++)
{
    if (matrix[i].Length <= 3)
    {
        newMatrix[j] = matrix[i];
        j++;
    }
}
Console.WriteLine("[{0}]", string.Join(", ", newMatrix));