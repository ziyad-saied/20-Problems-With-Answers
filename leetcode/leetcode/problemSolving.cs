using System.Security.Cryptography.X509Certificates;

namespace leetcode
{
        public delegate int StringDelegate(string word);
    internal class problemSolving
    {

        //static int GCD(int a, int b)
        //{
        //    while (b != 0)
        //    {
        //        int temp = b;
        //        b = a % b;
        //        a = temp;
        //    }
        //    return a;
        //}
        //public static int SumOfWidths(int numOfPepole, int wallHeight,int[] Heights)
        //{
        //    int[] result=new int[numOfPepole];
        //    int total = 0;
        //    for (int i = 0; i < Heights.Length; i++)
        //    {
        //        if (Heights[i] <= wallHeight)
        //        {
        //            result[i] = 1;
        //        }
        //        else
        //        {
        //            result[i] = 2;
        //        }
        //    }
        //    foreach (int i in result)
        //    {
        //        total += i;
        //    }
        //    return total;
        //}
        public static void Main(string[] args)
        {
            #region Problem 1 "http://codeforces.com/contest/677/problem/A"
            //string[] firstLine = Console.ReadLine().Split(' ');
            //int numOfPepole = int.Parse(firstLine[0]);
            //int wallHeight = int.Parse(firstLine[1]);
            //string[] secondLine = Console.ReadLine().Split(' ');
            //int[] Heights = new int[numOfPepole];
            //for (int i = 0; i < Heights.Length; i++)
            //{
            //    Heights[i] = int.Parse(secondLine[i]);
            //}
            //int[] result = new int[numOfPepole];
            //int total = 0;
            //for (int i = 0; i < Heights.Length; i++)
            //{
            //    if (Heights[i] <= wallHeight)
            //    {
            //        result[i] = 1;
            //    }
            //    else
            //    {
            //        result[i] = 2;
            //    }
            //}
            //foreach (int i in result)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total); 
            #endregion

            #region Problem 2 "http://codeforces.com/contest/734/problem/A"
            //int numOfGames = int.Parse(Console.ReadLine());
            //int Anton = 0;
            //int Danik = 0;
            //string players = Console.ReadLine();
            //players.ToArray();
            //foreach (char player in players)
            //{
            //    if (players.Length != numOfGames || (player != 'A' && player != 'D'))
            //    {
            //        players = Console.ReadLine();
            //    }
            //}
            //for (int i = 0; i < players.Length; i++)
            //{

            //    if (players[i] == 'A')
            //    {
            //        Anton++;
            //    }
            //    else if (players[i] == 'D')
            //    {
            //        Danik++;
            //    }
            //}
            //if (Anton > Danik)
            //{
            //    Console.WriteLine("Anton");
            //}
            //else if (Danik > Anton)
            //{
            //    Console.WriteLine("Danik");
            //}
            //else
            //{
            //    Console.WriteLine("Friendship");
            //} 
            #endregion

            #region Problem 3 "http://codeforces.com/contest/231/problem/A"
            //int numOfProblems= int.Parse(Console.ReadLine());
            //string[] checker = new string[3];
            //checker.ToArray();
            //int[] container = new int[3];
            //int positive = 0;
            //int negative = 0;
            //int total = 0;
            //for (int i = 0; i < numOfProblems; i++)
            //{
            //    checker = Console.ReadLine().Split(' ');
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (int.Parse(checker[j]) == 1)
            //        {
            //            positive++;
            //        }
            //        else
            //        {
            //        negative++;
            //        }
            //    }
            //    if (positive > negative)
            //    {
            //        total++;
            //        positive = 0;
            //        negative = 0;
            //    }
            //    else
            //    {
            //        positive = 0;
            //        negative = 0;

            //    }
            //}
            //Console.WriteLine(total); 
            #endregion

            #region Problem 4 "http://codeforces.com/contest/263/problem/A"
            //for (int i = 1; i <= 5; i++)
            //{
            //    string[] x = Console.ReadLine().Split(' ');
            //    for (int j = 1; j <= 5; j++)
            //    {
            //        int value = int.Parse(x[j - 1]);
            //        if (value == 1)
            //        {
            //            Console.WriteLine(Math.Abs(i - 3) + Math.Abs(j - 3));
            //            break;
            //        }
            //    }
            //} 
            #endregion

            #region Problem 5 "http://codeforces.com/contest/405/problem/A"
            //string firstLine = Console.ReadLine();
            //int f = int.Parse(firstLine);
            //string[] second = Console.ReadLine().Split(' ');
            //int[] array= new int[second.Length];
            //for (int i = 0; i < second.Length; i++)
            //{
            //    array[i]= int.Parse(second[i]);
            //}
            //Array.Sort(array);
            //array.ToString();
            //Console.WriteLine(string.Join(' ',array)); 
            #endregion

            #region Problem 6 "http://codeforces.com/contest/112/problem/A"
            //string str1=Console.ReadLine().ToUpper();
            //string str2=Console.ReadLine().ToUpper();
            //if (str1 == str2)
            //{
            //    Console.WriteLine("0");
            //}
            //else if (String.Compare(str1 , str2)>0)
            //{
            //    Console.WriteLine("1");
            //}
            //else
            //{
            //    Console.WriteLine("-1");
            //} 
            #endregion

            #region Problem 7 "http://codeforces.com/contest/236/problem/A"
            //string input = Console.ReadLine().ToLower();
            //string output = "";
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (!output.Contains(input[i]))
            //    {
            //        output += input[i];
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}
            //if (output.Length % 2 == 0)
            //{
            //    Console.WriteLine("CHAT WITH HER!");
            //}
            //else
            //{
            //    Console.WriteLine("IGNORE HIM!");
            //} 
            #endregion

