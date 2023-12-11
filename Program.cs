namespace hw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var docDataMiner = new DocDataMiner();
            var csvDataMiner = new CSVDataMiner();
            var pdfDataMiner = new PDFDataMiner();

            docDataMiner.Mine("mypath");
            Console.WriteLine("--------------------------------");
            csvDataMiner.Mine("mypath");
            Console.WriteLine("--------------------------------");
            pdfDataMiner.Mine("mypath");

        }
        public abstract class AbstractDataMiner
        {
            public void Mine(string path)
            {
                OpenFile(path);
                ExtractData();
                ParseData();
                AnalyzeData();
                SendReport();
                CloseFile();
            }

            public void OpenFile(string path)
            {
                Console.WriteLine("AbstractDataMiner: OpenFile");
            }

            public void AnalyzeData()
            {
                Console.WriteLine("AbstractDataMiner: AnalyzeData");
            }
            public void SendReport()
            {
                Console.WriteLine("AbstractDataMiner: SendReport");
            }
            public void CloseFile()
            {
                Console.WriteLine("AbstractDataMiner: CloseFile");
            }

            public abstract void ExtractData();
            public abstract void ParseData(); 
        }

        public class DocDataMiner : AbstractDataMiner
        {
            public override void ExtractData()
            {
                Console.WriteLine("DocDataMiner: ExtractData");
            }

            public override void ParseData()
            {
                Console.WriteLine("DocDataMiner: ParseData");
            }
        }

        public class CSVDataMiner : AbstractDataMiner
        {
            public override void ExtractData()
            {
                Console.WriteLine("CSVDataMiner: ExtractData");
            }

            public override void ParseData()
            {
                Console.WriteLine("CSVDataMiner: ParseData");
            }
        }

        public class PDFDataMiner : AbstractDataMiner
        {
            public override void ExtractData()
            {
                Console.WriteLine("PDFDataMiner: ExtractData");
            }

            public override void ParseData()
            {
                Console.WriteLine("PDFDataMiner: ParseData");
            }
        }
    }
}
