using System.Collections.Generic;
using CsvHelper;

namespace MLParser.Parsers;

/// <summary>
/// Parses a csv file in its entirety as data. Assumes no label is present and all columns will be data points. Useful for test.csv files (which usually do not contain labels).
/// </summary>
public class TestParser : BaseParser
{
    public override int ReadLabel(CsvReader reader) => 0;

    public override List<double> ReadData(CsvReader reader) => ReadData(reader, 0);
}
