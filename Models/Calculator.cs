namespace ExemploFundamentos.Models
{
    public enum CalculatorType{
        MakeAdd,
        MakeSubtract,
        MakeMultiply,
        MakeDivide,
        MakePow,
        MakeSin,
        MakeCos,
        MakeTan,
        MakeSquareRoot
    }

    public class Calculator
    {
public static void PerformCalculations(CalculatorType type, double x, double y = 0)
        {
            switch(type){
                case CalculatorType.MakeAdd:
                MakeAdd(x, y);
                break;
            case CalculatorType.MakeSubtract:
                MakeSubtract(x, y);
                break;
            case CalculatorType.MakeMultiply:
                MakeMultiply(x, y);
                break;
            case CalculatorType.MakeDivide:
                MakeDivide(x, y);
                break;
            case CalculatorType.MakePow:
                MakePow(x, y);
                break;
            case CalculatorType.MakeSin:
                MakeSin(x);
                break;
            case CalculatorType.MakeCos:
                MakeCos(x);
                break;
            case CalculatorType.MakeTan:
                MakeTan(x);
                break;
            case CalculatorType.MakeSquareRoot:
                MakeSquareRoot(x);
                break;
            default:
                Console.WriteLine("Invalid calculator type.");
                break;
            }
        }

        public static double MakeAdd(double x, double y){
            double result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");
            return result;
        }

        public static double MakeSubtract(double x, double y){
            double result = x - y;
            Console.WriteLine($"{x} - {y} = {result}");
            return result;
        }

        public static double MakeMultiply(double x, double y){
            double result = x * y;
            Console.WriteLine($"{x} * {y} = {result}");
            return result;
        }

        public static double MakeDivide(double x, double y){
            double result = x / y;
            Console.WriteLine($"{x} / {y} = {result}");
            return result;
        }

        public static double MakePow(double x, double y){
            double result = Math.Pow(x, y);
            Console.WriteLine($"{x}^{y} = {result}");
            return result;
        }

        private static double MakeRadian(double angle){
            return angle * Math.PI / 180;
        }

        public static double MakeSin(double angle){
            double result = Math.Sin(MakeRadian(angle));
            Console.WriteLine($"The sine of {angle} = {result}");
            return result;
        }

        public static double MakeCos(double angle){
            double result = Math.Cos(MakeRadian(angle));
            Console.WriteLine($"The cos of {angle} = {result}");
            return result;
        }

        public static double MakeTan(double angle){
            double result = Math.Tan(MakeRadian(angle));
            Console.WriteLine($"The tan of {angle} = {result}");
            return result;
        }

        public static double MakeSquareRoot(double x){
            double result = Math.Sqrt(x);
            Console.WriteLine($"The square root of {x} = {result}");
            return result;
        }
    }
}