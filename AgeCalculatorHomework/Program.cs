
DateTime AgeCalculator = new DateTime();
DateTime today = DateTime.Now;
TimeSpan span = today - AgeCalculator;
DateTime age = DateTime.MinValue + span;

int years = age.Year - 1;
int months = age.Month - 1;
int days = age.Day - 1;

Console.Write("{0} years, {1} months, {2} days", years, months, days);
