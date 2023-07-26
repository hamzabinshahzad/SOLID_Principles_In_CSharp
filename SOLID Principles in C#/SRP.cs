
namespace SOLID_Principles_in_C_
{
    internal class SRP
    {

        // Example 1: Logger Class with more than one responsiblity
        // divided the class into multiple sub classes as per their multiple responsibilites
        public class LogError
        {
            public void LogErrorToTextFile(string error) { }
            public void LogErrorToDBTable(string error) { }
        }

        public class LoadErrorLogs
        {
            public string GetErrorLogs(string type) { return ""; }
        }



        // Example 2: Book class having more than a single responsibility
        // divided the class into multiple sub classes as per their multiple responsibilites
        public class Book
        {
            public string Name { get; set; }
            public string Author { get; set; }
            public string Text { get; set; }

            public bool ReplaceWordInText(string word, string newWord) { return true; }
            public string IsWordInText(string word) { return word; }
        }

        public class BookPrinter
        {
            public void PrintToConsole(string text) { }
            public void PrintToAnotherMedium(string text) { }
        }



    }
}
