










// Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.
// Console.WriteLine(Kata.FakeBin("45385593107843568"));



// using System.Linq;

// public class Kata
// {
//   public static string FakeBin(string x)
//   {
//     return string.Concat(x.Select(a => a < '5' ? "0" : "1"));
//   }
// }


// using System.Text;
// public class Kata
// {
//   public static string FakeBin(string x)
//   {
//     StringBuilder builder = new StringBuilder();
    
//     foreach (char t in x)
//     {
//       builder.Append( t >= '5' ? '1' : '0' );
//     }
        
//     return builder.ToString();
//   }
// }


// public class Kata
// {
//   public static string FakeBin(string x)
//   {
//     string result = "";
    
//     foreach (char c in x)
//                 result += c < '5' ? "0" : "1";
                
//     return result;
//   }
// }