            #region Problem 8 "http://codeforces.com/contest/59/problem/A"
            //string input = Console.ReadLine();
            //int up=0, low=0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (char.IsUpper(input[i]))
            //    {
            //        up++;
            //    }
            //    else
            //    {
            //        low++;
            //    }
            //}
            //if(up > low)
            //{
            //    Console.WriteLine(input.ToUpper());
            //}
            //else
            //{
            //    Console.WriteLine(input.ToLower());
            //} 
            #endregion

            #region Problem 9 "http://codeforces.com/contest/344/problem/A"
            //int numOfMagnet = int.Parse(Console.ReadLine()); 
            //string[] magnets = new string[numOfMagnet];
            //for(int i = 0; i < numOfMagnet; i++)
            //{
            //    magnets[i]= Console.ReadLine();
            //}

            //string checker = "";
            //int counter = 0;
            //checker = magnets[0];
            //for (int i = 0; i < magnets.Length; i++)
            //{
            //    if (checker == magnets[i])
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        counter++;
            //        checker = magnets[i];
            //    }
            //}
            //Console.WriteLine(counter+1); 
            #endregion

            #region Problem 10 "http://codeforces.com/contest/381/problem/A"
            //int num = int.Parse(Console.ReadLine());
            //string[] numbers = new string[num];
            //int Sereja = 0;
            //int Dima = 0;
            //int s = 0, d = 0;
            //numbers = Console.ReadLine().Split(' ');
            //numbers.ToArray();
            //int[] ints = new int[num];
            //for (int k = 0; k < numbers.Length; k++)
            //{
            //    ints[k] = int.Parse(numbers[k]);
            //}
            //bool p = true;
            //int i = 0, j = ints.Length - 1;
            //while (i <= j)
            //{
            //    if (ints[i] >= ints[j])
            //    {
            //        if (p)
            //        {
            //            s += ints[i];
            //        }
            //        else
            //        {
            //            d += ints[i];
            //        }
            //        i++;
            //    }
            //    else if (ints[j] > ints[i])
            //    {
            //        if (p)
            //        {
            //            s += ints[j];
            //        }
            //        else
            //        {
            //            d += ints[j];
            //        }
            //        j--;
            //    }
            //    if (p)
            //        p = false;
            //    else
            //        p = true;
            //}
            //Console.WriteLine(s + " " + d); 
            #endregion

            #region Problem 11 "http://codeforces.com/contest/266/problem/A"
            //int num = int.Parse(Console.ReadLine());
            //string stones = Console.ReadLine();
            //int counter =0;
            //for (int i = 1;i<stones.Length;i++)
            //{
            //    if (stones[i] == stones[i-1])
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter); 
            #endregion

