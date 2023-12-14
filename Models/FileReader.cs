namespace ExemploFundamentos.Models
{
    public class FileReader
    {
        public (bool Success, string[] Lines, int LineCount) ReadFile(string path){
            try{
                string[] lines = File.ReadAllLines(path);
                return (true, lines, lines.Length);
            }
            catch(Exception){
                return (false, Array.Empty<string>(), 0);
            }
        }
    }
}