namespace Calculator
{
    class Calcualte
    {
        string[] operators = { "+", "-", "*", "/" };
        string[] Splitter;

        List<double> numbers = new List<double>();
        List<string> UsedOperators = new List<string>();


        public Calcualte()
        {

        }

        public string RemoveLastChar(string expression)
        {
            if (expression.Length == 0) { return expression; }
            return expression.Substring(0, expression.Length - 1);
        }

        public string Calc(string expression)
        {
            foreach (char sign in expression)
            {

                if (sign == '+') { UsedOperators.Add("+"); }
                else if (sign == '-') { UsedOperators.Add("-"); }
                else if (sign == '*') { UsedOperators.Add("*"); }
                else if (sign == '/') { UsedOperators.Add("/"); }
            }

            Splitter = expression.Split(operators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in Splitter)
            {
                double number = double.Parse(item);
                numbers.Add(number);
            }
            double result = numbers[0];
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                string op = UsedOperators[i];
                switch (op)
                {
                    case "+":
                        result += numbers[i + 1]; // Sčítání
                        break;
                    case "-":
                        result -= numbers[i + 1]; // Odčítání
                        break;
                    case "*":
                        result *= numbers[i + 1]; // Násobení
                        break;
                    case "/":
                        result /= numbers[i + 1]; // Dělení
                        break;
                    default:
                        // Chyba - neznámý operátor
                        break;
                }
            }
            numbers.Clear();
            UsedOperators.Clear();


            return result.ToString();
        }

    }
}