            #region Problem 12 "http://codeforces.com/contest/427/problem/A"
            //int numOfevents=int.Parse(Console.ReadLine());
            //string[] events=Console.ReadLine().Split(' ');
            //int[] ints=new int[numOfevents];
            //for(int i = 0; i < numOfevents; i++)
            //    ints[i] = int.Parse(events[i]);
            //int positive=0 ,counter =0;
            //for(int i = 0;i < ints.Length; i++)
            //{
            //    if (i > ints.Length)
            //        break;
            //    if (ints[i] > 0)
            //    {
            //        positive += ints[i];
            //    }
            //    else if (ints[i] < 0 && positive!=0)
            //    {
            //        positive += ints[i];
            //    }
            //    else
            //    {
            //       counter++;
            //    }
            //}
            //Console.WriteLine(counter); 
            #endregion

            #region Problem 13 "http://codeforces.com/contest/431/problem/A"
            //string[] calories = Console.ReadLine().Split(' ');
            //int[] ints = new int[calories.Length];
            //for (int i = 0; i < calories.Length; i++)
            //{
            //    ints[i] = int.Parse(calories[i]);
            //}
            //string moves2 = Console.ReadLine();
            //int[] moves = new int[moves2.Length];
            //for (int i = 0; i < moves.Length; i++)
            //{
            //    moves[i] = moves2[i] - '0';
            //}
            //int result = 0;
            //for (int i = 0; i < moves.Length; i++)
            //{
            //    if (moves[i] == 1)
            //    {
            //        result +=  ints[0];
            //    }
            //    else if (moves[i] == 2)
            //    {
            //        result += ints[1];
            //    }
            //    else if (moves[i] == 3)
            //    {
            //        result +=  ints[2];
            //    }
            //    else if (moves[i] == 4)
            //    {
            //        result +=  ints[3];
            //    }
            //}
            //Console.WriteLine(result); 
            #endregion

            #region Problem 14  "http://codeforces.com/contest/731/problem/A"
            //int count; 
            //string name = Console.ReadLine().ToLower();
            //name=name.Insert(0,'a'.ToString());
            //char start, end;
            //int totalLetters = 26;
            //int startPos;
            //int endPos;
            //int counterclockwiseDistance;
            //int result = 0;
            //for (int i = 0,j=1; j < name.Length; i++,j++)
            //{
            //    start = name[i];
            //    end = name[j];
            //    count =Math.Abs(end - start);
            //    if (start > end) { start = name[j]; end = name[i]; }
            //    startPos = start - 'a';
            //    endPos = end - 'a';
            //    counterclockwiseDistance =Math.Abs((startPos + totalLetters - endPos) % totalLetters);
            //    result +=Math.Min(counterclockwiseDistance, count);
            //}
            //Console.WriteLine(result); 
            #endregion

            #region Problem 15  "http://codeforces.com/contest/268/problem/A"
            //int games = int.Parse(Console.ReadLine());
            //int[] home = new int[games];
            //int[] guest = new int[games];
            //int counter =0;
            //for (int i = 0; i < games; i++)
            //{
            //    string[] ints = Console.ReadLine().Split(' ') ;
            //    home[i] = int.Parse(ints[0]);
            //    guest[i] = int.Parse(ints[1]);
            //}
            //for (int i = 0; i < games; i++)
            //{
            //    for (int j = 0; j < games; j++)
            //    {
            //        if (home[i] == guest[j])
            //        {
            //            counter++;
            //        }
            //    }
            //}
            //Console.WriteLine(counter); 
            #endregion

            #region Problem 16 "http://codeforces.com/contest/732/problem/A"
            //string[] input = Console.ReadLine().Split(' ');
            //int price = int.Parse(input[0]);
            //int change = int.Parse(input[1]);
            //int reminder = 0;
            //int shovel = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    shovel=i*price;
            //    reminder = (shovel % 10);
            //    if (reminder == change || reminder==0 )
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //} 
            #endregion

            #region Problem 17 "http://codeforces.com/contest/732/problem/A"
            //string[] input = Console.ReadLine().Split(' ');
            //int[] colors = new int[input.Length];
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    colors[i] = int.Parse(input[i]);
            //}
            //int counter = 0;
            //int[] ints = colors.Distinct().ToArray();
            //counter=colors.Length- ints.Length;
            //Console.WriteLine(counter); 
            #endregion

