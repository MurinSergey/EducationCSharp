## ������� 5.1.6
### ����� ����� ������� � ���������� ���������� ������������� ������ � ������� ��� �� �����. 
�������������� ��� �� �����:
static int[] GetArrayFromConsole() {
  var result = new int[5];

  for (int i = 0; i < result.Length; i++) {
    Console.WriteLine("������� ������� ������� ����� {0}", i + 1);
    result[i] = int.Parse(Console.ReadLine());
  }

  return result;
}