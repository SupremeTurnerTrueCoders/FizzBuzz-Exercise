Write a public method that accepts a number

public string FizzBuzz(int number)
{
    //When the number is divisble by 3 return the word fizz
    if(number % 3 == 0)
    { 
        answer = "fizz";

    }
   
    // when the number is divisible by 5 return the word buzz

    if(number % 5 == 0) 
    {
        answer += "buzz";
 
    }

    return answer;

  
}