            #region Problem 18 "http://codeforces.com/contest/265/problem/A"
            //string input = Console.ReadLine();
            //string stones = Console.ReadLine();
            //int pos = 0;
            //for (int i = 0; i < stones.Length; i++)
            //{
            //    if (stones[i] == input[pos])
            //    {
            //        pos++;
            //    }
            //}
            //Console.WriteLine(pos+1); 
            #endregion

            #region Problem 19 "http://codeforces.com/contest/9/problem/A"
            //string[] input = Console.ReadLine().Split(' ');
            //int[] points = new int[input.Length];
            //for (int i = 0; i < input.Length; i++)
            //{
            //    points[i]= int.Parse(input[i]); 
            //}

            //int max = points.Max();
            //int[] chances = new int[(6-max)+1];
            //int numerator = 0;
            //for (int j=0, i = max; i <= 6; i++,j++)
            //{
            //    numerator++;
            //}
            //int denominator = 6;
            //int gcd= GCD(numerator,denominator);
            //numerator /= gcd;
            //denominator /= gcd;
            //Console.WriteLine($"{numerator}/{denominator}"); 
            #endregion

            #region Problem 20 "http://codeforces.com/contest/709/problem/A"
            //string[] input = Console.ReadLine().Split(' ');
            //int numOfOranges = int.Parse(input[0]);
            //int jucier = int.Parse(input[1]);
            //int g = int.Parse(input[2]);
            //int waste = g;
            //int result = 0;
            //string[] Oranges = Console.ReadLine().Split(' ');
            //int[] oranges = new int[numOfOranges];
            //if(Oranges.Length > numOfOranges)
            //{
            //    throw new IndexOutOfRangeException("IndexOutOfRangeException");
            //}

            //for(int i = 0; i < Oranges.Length; i++)
            //{
            //    oranges[i] = int.Parse(Oranges[i]); 
            //}
            //int counter = 0;
            //for (int i = 0; i < oranges.Length; i++)
            //{
            //    if (oranges[i] > jucier)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        waste -= oranges[i];
            //    }
            //    if(waste< 0)
            //    {
            //        counter++;
            //        waste = g;
            //    }
            //}
            //Console.WriteLine(counter); 
            #endregion

            #region Problem 21 "http://codeforces.com/contest/799/problem/A"
            //string[] input = Console.ReadLine().Split(' ');
            //int numOfCakes = int.Parse(input[0]);
            //int time = int.Parse(input[1]);
            //int bakedTime = int.Parse(input[2]); 
            //int secOven = int.Parse(input[3]);
            //int totalTime;
            //if (numOfCakes % bakedTime == 0 )
            //{
            //    totalTime=(numOfCakes/bakedTime)*time;
            //}
            //else
            //{
            //    totalTime = (numOfCakes / bakedTime);
            //    totalTime++;
            //    totalTime *= time;
            //}
            //int timeWithSecOven = secOven + time;
            //if (totalTime > timeWithSecOven)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //} 
            #endregion

            #region Problem 22 "http://codeforces.com/contest/443/problem/A"
            //string input = Console.ReadLine();
            //if (input.Length == 2)
            //{
            //    Console.WriteLine(0);
            //}
            //else
            //{
            //    string[] output = input.Substring(1, input.Length - 2).Split(", ");
            //    char[] chars = new char[output.Length];
            //    for (int i = 0; i < output.Length; i++)
            //    {
            //        chars[i] = char.Parse(output[i]);
            //    }
            //    Dictionary<char, int> dict = new Dictionary<char, int>();
            //    List<char> list = new List<char>();
            //    foreach (var s in chars)
            //        if (dict.ContainsKey(s))
            //            continue;
            //        else
            //            dict.Add(s, s);

            //    foreach (var s in dict.Keys)
            //        list.Add(s);
            //    Console.WriteLine(list.Count);
            //}
            //
            //Another Solution
            //string word = Console.ReadLine();
            //if (word.Length == 2)
            //{
            //    Console.WriteLine(0);
            //}
            //else
            //{
            //    string[] output = word.Substring(1, word.Length - 2).Split(", ");
            //    Console.WriteLine(output.Distinct().Count());
            //}
            #endregion



        }
    }
}

