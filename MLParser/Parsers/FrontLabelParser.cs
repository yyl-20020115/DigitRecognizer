using System;
using System.Collections.Generic;
using CsvHelper;

namespace MLParser.Parsers;

/// <summary>
/// Parses a csv file, assuming column 0 contains the label and the remaining columns contain the data.
/// </summary>
public class FrontLabelParser : BaseParser
{
    public override int ReadLabel(CsvReader reader) => int.Parse(reader[0]);

    public override List<double> ReadData(CsvReader reader) =>
        // Start at index 1, as the index 0 contains the label.
        ReadData(reader, 1);
}
