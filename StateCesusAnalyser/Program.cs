using StateCesusAnalyser.DTO;
using StateCesusAnalyser.UsingCode;

namespace StateCesusAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string filePathStateCensus = @"D:\DotNetPrograms\IndianStateCensusAnalyser\StateCesusAnalyser\UsingCensus\StateCensus.csv";
           string filePath = @"D:\DotNetPrograms\IndianStateCensusAnalyser\StateCesusAnalyser\UsingCode\StateCode.csv";

            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            int StateCensusRecords = analyzer.ReadStateCensusData(filePathStateCensus);
            CSVStateCensus census = new CSVStateCensus();
            int censusRecords = census.ReadStateCensusData(filePathStateCensus);
            if (StateCensusRecords == censusRecords)
                 Console.WriteLine("Number of records match");

            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            int StateCodeRecords = stateCodeAnalyzer.ReadStateCodeData(filePath);
            CSVStateCensus stateCode = new CSVStateCensus();
            int codeRecords = stateCode.ReadStateCodeData(filePath);
            if (StateCodeRecords==codeRecords)
                Console.WriteLine("Number of records match");
        }

    }
}