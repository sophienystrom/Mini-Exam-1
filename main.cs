using System;

class MainClass {
  public static void Main (string[] args) {
  
  Console.WriteLine ("Write your name");
  var name = Console.ReadLine ();
  Console.WriteLine ("Write height in inches");
  var height = Console.ReadLine ();
  double h = Convert.ToDouble (height);
  Console.WriteLine ("Give weight in pounds"); 
  var weight = Console.ReadLine ();
  double w = Convert.ToDouble (weight);
  var BMI = ((703 * w)/(h * h));
  Console.WriteLine ("The BMI of " + name + "= " + BMI);

  if (BMI < 18.5) {
    Console.WriteLine ("Your health status is: underweight");
  }
  if (BMI >= 18.5 && BMI <= 24.9) {
    Console.WriteLine ("Your health status is: Normal or Healthy weight");
  }
  if (BMI >= 25 && BMI <= 29.9) {
    Console.WriteLine ("Your health status is: Overweight");
  }
  if (BMI >= 30) {
    Console.WriteLine ("Your health status is: Obese");
  }

  }
}