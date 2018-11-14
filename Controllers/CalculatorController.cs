using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;
using MyMathRoutines;

namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {
       public IActionResult Add(decimal left, decimal right)
       {

           ViewData["AddResult"] = $"{left} plus {right} is: {MathConverter.Add(left,right)}";
           return View();
       }
       public IActionResult Subtract(decimal left, decimal right)
       {

           ViewData["SubtractResult"] = $"{left} minus {right} is: {MathConverter.Subtract(left,right)}";
           return View();
       }
       public IActionResult Multiply(decimal left, decimal right)
       {
           ViewData["MultiplyResult"] = $"{left} multiplied by {right} is: {MathConverter.Multiply(left, right)}";
           return View();
       }
       public IActionResult Divide(decimal left, decimal right)
       {
           ViewData["DivideResult"] = $"{left} divided by {right} is: {MathConverter.Divide(left, right)}";
           return View();
       }
       public IActionResult Powers(double left, double right)
       {
           ViewData["PowersResult"] = $"{left} to the power of {right} is: {MathConverter.Power(left, right)}";
           return View();
       }
       public IActionResult Ceiling(decimal number)
       {
           ViewData["CeilingResult"] = $"The ceiling of {number} is: {MathConverter.Ceiling(number)}";
           return View();
       }
       public IActionResult Floor(decimal number)
       {
           ViewData["FloorResult"] = $"The floor of {number} is: {MathConverter.Floor(number)};";
           return View();
       }
    }
}