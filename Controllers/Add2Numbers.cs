using Microsoft.AspNetCore.Mvc;

namespace MannASayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Add2NumbersController : ControllerBase
{
  [HttpGet]
  public string AddDefault()
  {
    int num1 = 5;
    int num2 = 10;
    return $"{num1} plus {num2} equals {num1 + num2}!";
  }

  [HttpGet]
  [Route("{num1}/{num2}")]

  public string Add(string num1, string num2)
  {
    int convertNum1;
    int convertNum2;
    bool isNum1Valid = Int32.TryParse(num1, out convertNum1);
    bool isNum2Valid = Int32.TryParse(num2, out convertNum2);
    string result = "Please enter valid numbers.";
    if (isNum1Valid && isNum2Valid)
    {
      result = $"{num1} plus {num2} equals {convertNum1 + convertNum2}!";
    }
    return result;
  }
}
