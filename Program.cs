// minute and hour 1
Console.Write("enter the minute ");
int minute = Convert.ToInt32(Console.ReadLine());
int min = 0;
int hour = 0;

if (minute < 60)
{
    Console.WriteLine($"just time is 00 : {minute}");
}else if (minute == 60)
{
    Console.WriteLine($"just time is 01 : 00");
}else{
    hour = minute / 60;
    min = minute % 60;

    if (hour < 10 && min < 10)
    {
      Console.WriteLine($"0{hour} : 0{min}");
    }else if(min < 10)
    {
      Console.WriteLine($"{hour} : 0{min}");
    }else if(hour < 10)
    {
      Console.WriteLine($"0{hour} : {min}");
    }
    else{
      Console.WriteLine($"{hour} : {min}");
    }
}




// age 2
Console.Write("enter the age ");
int age = Convert.ToInt32(Console.ReadLine());

if (age > 0 && age <= 12)
{
    Console.WriteLine($"bu bola {age} yoshda");
}else if(age >= 13 && age <= 19)
{
    Console.WriteLine($"bu o'smir {age} yoshda");
}else if(age >= 20 && age <= 59)
{
    Console.WriteLine($"bu kattalar {age} yoshda");
}else
{
    Console.WriteLine($"bu katta {age} yoshda");
}




// baholash 3
Console.Write("birinchi fandan balingiz 0 ... 100: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("ikkinchi fandan balingiz 0 ... 100: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("uchinchi fandan balingiz 0 ... 100: ");
int thourdNumber = Convert.ToInt32(Console.ReadLine());

int allNumber = (firstNumber + secondNumber + thourdNumber) / 3;

string total =  allNumber >= 80 && allNumber <= 100 
    ? "alo darajaga tugatdingiz":
    allNumber >= 60 && allNumber <= 79 
    ? "yahshi natijaga tugatdingiz" :
    allNumber >= 40 && allNumber <= 59 
    ? "qoniqarli natijaga tugatdingiz" :
    "qoniqarsiz natijaga tugatdingiz";
    
Console.WriteLine(total);






// oyin 3
Console.Write("tasodifiy son yoki raqam kiriting 0 ... 100: ");
int gameNumber = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int playNumber = random.Next(1, 101);

string str = playNumber > gameNumber 
   ? "siz kichik number kiritdingiz" : 
   playNumber == gameNumber 
   ? "siz numberni togri topdingiz" :
   "siz katta number kiritdingiz";

   Console.WriteLine($"siz kiritgan {gameNumber} number");
   Console.WriteLine($"dastur yaratgan {playNumber} number");

   Console.WriteLine(str);
