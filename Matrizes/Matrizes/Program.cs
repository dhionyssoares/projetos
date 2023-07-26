int m =int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[m,n];

Console.WriteLine("digite a sequência de 4 números, separado por vírgula: ");

for (int i = 0; i < m; i++) {
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < values.Length; j++) {
        mat[i,j] = int.Parse(values[j]);
    }
}
Console.WriteLine();
Console.WriteLine("digite o número que quer buscar: ");
int x =  int.Parse(Console.ReadLine());


for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        if (mat[i, j] == x) {

            Console.WriteLine("\nposition " + i + "," + j + ":");

            if (i >= 0 && i<= mat.GetLength(0)-1 && j - 1 >= 0 && j - 1 <= mat.GetLength(1)-1) {
                int left = (int)mat.GetValue(i, j - 1);
                Console.WriteLine("left: " + left);
            }
            if (i >= 0 && i<= mat.GetLength(0)-1 && j + 1 >= 0 && j + 1 <= mat.GetLength(1)-1) {
                int right = (int)mat.GetValue(i, j + 1);
                Console.WriteLine("right: " + right);
            }
            if (i - 1 >= 0 && i - 1 <= mat.GetLength(0)-1 && j >= 0 && j <= mat.GetLength(1)-1) {
                int up = (int)mat.GetValue(i - 1, j);
                Console.WriteLine("up: " + up);
            }
            if (i + 1 >= 0 && i + 1 <= mat.GetLength(0)-1 && j >= 0 && j <= mat.GetLength(1)-1) {
                int down = (int)mat.GetValue(i + 1, j);
                Console.WriteLine("down: " + down);
            }

        }
    }
}
