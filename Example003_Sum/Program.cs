int numberA = 3;
int numberB = 5;
Console.WriteLine(numberA + numberB);
int numberC = 31;
int numberD = 50;
int result = numberC + numberD;
Console.WriteLine(result);

int numberE = new Random().Next(1, 10); //1 2 3 ...9
int numberF = new Random().Next(1, 10);
int result1 = numberE + numberF;
Console.WriteLine(result1);

int numberG = new Random().Next(1, 10); //1 2 3 ...9
Console.WriteLine(numberG); // здесь добавил Console.WriteLine(numberG) и Console.WriteLine(numberH) чтобы 
//видеть какие числа участвуют
int numberH = new Random().Next(1, 10); //
Console.WriteLine(numberH);
int result2 = numberG + numberH;
Console.WriteLine(result2);

