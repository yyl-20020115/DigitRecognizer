﻿using System.Collections.Generic;
using CsvHelper;

namespace MLParser.Interface;

public interface IRowParser
{
    /// <summary>
    /// Parses a row from the csv file and returns the label (output).
    /// </summary>
    /// <param name="reader">CsvReader</param>
    /// <returns>int</returns>
    int ReadLabel(CsvReader reader);
    /// <summary>
    /// Parses a row from the csv file and returns the data (input) fields.
    /// </summary>
    /// <param name="reader">CsvReader</param>
    /// <returns>List of double</returns>
    List<double> ReadData(CsvReader reader);
}
